using AoC.Navigation;

Console.WriteLine("Day 2 - Part 1");

var instructions = new List<string>();

foreach (string line in File.ReadLines($@"{System.Environment.CurrentDirectory}\Input\part1.txt"))
{
    instructions.Add(line);
}

var position = NavigatorHelper.CalculatePosition(instructions);
var multiplication = position.HorizontalPosition * position.Depth;

Console.WriteLine($"Multiplication: {multiplication}");
