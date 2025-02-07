using AdventOfCode2024.CSharp.Day11;

namespace AdventOfCode2024.CSharp.Tests;

[TestFixture]
public class StoneShould
{
    [TestCaseSource(typeof(StoneData), nameof(StoneData.BlinkData))]
    public List<long> Blink_x_times(Stone stone, int blinks)
    {
        return stone.BlinkTimes(blinks).Select(resulStone => resulStone.Value).ToList();
    }

    [TestCaseSource(typeof(StoneData), nameof(StoneData.ParseData))]
    public long Parse_string_into_Stone_value(string input)
    {
        return Stone.Parse(input).Value;
    }
}