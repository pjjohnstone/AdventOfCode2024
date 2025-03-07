using System.Diagnostics;
using AdventOfCode2024.CSharp.Day11;

const string input = "28 4 3179 96938 0 6617406 490 816207";
var stones = Day11.ParseLine(input);
const int blinks = 40;
var timer = Stopwatch.StartNew();
var result = Day11.SumStones(stones, blinks);
timer.Stop();

Console.WriteLine($"There are {result} stones after {blinks} blinks");
Console.WriteLine($"Total time: {timer.ElapsedMilliseconds} ms");