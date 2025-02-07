using System.Collections;
using AdventOfCode2024.CSharp.Day11;

namespace AdventOfCode2024.CSharp.Tests;

public static class StoneData
{
    public static IEnumerable BlinkData
    {
        get
        {
            yield return new TestCaseData(new Stone(0), 0).Returns(new List<long>{ 0 });
            yield return new TestCaseData(new Stone(0), 1).Returns(new List<long>{ 1 });
            yield return new TestCaseData(new Stone(1), 1).Returns(new List<long>{ 2024 });
            yield return new TestCaseData(new Stone(11), 1).Returns(new List<long>{ 1, 1 });
            yield return new TestCaseData(new Stone(11), 2).Returns(new List<long>{ 2024, 2024 });
            yield return new TestCaseData(new Stone(11), 3).Returns(new List<long>{ 20, 24, 20, 24 });
        }
    }

    public static IEnumerable ParseData
    {
        get
        {
            yield return new TestCaseData("96938").Returns(96938);
        }
    }
}