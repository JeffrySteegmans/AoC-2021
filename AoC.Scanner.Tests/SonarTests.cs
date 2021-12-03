using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AoC.Scanner.Tests
{
    public class SonarTests
    {
        private readonly List<int> measurements = new List<int>
        {
            199,
            200,
            208,
            210,
            200,
            207,
            240,
            269,
            260,
            263
        };

        [Fact]
        public async Task DepthMeasurementIncreases_ShouldReturnCorrectNumberOfIncreases()
        {
            var depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(measurements);

            depthMeasurementIncreases.Should().Be(7);
        }

        [Fact]
        public async Task DepthMeasurementIncreases_GivenListOfThreeMeasurementsSum_ShouldReturnCorrectNumberOfIncreases()
        {
            var threeMeasurementsSum = await SonarHelper.CalculateThreeMeasurementSums(measurements);
            var depthMeasurementIncreases = await SonarHelper.DepthMeasurementIncreases(threeMeasurementsSum);

            depthMeasurementIncreases.Should().Be(5);
        }
    }
}