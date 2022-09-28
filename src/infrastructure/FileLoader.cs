namespace Sudoku.Infrastructure;
public class FileLoader
{
    private const string SEPARATOR = ",";
    private const string LINE_BREAK = "\r\n";
    private const int EMPTY_VALUE = 0;

    public int[] LoadBoard(string txt)
    {
        var result = string.Empty;
        using (var sr = new StreamReader(txt))
        {
            result = sr.ReadToEnd().Replace(LINE_BREAK, SEPARATOR);
        }
        return ToDigits(result.Split(SEPARATOR));
    }

    private int[] ToDigits(string[] input) =>
        input.Select(x => ToDigit(x))
        .ToArray();

    private int ToDigit(string input) =>
        string.IsNullOrWhiteSpace(input)
            ? EMPTY_VALUE
            : int.Parse(input);
}
