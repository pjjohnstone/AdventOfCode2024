using System.Collections;

namespace AdventOfCode2024.CSharp.Tests;

public static class Day11Data
{
    public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(new List<int> {0, 1, 10, 99, 999}, 1).Returns(new List<int>{1, 2024, 1, 0, 9, 9, 2021976});
            yield return new TestCaseData(new List<int> { 125, 17 }, 1).Returns(new List<int> { 253000, 1, 7 });
            yield return new TestCaseData(new List<int> { 125, 17 }, 2).Returns(new List<int> { 253, 0, 2024, 14168 });
            yield return new TestCaseData(new List<int> { 125, 17 }, 3).Returns(new List<int>
                { 512072, 1, 20, 24, 28676032 });
            yield return new TestCaseData(new List<int> { 125, 17 }, 4).Returns(new List<int>
                { 512, 72, 2024, 2, 0, 2, 4, 2867, 6032 });
            yield return new TestCaseData(new List<int> { 125, 17 }, 5).Returns(new List<int>
                { 1036288, 7, 2, 20, 24, 4048, 1, 4048, 8096, 28, 67, 60, 32 });
            yield return new TestCaseData(new List<int> { 125, 17 }, 6).Returns(new List<int>
                { 2097446912, 14168, 4048, 2, 0, 2, 4, 40, 48, 2024, 40, 48, 80, 96, 2, 8, 6, 7, 6, 0, 3, 2 });
        }
    }
}