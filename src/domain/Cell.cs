namespace Sudoku.Domain
{
    public record Cell
    {
        
        public int Value { get; protected set; }
        public int Row { get; }
        public int Column { get; }
        public bool IsSolved { get; }

        public Cell(int value, int row, int column) => (Value, Row, Column, IsSolved) = (value, row, column, true);
        protected Cell(int value, int row, int column, bool isSolve) => (Value, Row, Column, IsSolved) = (value, row, column, isSolve);

        public static int FigureRow(int order, int boardSize) =>
            order / boardSize;

        public static int FigureColum(int order, int boardSize) =>
            order % boardSize;
    }
}
