// See https://aka.ms/new-console-template for more information
using AoC.Scanner;

Console.WriteLine("Day 1 - Part 1");

var measurements = new List<int>();

foreach (string line in File.ReadLines($@"{System.Environment.CurrentDirectory}\Input\part1.txt"))
{
    if (int.TryParse(line, out int measurement))
    {
        measurements.Add(measurement);
    }
}

var depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(measurements);

Console.WriteLine($"Increases: {depthMeasurementIncreases}");

Console.WriteLine("Day 1 - Part 2");

var threeMeasurementsSum = await SonarHelper.CalculateThreeMeasurementSums(measurements);
depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(threeMeasurementsSum);

Console.WriteLine($"Increases: {depthMeasurementIncreases}");