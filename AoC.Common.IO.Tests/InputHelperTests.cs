using FluentAssertions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AoC.Common.IO.Tests
{
    public class InputHelperTests
    {
        [Fact]
        public async Task GivenInputFilesWithStrings_WhentRequestTypeIsString_ShouldReturnListOfStrings()
        {
            var path = $@"{System.Environment.CurrentDirectory}\InputFiles\StringInput.txt";

            var input = await InputHelper.ReadTextFile<string>(path).ConfigureAwait(false);

            input.Should().BeOfType<List<string>>();
            input.Count.Should().Be(3);
        }

        [Fact]
        public async Task GivenInputFilesWithStrings_WhentRequestTypeIsInt_ShouldReturnEmptyList()
        {
            var path = $@"{System.Environment.CurrentDirectory}\InputFiles\StringInput.txt";

            var input = await InputHelper.ReadTextFile<int>(path).ConfigureAwait(false);

            input.Should().BeEmpty();
        }

        [Fact]
        public async Task GivenInputFilesWithInts_WhentRequestTypeIsInt_ShouldReturnListOfInts()
        {
            var path = $@"{System.Environment.CurrentDirectory}\InputFiles\IntInput.txt";

            var input = await InputHelper.ReadTextFile<int>(path).ConfigureAwait(false);

            input.Should().BeOfType<List<int>>();
            input.Count.Should().Be(3);
        }



        [Fact]
        public async Task GivenInputFilesWithInts_WhentRequestTypeIsString_ShouldReturnListOfStrings()
        {
            var path = $@"{System.Environment.CurrentDirectory}\InputFiles\IntInput.txt";

            var input = await InputHelper.ReadTextFile<string>(path).ConfigureAwait(false);

            input.Should().BeOfType<List<string>>();
            input.Count.Should().Be(3);
        }
    }
}