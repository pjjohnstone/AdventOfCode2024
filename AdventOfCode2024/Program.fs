open AdventOfCode2024
open AdventOfCode2024.Day11.Day11

let lines = getLines "Day11/input.txt"
let blinks = 30
printfn $"Total stones after %i{blinks} blinks: %i{ timer (fun () -> calculate (parse lines.Head) blinks)}"