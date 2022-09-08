using System.Text.RegularExpressions;
public class Lab8
{
    private string[] array;
    public Lab8()
    {
        var rx = new Regex(@"\s+", RegexOptions.Compiled);
        var str = System.IO.File.ReadAllText("./input.txt");
        this.array = rx.Split(str).Select(s => s.ToLower()).ToArray();
        SortArray();
        Console.WriteLine("Введите название файла: ");
        var fileName = Console.ReadLine();
        if (string.IsNullOrEmpty(fileName)) fileName = "output.txt";
        using (StreamWriter w = File.CreateText(fileName))
        {
            w.Write(string.Join(' ', array));
        }
    }

    private void SortArray()
    {
        string temp;
        for (int write = 0; write < array.Length; write++)
        {
            for (int sort = 0; sort < (array.Length - 1); sort++)
            {
                if (CompareStrings(array[sort], array[sort + 1]) > 0)
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
        }
    }
    private int CompareStrings(string str1, string str2)
    {
        var l = str1.Length < str2.Length ? str1.Length : str2.Length;
        for (var i = 0; i < l; i++)
        {
            if (str1[i] < str2[i]) return -1;
            if (str1[i] > str2[i]) return 1;
        }

        return str1.Length > str2.Length ? 1 : 0;
    }
}