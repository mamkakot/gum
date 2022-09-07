public class Lab8
{
    private string[][] array;
    public Lab8()
    {
        this.array = System.IO.File.ReadAllLines("./input.txt").Select(s => s.ToLower().Split(' ')).ToArray();
        SortArray();
        Console.WriteLine(string.Join('\n', array.Select(s => string.Join(' ', s))));
    }

    // TODO: запилить нормальную сортировку
    private void SortArray()
    {
        int[][] byteCodes = new int[array.Length][];
        string temp;

        foreach (var strArr in array)
        {
            for (int write = 0; write < strArr.Length; write++)
            {
                for (int sort = 0; sort < strArr[write].Length - 1; sort++)
                {
                    if ((int)strArr[sort][0] > (int)strArr[sort + 1][0])
                    {
                        temp = strArr[sort + 1];
                        strArr[sort + 1] = strArr[sort];
                        strArr[sort] = temp;
                    }
                }
            }
        }


    }
    private void Swap(int index1, int index2)
    {

    }
}