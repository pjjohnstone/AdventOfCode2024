module AdventOfCode2024.Tests.Day2Should

open NUnit.Framework
open AdventOfCode2024.Day2.Day2

let safetyCases = [
  TestCaseData(Some([7; 6; 4; 2; 1])).Returns(Safe)
  TestCaseData(Some([1; 2; 7; 8; 9])).Returns(Unsafe)
  TestCaseData(Some([9; 7; 6; 2; 1])).Returns(Unsafe)
  TestCaseData(Some([1; 3; 2; 4; 5])).Returns(Unsafe)
  TestCaseData(Some([8; 6; 4; 4; 1])).Returns(Unsafe)
  TestCaseData(Some([1; 3; 6; 7; 9])).Returns(Safe)
]

[<TestCaseSource(nameof(safetyCases))>]
let ``Determine safety of a report`` input =
  checkReport input
  
let parserCases = [
  TestCaseData("7 6 4 2 1").Returns(Some([7; 6; 4; 2; 1]))
  TestCaseData("40 42 43 46 47 48 49 49").Returns(Some([40; 42; 43; 46; 47; 48; 49; 49]))
]

[<TestCaseSource(nameof(parserCases))>]
let ``Parse input lines`` input =
  parseLine input

let sumSafetyCases =
  [ TestCaseData(
      [ Some([ 7; 6; 4; 2; 1 ])
        Some([ 1; 2; 7; 8; 9 ])
        Some([ 9; 7; 6; 2; 1 ])
        Some([ 1; 3; 2; 4; 5 ])
        Some([ 8; 6; 4; 4; 1 ])
        Some([ 1; 3; 6; 7; 9 ]) ]
    )
      .Returns(2) ]
  
[<TestCaseSource(nameof(sumSafetyCases))>]
let ``Sum safe reports`` input =
  sumSafeReports input
  
let safetyCasesWithDampener = [
  TestCaseData(Some([7; 6; 4; 2; 1])).Returns(Safe)
  TestCaseData(Some([1; 2; 7; 8; 9])).Returns(Unsafe)
  TestCaseData(Some([9; 7; 6; 2; 1])).Returns(Unsafe)
  TestCaseData(Some([1; 3; 2; 4; 5])).Returns(Safe)
  TestCaseData(Some([8; 6; 4; 4; 1])).Returns(Safe)
  TestCaseData(Some([1; 3; 6; 7; 9])).Returns(Safe)
  TestCaseData(Some([1; 3; 6; 7; 11])).Returns(Safe)
]

[<TestCaseSource(nameof(safetyCasesWithDampener))>]
let ``Determine safety of a report with problem dampener`` input =
  checkReportWithDampener input