﻿module AdventOfCode2024.Tests.Day11Should

open NUnit.Framework
open AdventOfCode2024.Day11.Day11

let exampleSources = [
  TestCaseData([0; 1; 10; 99; 999], 1).Returns([1; 2024; 1; 0; 9; 9; 2021976])
  TestCaseData([125; 17], 1).Returns([253000; 1; 7])
  TestCaseData([125; 17], 2).Returns([253; 0; 2024; 14168])
  TestCaseData([125; 17], 3).Returns([512072; 1; 20; 24; 28676032])
  TestCaseData([125; 17], 4).Returns([512; 72; 2024; 2; 0; 2; 4; 2867; 6032])
  TestCaseData([125; 17], 5).Returns([1036288; 7; 2; 20; 24; 4048; 1; 4048; 8096; 28; 67; 60; 32])
  TestCaseData([125; 17], 6).Returns([2097446912; 14168; 4048; 2; 0; 2; 4; 40; 48; 2024; 40; 48; 80; 96; 2; 8; 6; 7; 6; 0; 3; 2])
]

[<TestCaseSource(nameof(exampleSources))>]
let ``Apply blink rules`` input =
  let stones, blinks = input
  blinkTimes blinks stones