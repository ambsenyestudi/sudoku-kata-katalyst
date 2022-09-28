namespace Sudoku.Domain
{
    public class SudokuSequence
    {
        private IEnumerable<Cell> _cells;
        

        public SudokuSequence(IEnumerable<Cell> cells)
        {
            _cells = cells;
        }

        public bool IsValidSequence() =>
            !AnyEmpty() && InRange();

        public override bool Equals(object? obj)
        {
            if(obj is SudokuSequence other)
            {
                return _cells.SequenceEqual(other._cells);
            }
            if(obj is int[] values)
            {
                return _cells.Select(x => x.Value).SequenceEqual(values);
            }
            return false;
        }

        private bool InRange() =>
            InRange(GetValues(_cells), 1, 9);

        private bool InRange(int[] values, int min, int max) =>
            values.Distinct().Count() == max &&
            values.Min() == min && values.Max() == max;

        private bool AnyEmpty() =>
            _cells.Any(x => x is EmptyCell);
        private static int[] GetValues(IEnumerable<Cell> cells)=>
            cells.Select(x=>x.Value).ToArray();
    }
}
