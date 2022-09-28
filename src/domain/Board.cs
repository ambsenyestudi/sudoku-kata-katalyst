namespace Sudoku.Domain
{
    public class Board
    {
        private const int SIZE = 9;
        private const int EMPTY_VALUE = 0;
        public List<Cell> Cells { get; }

        public Board(int[] input)
        {
            Cells = ToCells(input);
        }

        private List<Cell> ToCells(int[] input)
        {
            var result = new List<Cell>();
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                result.Add(ToCell(input, i));
            }
            return result;
        }

        private Cell ToCell(int[] input, int index) =>
            ToCell(input[index], 
                Cell.FigureRow(index, SIZE), Cell.FigureColum(index, SIZE));

        private Cell ToCell(int value, int row, int column) =>
            value == EMPTY_VALUE
            ? new EmptyCell(row, column)
            : new Cell(value, row, column);

    }
}
