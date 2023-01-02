using AoC.Bingo.Models;

namespace AoC.Bingo
{
    public class BingoSubSystem
    {
        private readonly List<int> _drawnNumbers;
        private readonly List<Board> _boards;

        public BingoSubSystem(List<string> input)
        {
            (_drawnNumbers, _boards) = ParseInput(input);
        }

        public int CalculateScoreOfWinningBoard()
        {
            foreach (var board in _boards)
            {
                var boardMarkings = new bool[board.GetLength(0), board.GetLength(1)];
                _markings.Add(boardMarkings);
            }

            foreach (var drawnNumber in _drawnNumbers)
            {
                foreach (var board in _boards)
                {
                    var numberPosition = GetNumberPosition(board, drawnNumber);
                    if (numberPosition != default)
                    {

                    }
                }
            }
            //TODO: loop over drawn numbers and mark the boards

            return 0;
        }

        private (int, int) GetNumberPosition(int[,] board, int number)
        {
            (int, int) position = default;

            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == number)
                    {
                        position = (i, j);
                    }
                }
            }

            return position;
        }

        private (List<int>, List<int[,]>) ParseInput(List<string> input)
        {
            var drawnNumbers = input
                .First()
                .Split(',')
                .Select(x => int.Parse(x))
                .ToList();

            var blocks = input.Split("\n\n");

            var boards = new List<int[,]>();

            int[,] board = null!;
            int lineNumber = 0;
            foreach (var line in input.Skip(1))
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (board != null)
                    {
                        boards.Add(board);
                        lineNumber = 0;
                    }

                    board = new int[5, 5];
                    continue;
                }

                var stringNumbers = line.Trim().Replace("  ", " ").Split(' ');
                var numbers = stringNumbers.Select(x => int.Parse(x)).ToList();

                for (var col = 0; col < numbers.Count; col++)
                {
                    board[lineNumber, col] = numbers[col];
                }
                lineNumber++;
            }
            boards.Add(board);

            return (drawnNumbers, boards);
        }
    }
}
