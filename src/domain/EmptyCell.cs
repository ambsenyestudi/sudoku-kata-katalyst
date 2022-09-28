namespace Sudoku.Domain
{
    public record EmptyCell : Cell
    {
        public EmptyCell(int row, int column) : base(0, row, column, false)
        {
        }
    }
}
