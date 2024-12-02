module AdventOfCode2024.Day2.Day2

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
  
let checkSequence report =
  match isSequential report with
  | true -> Some(report)
  | false -> None
  
let checkGaps report =
  match report with
  | None -> report
  | Some _ ->
    match gapsAreAcceptable report with
    | true -> report
    | false -> None

let checkReport report =
  report
  |> checkSequence
  |> checkGaps
  |> fun report ->
    match report with
    | Some _ -> Safe
    | None -> Unsafe