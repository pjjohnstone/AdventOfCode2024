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

let applyRules result stone =
  match stone with
  | 0L -> result@[1L]
  | _ ->
    match stone.ToString().Length % 2 with
    | 0 -> result@(splitStone stone)
    | _ -> result@[stone * 2024L]

let blinkTimes blinks stones =
  let rec blink blinks stones =
    match blinks with
    | 0 -> stones
    | _ ->
      stones
      |> List.fold applyRules []
      |> blink (blinks - 1)
  blink blinks stones
  
let calculate stones blinks =
  stones
  |> blinkTimes blinks
  |> List.length