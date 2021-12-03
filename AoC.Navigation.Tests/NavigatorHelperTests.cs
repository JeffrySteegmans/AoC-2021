using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AoC.Navigation.Tests
{
    public class NavigatorHelperTests
    {
        private readonly List<string> instructions = new List<string>
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        [Fact]
        public void CalculatePosition_ShouldReturnCorrectPosition()
        {
            var position = NavigatorHelper.CalculatePosition(instructions);

            position.Depth.Should().Be(10);
            position.HorizontalPosition.Should().Be(15);
        }
    }
}