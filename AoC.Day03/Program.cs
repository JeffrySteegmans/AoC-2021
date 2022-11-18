using AoC.Common.IO;
using AoC.Diagnostics;

Console.WriteLine("Day 3 - Part 1");

var diagnosticsReport = await InputHelper.ReadTextFile<string>($@"{Environment.CurrentDirectory}\Input\part1.txt").ConfigureAwait(false);
var reportParser = new ReportParser(diagnosticsReport);

var powerUsage = await reportParser.CalculatePowerUsage().ConfigureAwait(false);

Console.WriteLine($"Power usage: {powerUsage}");

Console.WriteLine("Day 3 - Part 2");

var lifeSupportRating = await reportParser.CalculateLifeSupportRating();
Console.WriteLine($"Life support rating: {lifeSupportRating}");