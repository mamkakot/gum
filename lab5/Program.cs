// подзадача 2
for (int i = 10; i < 100; i++)
{
    for (int j = 10; j < 100; j++)
    {
        int s = (i * 100 + j) % (i * j);
        if (s == 0) 
        {
            Console.WriteLine(String.Format("Num1: {0}, num2:{1}", i, j));
        }
    }
}