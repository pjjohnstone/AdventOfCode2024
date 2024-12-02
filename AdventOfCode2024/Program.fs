open AdventOfCode2024
open AdventOfCode2024.Day1

let lines = getLines "Day1/input.txt"
printfn $"Total Distance: %i{(AdventOfCode2024.Day1.calculate sumDistances lines)}"
printfn $"Total Similarity: %i{(AdventOfCode2024.Day1.calculate sumSimilarity lines)}"