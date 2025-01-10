namespace AdventOfCode2024.CSharp.Tests;

public class Day11Should
{
    [TestCaseSource(typeof(Day11Data), nameof(Day11Data.TestCases))]
    public List<int> Apply_the_blink_rules(List<int> input, int blinks) 
    {
        return Day11.Day11.BlinkTimes(input, blinks);
    }
}