module AdventOfCode2024.Day11.Day11

open AdventOfCode2024

let splitStone stone =
  let digits = stone.ToString()
  digits
  |> Seq.splitInto 2
  |> Seq.map (fun chars ->
    chars
    |> System.String.Concat
    |> stringToInt)
  |> Seq.toList

let applyRules result stone =
  match stone with
  | 0 -> result@[1]
  | _ ->
    match stone.ToString().Length % 2 with
    | 0 -> result@(splitStone stone)
    | _ -> result@[stone * 2024]

let blinkTimes blinks stones =
  let rec blink blinks stones =
    match blinks with
    | 0 -> stones
    | _ ->
      stones
      |> List.fold applyRules []
      |> fun stones -> blink (blinks - 1) stones
  blink blinks stones