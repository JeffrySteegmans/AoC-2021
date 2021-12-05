// See https://aka.ms/new-console-template for more information
using AoC.Common.IO;
using AoC.Scanner;

Console.WriteLine("Day 1 - Part 1");

var measurements = await InputHelper.ReadTextFile<int>($@"{Environment.CurrentDirectory}\Input\part1.txt");
var depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(measurements);

Console.WriteLine($"Increases: {depthMeasurementIncreases}");

Console.WriteLine("Day 1 - Part 2");

var threeMeasurementsSum = await SonarHelper.CalculateThreeMeasurementSums(measurements);
depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(threeMeasurementsSum);

Console.WriteLine($"Increases: {depthMeasurementIncreases}");