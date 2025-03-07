namespace AdventOfCode2024.CSharp.Day11;

public class Stone(long value)
{
    public long Value { get; } = value;

    // public List<Stone> BlinkTimes(int blinks)
    // {
    //     return blinks == 0 ? [this] : RecursiveBlink(blinks);
    // }
    //
    // private List<Stone> RecursiveBlink(int blinks)
    // {
    //     blinks--;
    //     var newStones = Blink();
    //     return newStones.Select(stone => stone.BlinkTimes(blinks)).SelectMany(stone => stone).ToList();
    // }

    public List<Stone> Blink()
    {
        if (Value.ToString().Length % 2 == 0) return Split();
        return Value switch
        {
            0 => [new Stone(1)],
            _ => [new Stone(Value * 2024)]
        };
    }

    private List<Stone> Split()
    {
        var digits = Value.ToString().ToCharArray();
        var first = digits.Take(digits.Length / 2);
        var second = digits.Skip(digits.Length / 2);
        return [new Stone(long.Parse(string.Join("", first))), new Stone(long.Parse(string.Join("", second)))];
    }

    public static Stone Parse(string input)
    {
        return new Stone(long.Parse(input));
    }
}