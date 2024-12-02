module AdventOfCode2024.Tests.Day1Should

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

let similaritySources = [
  TestCaseData(3, [4;3;5;3;9;3]).Returns(9)
  TestCaseData(4, [4;3;5;3;9;3]).Returns(4)
  TestCaseData(2, [4;3;5;3;9;3]).Returns(0)
]

[<TestCaseSource(nameof(similaritySources))>]
let ``Calculate similarity of an int and a list`` input =
  let candidate, list = input
  similarity list 0 candidate

let sumSimilaritySources = [
  TestCaseData([3;4;2;1;3;3], [4;3;5;3;9;3]).Returns(31)
]

[<TestCaseSource(nameof(sumSimilaritySources))>]
let ``Calculate similarity of two lists`` input =
  let left, right = input
  sumSimilarity left right