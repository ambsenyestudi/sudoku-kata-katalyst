using Sudoku.Domain;
using Sudoku.Infrastructure;

namespace Sudoku.Test;

public class GameFeature
{
    private readonly GameService _gameService = new GameService(new FileLoader(), new SolutionValidationService());
    
    [Fact]
    public void SpotIncorrectSolutions()
    {
        var board = _gameService.CreateBoard("start_board.csv");
        Assert.False(_gameService.IsSolution(board, "start_board.csv"));        
    }

    [Fact]
    public void SpotCorrectSolutions()
    {
        var board = _gameService.CreateBoard("start_board.csv");
        Assert.True(_gameService.IsSolution(board, "solution.csv"));
    }
}