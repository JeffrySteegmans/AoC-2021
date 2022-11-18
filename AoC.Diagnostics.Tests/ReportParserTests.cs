using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AoC.Diagnostics.Tests
{
    public class ReportParserTests
    {
        private readonly List<string> _report = new List<string>
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010",
        };

        [Fact]
        public async Task GivenReport_WhenCalculateGammaRate_ShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var gammaRate = await reportParser.CalculateGammaRate();

            gammaRate.Should().Be(22);
        }

        [Fact]
        public async Task GivenReport_WhenCalculateEpsilonRate_ShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var gammaRate = await reportParser.CalculateEpsilonRate();

            gammaRate.Should().Be(9);
        }

        [Fact]
        public async Task GivenReport_WhenCalculatePowerUsage_ShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var powerUsage = await reportParser.CalculatePowerUsage();

            powerUsage.Should().Be(198);
        }

        [Fact]
        public async Task GivenReport_WhenCalculateOxygenGeneratorRating_ThenShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var oxygenGeneratorRating = await reportParser.CalculateOxygenGeneratorRating();

            oxygenGeneratorRating.Should().Be(23);
        }

        [Fact]
        public async Task GivenReport_WhenCalculateCo2ScrubberRating_ThenShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var co2ScrubberRating = await reportParser.CalculateCo2ScrubberRating();

            co2ScrubberRating.Should().Be(10);
        }

        [Fact]
        public async Task GivenReport_WhenCalculateLifeSupportRating_ThenShouldReturnCorrectResult()
        {
            var reportParser = new ReportParser(_report);
            var lifeSupportRating = await reportParser.CalculateLifeSupportRating();

            lifeSupportRating.Should().Be(230);
        }
    }
}