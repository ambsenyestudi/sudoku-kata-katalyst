using FluentAssertions;
using Sudoku.Infrastructure;

namespace Sudoku.Test;

public class GameFeature
{
    private readonly GameService _gameService = new GameService();
    private readonly FileLoader _fileLoader = new FileLoader();

    [Fact]
    public void DismisIncorrectSolution()
    {
        var board = _gameService.CreateBoard(LoadFile("start_board.csv"));
        var solutionLayout = LoadFile("start_board.csv");

        _gameService.IsSolution(board, solutionLayout).Should().Be(false);        
    }

    [Fact]
    public void AcceptSolutions()
    {
        var board = _gameService.CreateBoard(LoadFile("start_board.csv"));
        Assert.True(_gameService.IsSolution(board, LoadFile("solution.csv")));
    }

    private int[] LoadFile(string fileName) =>
        _fileLoader.LoadBoard(fileName);
}