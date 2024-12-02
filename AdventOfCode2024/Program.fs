open AdventOfCode2024
open AdventOfCode2024.Day2.Day2

let lines = getLines "Day2/input.txt"
printfn $"Total Safe reports: %i{(calculate (sumSafeReports checkReport) lines)}"
printfn $"Total Safe reports with Problem Dampener: %i{(calculate (sumSafeReports checkReportWithDampener) lines)}"