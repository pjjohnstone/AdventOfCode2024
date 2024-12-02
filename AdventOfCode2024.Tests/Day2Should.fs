module AdventOfCode2024.Tests.Day2Should

open NUnit.Framework
open AdventOfCode2024.Day2.Day2

let safetyCases = [
  TestCaseData([7; 6; 4; 2; 1]).Returns(Safe)
  TestCaseData([1; 2; 7; 8; 9]).Returns(Unsafe)
  TestCaseData([9; 7; 6; 2; 1]).Returns(Unsafe)
  TestCaseData([1; 3; 2; 4; 5]).Returns(Unsafe)
  TestCaseData([8; 6; 4; 4; 1]).Returns(Unsafe)
  TestCaseData([1; 3; 6; 7; 9]).Returns(Safe)
]

[<TestCaseSource(nameof(safetyCases))>]
let ``Determine safety of a report`` input =
  checkReport input