namespace AdventOfCode2024.CSharp.Day11;

public static class Day11
{
    public static List<Stone> ParseLine(string input)
    {
        return input.Split(" ").Select(Stone.Parse).ToList();
    }

    public static int SumStones(List<Stone> stones, int blinks)
    {
        return stones.Select(stone => stone.BlinkTimes(blinks)).SelectMany(x => x).ToList().Count;
    }
}