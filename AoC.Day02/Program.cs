using AoC.Common.IO;
using AoC.Navigation;

var navigator = new Navigator();
var instructions = await InputHelper.ReadTextFile<string>($@"{Environment.CurrentDirectory}\Input\part1.txt").ConfigureAwait(false);

Console.WriteLine("Day 2 - Part 1");

var position = navigator.CalculatePosition(instructions);
var multiplication = position.HorizontalPosition * position.Depth;

Console.WriteLine($"Multiplication: {multiplication}");

Console.WriteLine("Day 2 - Part 2");

position = navigator.CalculatePositionWithAim(instructions);
multiplication = position.HorizontalPosition * position.Depth;

Console.WriteLine($"Multiplication: {multiplication}");