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
  
let parserCases = [
  TestCaseData("7 6 4 2 1").Returns([7; 6; 4; 2; 1])
  TestCaseData("40 42 43 46 47 48 49 49").Returns([40; 42; 43; 46; 47; 48; 49; 49])
]

[<TestCaseSource(nameof(parserCases))>]
let ``Parse input lines`` input =
  parseLine input

let sumSafetyCases =
  [ TestCaseData(
      [ [ 7; 6; 4; 2; 1 ]
        [ 1; 2; 7; 8; 9 ]
        [ 9; 7; 6; 2; 1 ]
        [ 1; 3; 2; 4; 5 ]
        [ 8; 6; 4; 4; 1 ]
        [ 1; 3; 6; 7; 9 ] ]
    )
      .Returns(2) ]
  
[<TestCaseSource(nameof(sumSafetyCases))>]
let ``Sum safe reports`` input =
  sumSafeReports input