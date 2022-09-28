using Sudoku.Domain;

namespace Sudoku.Test;

public class RegionsExtractorServiceShould
{
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(0, 8, 20)]
    [InlineData(1, 0, 3)]
    [InlineData(1, 8, 23)]
    [InlineData(2, 0, 6)]
    [InlineData(2, 8, 26)]
    [InlineData(3, 0, 27)]
    [InlineData(3, 8, 47)]
    [InlineData(4, 0, 30)]
    [InlineData(4, 8, 50)]
    [InlineData(5, 0, 33)]
    [InlineData(5, 8, 53)]
    [InlineData(6, 0, 54)]
    [InlineData(6, 8, 74)]
    [InlineData(7, 0, 57)]
    [InlineData(7, 8, 77)]
    [InlineData(8, 0, 60)]
    [InlineData(8, 8, 80)]
    public void IsRegion(int regionIndex, int cellNumber, int expected)
    {
        var regionExtractor = new RegionExtractorService();
        var (x, y) = regionExtractor.GetIndex(regionIndex, cellNumber);
        var index = y * 9 + x;
        Assert.Equal(expected, index);
    }
}
