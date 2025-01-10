using System.Text;

namespace AdventOfCode2024.CSharp.Day11;

public static class Day11
{
    public static List<int> BlinkTimes(List<int> input, int blinks)
    {
        var result = new List<List<int>> { input };
        while (blinks > 0)
        {
            var newInput = result.SelectMany(x => x).ToList();
            result = newInput.Select(ApplyRules).ToList();
            blinks--;
        }
        
        return result.SelectMany(x => x).ToList();
    }

    private static List<int> ApplyRules(int stone)
    {
        if (stone == 0) return [1];
        return (stone.ToString().Length % 2) switch
        {
            0 => SplitStone(stone),
            _ => [stone * 2024]
        };
    }

    private static List<int> SplitStone(int stone)
    {
        var digits = stone.ToString().ToCharArray();
        var first = digits.Take(digits.Length / 2);
        var second = digits.Skip(digits.Length / 2);
        return [int.Parse(string.Join("", first)), int.Parse(string.Join("", second))];
    }
}