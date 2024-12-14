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

let arrayChunker (element: 'a list) (result: 'a list array) =
  let listOfLists = List.splitInto 2 element
  let arrayOfLists = listOfLists |> List.toArray
  Array.append result arrayOfLists

let blinkTimes blinks (stones: int64 list) =
  let rec blinkTimesRec blinks (stones: int64 list array) =
    printfn $"%i{blinks} blinks remaining"
    match blinks with
    | 0 -> stones |> List.concat
    | _ ->
      stones
      |> Array.foldBack [||] arrayChunker
      |> Array.map applyRulesAsync
      |> Async.Parallel
      |> Async.RunSynchronously
      |> blinkTimesRec (blinks - 1)
  blinkTimesRec blinks [|stones|]
  
let calculate stones blinks =
  stones
  |> blinkTimes blinks
  |> List.length