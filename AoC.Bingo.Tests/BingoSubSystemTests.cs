namespace AoC.Bingo.Tests;

public class BingoSubSystemTests
{
    private readonly string[] _input;

    public BingoSubSystemTests()
    {
        _input = File.ReadAllLines($@"{Environment.CurrentDirectory}\Input\Day04.txt");
    }

    [Fact]
    public void GivenBoard_WhenCalculateScoreOfWinningBoard_ShouldReturnCorrectScore()
    {
        var bingoSubSystem = new BingoSubSystem(_input.ToList());
        var gammaRate = bingoSubSystem.CalculateScoreOfWinningBoard();

        gammaRate.Should().Be(4512);
    }
}
