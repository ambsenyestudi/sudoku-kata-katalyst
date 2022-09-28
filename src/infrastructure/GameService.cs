using Sudoku.Domain;

namespace Sudoku.Infrastructure
{
    public class GameService
    {
        private FileLoader _fileLoader;

        public GameService(FileLoader fileLoader)
        {
            _fileLoader = fileLoader;
        }

        public Board CreateBoard(string inputPath) =>
            new Board(_fileLoader.LoadBoard(inputPath));
        

        public bool IsSolution(Board board, string solutionPath)
        {
            var solution = _fileLoader.LoadBoard(solutionPath);
            if (HasEmptyCells(solution))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        private static bool HasEmptyCells(int[] solution) =>
            solution.Any(x => EmptyCell.IsEmptyValue(0));
    }
}
