namespace AdventOfCode2024.CSharp.Day11;

public static class Day11
{
    public static List<Stone> ParseLine(string input)
    {
        return input.Split(" ").Select(Stone.Parse).ToList();
    }

    public static int SumStones(List<Stone> stones, int blinks)
    {
        var tasks = stones.Select(stone => new Task<List<Stone>>(() => stone.BlinkTimes(blinks))).ToList();
        tasks.ForEach(t => t.Start());
        Task.WaitAll(tasks);
        return tasks.SelectMany(task => task.Result).ToList().Count;
    }
}