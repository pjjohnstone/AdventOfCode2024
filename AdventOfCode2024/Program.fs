open AdventOfCode2024
open AdventOfCode2024.Day11.Day11

let lines = getLines "Day11/input.txt"
printfn $"Total Stones after 25 blinks: %i{calculate (parse lines.Head) 25}"