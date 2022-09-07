public class Lab7
{
    private int[][] array;
    public Lab7(int n)
    {
        array = new int[n][];

        FillArray();
        Console.WriteLine("Исходный массив:");
        PrintArray();
        (int indexMin, int indexMax) = FindIndexMinMax();
        Swap(indexMin, indexMax);
        Console.WriteLine($"\nМассив, в котором поменяли {indexMax + 1} столбец и {indexMin + 1} строку:");
        PrintArray();
    }

    private void FillArray()
    {
        Random rnd = new Random();
        var bound = 200;
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = new int[array.Length];
            for (var j = 0; j < array.Length; j++)
            {
                array[i][j] = rnd.Next(-bound, bound);
            }
        }
    }

    private (int, int) FindIndexMinMax()
    {
        int indexMin = 0, indexMax = 0;
        int min = array[indexMin][indexMin], max = min;
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = 0; j < array.Length; j++)
            {
                if (array[i][j] < min)
                {
                    min = array[i][j];
                    indexMin = j;
                }

                if (array[i][j] > max)
                {
                    max = array[i][j];
                    indexMax = i;
                }
            }
        }
        return (indexMin, indexMax);
    }

    private void PrintArray()
    {
        Console.WriteLine(string.Join('\n', array.Select(x => string.Join('\t', x))));
    }

    private void Swap(int row, int col)
    {
        int[] sRow = new int[array.Length];
        array[row].CopyTo(sRow, 0);
        int[] sCol = array.Select(x => x[col]).ToArray<int>();

        for (var i = 0; i < array.Length; i++)
        {
            array[i][col] = sRow[i];
            array[row][i] = sCol[i];
        }
    }
}