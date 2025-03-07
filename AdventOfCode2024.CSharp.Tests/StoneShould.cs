using AdventOfCode2024.CSharp.Day11;

namespace AdventOfCode2024.CSharp.Tests;

[TestFixture]
public class StoneShould
{
    [TestCaseSource(typeof(StoneData), nameof(StoneData.ParseData))]
    public long Parse_string_into_Stone_value(string input)
    {
        return Stone.Parse(input).Value;
    }
}