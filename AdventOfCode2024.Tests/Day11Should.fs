module AdventOfCode2024.Tests.Day11Should

open NUnit.Framework
open AdventOfCode2024.Day11.Day11

let exampleSources = [
  TestCaseData([0L; 1L; 10L; 99L; 999L], 1).Returns([1L; 2024L; 1L; 0L; 9L; 9L; 2021976L])
  TestCaseData([125L; 17L], 1).Returns([253000L; 1L; 7L])
  TestCaseData([125L; 17L], 2).Returns([253L; 0L; 2024L; 14168L])
  TestCaseData([125L; 17L], 3).Returns([512072L; 1L; 20L; 24L; 28676032L])
  TestCaseData([125L; 17L], 4).Returns([512L; 72L; 2024L; 2L; 0L; 2L; 4L; 2867L; 6032L])
  TestCaseData([125L; 17L], 5).Returns([1036288L; 7L; 2L; 20L; 24L; 4048L; 1L; 4048L; 8096L; 28L; 67L; 60L; 32L])
  TestCaseData([125L; 17L], 6).Returns([2097446912L; 14168L; 4048L; 2L; 0L; 2L; 4L; 40L; 48L; 2024L; 40L; 48L; 80L; 96L; 2L; 8L; 6L; 7L; 6L; 0L; 3L; 2L])
]

[<TestCaseSource(nameof(exampleSources))>]
let ``Apply blink rules`` input =
  let stones, blinks = input
  blinkTimes blinks stones
  
let parserCase = [
  TestCaseData("28 4 3179 96938 0 6617406 490 816207").Returns([28L; 4L; 3179L; 96938L; 0L; 6617406L; 490L; 816207L])
]

[<TestCaseSource(nameof(parserCase))>]
let ``Parse puzzle input`` input =
  parse input
  
let sumStonesCases = [
  TestCaseData([125L; 17L], 6).Returns(22)
]

[<TestCaseSource(nameof(sumStonesCases))>]
let ``Sums number of stones after blinking`` input =
  let stones, blinks = input
  calculate stones blinks