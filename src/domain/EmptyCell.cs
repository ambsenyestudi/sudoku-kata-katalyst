namespace Sudoku.Domain
{
    public record EmptyCell : Cell
    {
        private const int EMPTY_VALUE = 0;
        public EmptyCell(int row, int column) : base(EMPTY_VALUE, row, column, false)
        {
        }

        public static bool IsEmptyValue(int value) =>
            value == EMPTY_VALUE;
    }
}
