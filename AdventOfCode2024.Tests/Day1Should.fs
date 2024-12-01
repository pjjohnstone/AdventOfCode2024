module AdventOfCode2024.Tests

open NUnit.Framework
open AdventOfCode2024.Day1

let distanceSources = [
  TestCaseData([3;4;2;1;3;3], [4;3;5;3;9;3]).Returns(11)
]

[<TestCaseSource("distanceSources")>]
let ``Sum distances between values`` input =
  let left, right = input
  sumDistances left right
  
let parseLinesSources = [
  TestCaseData([
    "62619   25903"
    "30326   94750"
  ]).Returns([62619; 30326],[25903; 94750])
]

[<TestCaseSource("parseLinesSources")>]
let ``Parse many input lines`` inputs =
  parseLines inputs