namespace Sudoku.Domain
{
    public class Board
    {
        public const int SIZE = 9;
        public List<Cell> Cells { get; }

        public Board(int[] boardLayout)
        {
            Cells = ToCellList(boardLayout);
        }

        private List<Cell> ToCellList(int[] boardLayout)
        {
            var result = new List<Cell> ();
            for (int i = 0; i < boardLayout.Length; i++)
            {
                result.Add(new Cell(i % SIZE, i / SIZE, boardLayout[i]));
            }
            return result;
        }
    }
}
