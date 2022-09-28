namespace Sudoku.Infrastructure;
public class FileLoader
{
    public string Load(string txt)
    {
        var result = string.Empty;
        using (var sr = new StreamReader(txt))
        {
            result = sr.ReadToEnd();
        }
        return result;
    }
}
