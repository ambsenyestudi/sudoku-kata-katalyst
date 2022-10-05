namespace Sudoku.Domain
{
    public record Cell
    {
        public int Row { get; }
        public int Column { get; }
        public int Value { get; }
        public bool HasValue { get; set; }

        public Cell(int value, int row, int column) => (Value, Row, Column, HasValue) = (value, row, column, true);
        protected Cell(int value, int row, int column, bool isSolve) => (Value, Row, Column, HasValue) = (value, row, column, isSolve);
    }
}
