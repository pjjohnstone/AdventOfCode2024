using System.Collections;
using AdventOfCode2024.CSharp.Day11;

namespace AdventOfCode2024.CSharp.Tests;

public static class Day11Data
{
    public static IEnumerable ParserCases
    {
        get
        {
            yield return new TestCaseData("28 4 3179 96938 0 6617406 490 816207").Returns(new List<long>
            {
                28, 4, 3179, 96938, 0, 6617406, 490, 816207
            });
        }
    }

    public static IEnumerable SumCases
    {
        get
        {
            yield return new TestCaseData(new List<Stone>{ new(125), new(17) }, 6).Returns(22);
        }
    }
}