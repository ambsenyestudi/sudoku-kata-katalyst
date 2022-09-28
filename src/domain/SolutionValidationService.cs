namespace Sudoku.Domain
{
    public class SolutionValidationService
    {
        public bool IsValid(Board board) =>
            ValidRows(board) && ValidColumns(board);

        private bool ValidColumns(Board board) =>
            AllValid(board.GetColumns());

        private bool ValidRows(Board board) =>
            AllValid(board.GetRows());

        private bool AllValid(List<SudokuSequence> sudokuSequences) =>
            sudokuSequences.All(x => x.IsValidSequence());
    }
}