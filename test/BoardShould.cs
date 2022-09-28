using Sudoku.Domain;

namespace Sudoku.Test;

public class BoardShould
{
    
    private Board _board;
    [Fact]
    public void CreateAllEmpty()
    {
        _board = new Board(Enumerable.Range(0,81).Select(x=> 0).ToArray());
        Assert.All(_board.Cells, x => Assert.True(x is EmptyCell));
    }
}
