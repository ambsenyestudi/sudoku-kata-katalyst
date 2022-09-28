using Sudoku.Domain;

namespace Sudoku.Infrastructure
{
    public class GameService
    {
        private readonly FileLoader _fileLoader;
        private readonly SolutionValidationService _sequenceValidation;
        public GameService(FileLoader fileLoader, SolutionValidationService sequenceValidation)
        {
            _fileLoader = fileLoader;
            _sequenceValidation = sequenceValidation;
        }

        public Board CreateBoard(string inputPath) =>
            new Board(_fileLoader.LoadBoard(inputPath));
        

        public bool IsSolution(Board board, string solutionPath)
        {
            var solution = _fileLoader.LoadBoard(solutionPath);
            if(HasEmptyCells(solution))
            {
                return false;
            }
            return _sequenceValidation.IsValid(new Board(solution));
        }

        private static bool HasEmptyCells(int[] solution) =>
            solution.Any(x => EmptyCell.IsEmptyValue(x));
    }
}
