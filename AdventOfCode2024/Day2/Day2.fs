module AdventOfCode2024.Day2.Day2

open AdventOfCode2024

type Safety =
  | Safe
  | Unsafe

let isAscending report =
  report
  |> List.pairwise
  |> List.forall (fun (left,right) -> left < right)
  
let isDescending report =
  report
  |> List.pairwise
  |> List.forall (fun (left,right) -> left > right)

let isSequential report =
  report
  |> fun report -> isAscending report || isDescending report
  
let gapsAreAcceptable report =
  match report with
  | None -> false
  | Some(r) ->
    r
    |> List.pairwise
    |> List.forall (fun (left, right) -> abs(left - right) < 4)    
  
let checkSequence sequenceChecker report =
  match sequenceChecker report with
  | true -> Some(report)
  | false -> None
  
let checkGaps gapTester report =
  match report with
  | None -> report
  | Some _ ->
    match gapTester report with
    | true -> report
    | false -> None

let checkReport report =
  report
  |> checkSequence isSequential
  |> checkGaps gapsAreAcceptable
  |> fun report ->
    match report with
    | Some _ -> Safe
    | None -> Unsafe
    
let parseLine (line: string) =
  line.Split ' '
  |> Array.toList
  |> List.map stringToInt
 
let sumSafeReports reports =
  reports
  |> List.map checkReport
  |> List.filter (fun r -> r = Safe)
  |> List.length
 
let calculate func lines =
  lines
  |> List.map parseLine
  |> func