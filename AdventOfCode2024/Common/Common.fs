﻿[<AutoOpen>]
module AdventOfCode2024.Common

open System.IO

let getLines path =
  Array.toList (File.ReadAllLines path)

let charToInt (c: char) =
  int c - int '0'

let stringToInt str =
  System.Int32.Parse str

let stringToInt64 str =
  System.Int64.Parse str

let stringReverse (str: string) =
  str
  |> Seq.toArray
  |> Array.rev
  |> System.String.Concat
