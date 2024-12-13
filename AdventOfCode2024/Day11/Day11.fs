module AdventOfCode2024.Day11.Day11

open AdventOfCode2024

let parse (input: string) =
  input.Split(" ")
  |> Array.map stringToInt64
  |> Array.toList

let splitStone stone =
  let digits = stone.ToString()
  digits
  |> Seq.splitInto 2
  |> Seq.map (fun chars ->
    chars
    |> System.String.Concat
    |> stringToInt64)
  |> Seq.toList

let applyRules stone result  =
  match stone with
  | 0L -> [1L]@result
  | _ ->
    match stone.ToString().Length % 2 with
    | 0 -> (splitStone stone)@result
    | _ -> [stone * 2024L]@result
    
let applyRulesAsync stones =
  async {
    return List.foldBack applyRules stones []
  }

let rec blinkTimes blinks (stones: int64 list) =
  printfn $"%i{blinks} blinks remaining"
  match blinks with
  | 0 -> stones
  | _ ->
    stones
    |> List.chunkBySize 100
    |> List.map applyRulesAsync
    |> Async.Parallel
    |> Async.RunSynchronously
    |> List.concat
    |> blinkTimes (blinks - 1)
  
let calculate stones blinks =
  stones
  |> blinkTimes blinks
  |> List.length