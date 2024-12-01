open AdventOfCode2024

let lines = Common.getLines "Day1/input.txt"
printfn $"Total Distance: %i{(AdventOfCode2024.Day1.calculate AdventOfCode2024.Day1.sumDistances lines)}"
printfn $"Total Similarity: %i{(AdventOfCode2024.Day1.calculate AdventOfCode2024.Day1.sumSimilarity lines)}"