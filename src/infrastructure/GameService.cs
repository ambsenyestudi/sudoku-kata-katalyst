using Sudoku.Domain;

namespace Sudoku.Infrastructure
{
    public class GameService
    {
        private FileLoader _fileLoader;

        public GameService(FileLoader fileLoader)
        {
            _fileLoader = fileLoader;
        }

        public Board CreateBoard(string inputPath)
        {
            throw new NotImplementedException();
        }
        public bool IsSolution(Board board, string solutionPath)
        {
            throw new NotImplementedException();
        }
    }
}
