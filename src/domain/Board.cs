namespace Sudoku.Domain
{
    public class Board
    {
        public const int SIZE = 9;
        public List<(int, int, int)> Cells { get; }

        public Board(int[] boardLayout)
        {
            Cells = ToCellList(boardLayout);
        }

        private List<(int, int, int)> ToCellList(int[] boardLayout)
        {
            var result = new List<(int, int, int)> ();
            return result;
        }
    }
}
