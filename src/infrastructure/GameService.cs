using Sudoku.Domain;

namespace Sudoku.Infrastructure
{
    public class GameService
    {
        private readonly FileLoader _fileLoader;
        private readonly SequenceValidationService _sequenceValidation;
        public GameService(FileLoader fileLoader, SequenceValidationService sequenceValidation)
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
            var solutionBoard = new Board(solution);
            if(solutionBoard.GetRows().Any(x=> !_sequenceValidation.IsSequenceValid(x)))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        private static bool HasEmptyCells(int[] solution) =>
            solution.Any(x => EmptyCell.IsEmptyValue(x));
    }
}
