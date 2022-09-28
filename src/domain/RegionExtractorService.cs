namespace Sudoku.Domain
{
    public class RegionExtractorService
    {
        private const int REGION_SIZE = 3;

        public (int, int) GetIndex(int regionIndex, int cellNumber) =>
            (cellNumber % REGION_SIZE + (regionIndex % REGION_SIZE) * REGION_SIZE, (regionIndex / REGION_SIZE) * REGION_SIZE + cellNumber / REGION_SIZE);
    }
}
