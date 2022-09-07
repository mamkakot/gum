public class Lab8
{
    private string[][] array;
    public Lab8()
    {
        this.array = System.IO.File.ReadAllLines("./input.txt").Select(s => s.ToLower().Split(' ')).ToArray();
    }

    private void SortArray()
    {
        int[][] byteCodes = new int[array.Length][];
        string temp;

        for (var i = 0; i < array.Length; i++)
        {
            for (int write = 0; write < array[i].Length; write++)
            {
                for (int sort = 0; sort < array[write].Length - 1; sort++)
                {
                    if ((int)array[write][sort][0] > (int)array[write][sort + 1][0])
                    {
                        temp = array[write][sort + 1];
                        array[write][sort + 1] = array[write][sort];
                        array[write][sort] = temp;
                    }
                }
            }
        }
    }
    private void Swap(int index1, int index2)
    {

    }
}