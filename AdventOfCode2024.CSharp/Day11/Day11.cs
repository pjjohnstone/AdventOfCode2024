namespace AdventOfCode2024.CSharp.Day11;

public static class Day11
{
    public static List<Stone> ParseLine(string input)
    {
        return input.Split(" ").Select(Stone.Parse).ToList();
    }

    public static int SumStones(List<Stone> stones, int blinks)
    {
        return BlinkTimes(stones, blinks).Count;
    }

    private static List<Stone> BlinkTimes(List<Stone> stones, int blinks)
    {
        if (blinks == 0 ) return stones;
        
        var results = new List<List<Stone>>()
        {
            {stones}
        };
        
        while (blinks > 0)
        {
            var currentStones = results.SelectMany(stone => stone).ToList();
            results = currentStones.Select(stone => stone.Blink()).ToList();
            blinks--;
        }
        
        return results.SelectMany(stone => stone).ToList();
    }
}