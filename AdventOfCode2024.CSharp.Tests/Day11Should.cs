using AdventOfCode2024.CSharp.Day11;

namespace AdventOfCode2024.CSharp.Tests;

public class Day11Should
{
    [TestCaseSource(typeof(Day11Data), nameof(Day11Data.ParserCases))]
    public List<long> Parse_puzzle_input(string input)
    {
        return Day11.Day11.ParseLine(input).Select(stone => stone.Value).ToList();
    }

    [TestCaseSource(typeof(Day11Data), nameof(Day11Data.SumCases))]
    public int Sum_stones_after_blinks(List<Stone> input, int blinks)
    {
        return Day11.Day11.SumStones(input, blinks);
    }
}