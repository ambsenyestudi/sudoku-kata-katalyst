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

        public List<SudokuSequence> GetColumns()
        {
            var result = new List<SudokuSequence>();
            for (int x = 0; x < SIZE; x++)
            {
                var column = new List<Cell>();
                for (int y = 0; y < SIZE; y++)
                {
                    var index = y * SIZE + x;
                    column.Add(Cells[index]);
                }
                result.Add(new SudokuSequence(column));
            }
            return result;
        }

       

        public List<SudokuSequence> GetRows()
        {
            var result = new List<SudokuSequence>();
            for (int i = 0; i < SIZE; i++)
            {

                result.Add(new SudokuSequence(SubSequence(i * SIZE, SIZE)));
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

        private IEnumerable<Cell> SubSequence(int offset, int size) =>
            Cells.Skip(offset).Take(size);
    }
}
