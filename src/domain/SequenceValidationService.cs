using System.Collections.Generic;

namespace Sudoku.Domain
{
    public class SequenceValidationService
    {
        public bool IsSequenceValid(IEnumerable<Cell> cells)
        {
            var cellValues = cells.Select(x => x.Value).ToList();
            return cellValues.Distinct().Count() == 9 && 
                cellValues.Min() == 1 && cellValues.Max() == 9;
        }

    }
}