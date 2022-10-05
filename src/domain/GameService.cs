using Sudoku.Domain;

namespace Sudoku.Infrastructure
{
    public class GameService
    {
        public Board CreateBoard(int[] boardLayout)
        {
            return new Board(boardLayout);
        }
        public bool IsSolution(Board board, int[] solutionLayout)
        {
            if(solutionLayout.Any(x=> x== 0))
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
