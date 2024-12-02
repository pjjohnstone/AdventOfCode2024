open AdventOfCode2024
open AdventOfCode2024.Day2.Day2

let lines = getLines "Day2/input.txt"
printfn $"Total Safe reports: %i{(calculate sumSafeReports lines)}"