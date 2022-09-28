using Sudoku.Domain;

namespace Sudoku.Test;

public class BoardShould
{
    private int[] sample = new int[]
    {
        5,3,4,6,7,8,9,1,2,
        6,7,2,1,9,5,3,4,8,
        1,9,8,3,4,2,5,6,7,
        8,5,9,7,6,1,4,2,3,
        4,2,6,8,5,3,7,9,1,
        7,1,3,9,2,4,8,5,6,
        9,6,1,5,3,7,2,8,4,
        2,8,7,4,1,9,6,3,5,
        3,4,5,2,8,6,1,7,9,
    };

    private Board _board;
    
    [Fact]
    public void CreateAllEmpty()
    {
        _board = new Board(Enumerable.Range(0,81).Select(x=> 0).ToArray());
        Assert.All(_board.Cells, x => Assert.True(x is EmptyCell));
    }

    [Theory]
    [InlineData(0, "5,3,4,6,7,8,9,1,2")]
    [InlineData(1, "6,7,2,1,9,5,3,4,8")]
    [InlineData(7, "2,8,7,4,1,9,6,3,5")]
    [InlineData(8, "3,4,5,2,8,6,1,7,9")]
    public void GetExptectedRow(int index, string expectedRaw)
    {
        var expected = expectedRaw.Split(",").Select(x => int.Parse(x)).ToArray();
        var board = new Board(sample);
        var rows = board.GetRows();
        Assert.True(rows[index].Equals(expected));
    }
    [Theory]
    [InlineData(0, "5,6,1,8,4,7,9,2,3")]
    [InlineData(1, "3,7,9,5,2,1,6,8,4")]
    [InlineData(2, "4,2,8,9,6,3,1,7,5")]
    [InlineData(8, "2,8,7,3,1,6,4,5,9")]
    public void GetExptectedColumns(int index, string expectedRaw)
    {
        var expected = expectedRaw.Split(",").Select(x => int.Parse(x)).ToArray();
        var board = new Board(sample);
        var rows = board.GetColumns();
        Assert.True(rows[index].Equals(expected));
    }
}
