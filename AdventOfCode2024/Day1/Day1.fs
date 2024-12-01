module AdventOfCode2024.Day1

let distance state left right :int =
  if left < right then state + (right - left)
  else state + (left - right)
  
let sumDistances left right =
  left
  |> List.sort
  |> List.fold2 distance 0 (List.sort right)
  
let charsToInt (chars: char list) =
  chars
  |> System.String.Concat
  |> stringToInt
  
let parseLine input =
  input
  |> String.filter (fun c -> c <> ' ')
  |> Seq.toList
  |> fun chars ->
    List.take 5 chars |> charsToInt,
    List.skip 5 chars |> charsToInt
    
let parseLines inputs =
  inputs
  |> List.map parseLine
  |> List.unzip
  
let similarity list state candidate :int =
  list
  |> List.filter (fun i -> i = candidate)
  |> fun matches -> state + matches.Length * candidate
  
let sumSimilarity left right =
  let rightSimilar = similarity right
  left
  |> List.fold rightSimilar 0

let calculate func puzzleInputLines =
  puzzleInputLines
  |> parseLines
  |> fun (left, right) -> func left right