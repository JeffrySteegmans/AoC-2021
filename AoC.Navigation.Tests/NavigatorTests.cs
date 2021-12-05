using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AoC.Navigation.Tests
{
    public class NavigatorTests
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
            var navigator = new Navigator();
            var position = navigator.CalculatePosition(instructions);

            position.Depth.Should().Be(10);
            position.HorizontalPosition.Should().Be(15);
        }

        [Fact]
        public void CalculatePositionWithAim_ShouldReturnCorrectPosition()
        {
            var navigator = new Navigator();
            var position = navigator.CalculatePositionWithAim(instructions);

            position.Depth.Should().Be(60);
            position.HorizontalPosition.Should().Be(15);
        }
    }
}