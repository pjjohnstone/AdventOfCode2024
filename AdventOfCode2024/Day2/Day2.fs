module AdventOfCode2024.Day2.Day2

open AdventOfCode2024

type Safety =
  | Safe
  | Unsafe

let isAscending (report: int list option) =
  match report with
  | None -> false
  | Some r ->
    r
    |> List.pairwise
    |> List.forall (fun (left,right) -> left < right)
  
let isDescending (report: int list option) =
  match report with
  | None -> false
  | Some r ->
    r
    |> List.pairwise
    |> List.forall (fun (left,right) -> left > right)

let isSequential (report: int list option) =
  report
  |> fun report -> isAscending report || isDescending report
  
let problemDampener report func index =
  match report with
    | None -> false
    | Some r ->
      let reducedList =    
        r
        |> List.removeAt index
        |> Some
      func reducedList
 
let dampener func (report: int list option) =
  match report with
  | None -> false
  | Some r ->
    r
    |> List.mapi (fun i _ ->
      r
      |> List.removeAt i
      |> Some
      |> func)
    |> List.exists (fun b -> b = true)
  
let isSequentialDampened report =
  match isSequential report with
  | true -> true
  | false ->
    report
    |> dampener isSequential
  
let gapsAreAcceptable report =
  match report with
  | None -> false
  | Some(r) ->
    r
    |> List.pairwise
    |> List.forall (fun (left, right) -> abs(left - right) < 4)
    
let gapsAreAcceptableDampened report =
  match gapsAreAcceptable report with
  | true -> true
  | false ->
    report
    |> dampener gapsAreAcceptable
  
let checkSequence sequenceChecker (report: int list option) =
  match sequenceChecker report with
  | true -> report
  | false -> None
  
let checkGaps gapTester (report: int list option) =
  match report with
  | None -> report
  | Some _ ->
    match gapTester report with
    | true -> report
    | false -> None

let checkReport (report: int list option) =
  report
  |> checkSequence isSequential
  |> checkGaps gapsAreAcceptable
  |> fun report ->
    match report with
    | Some _ -> Safe
    | None -> Unsafe
    
let checkReportWithDampener (report: int list option) =
  report
  |> checkSequence isSequentialDampened
  |> checkGaps gapsAreAcceptableDampened
  |> fun report ->
    match report with
    | Some _ -> Safe
    | None -> Unsafe
    
let parseLine (line: string) =
  line.Split ' '
  |> Array.toList
  |> List.map stringToInt
  |> Some
 
let sumSafeReports func reports =
  reports
  |> List.map func
  |> List.filter (fun r -> r = Safe)
  |> List.length
 
let calculate func lines =
  lines
  |> List.map parseLine
  |> func