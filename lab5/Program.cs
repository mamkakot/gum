// подзадача 1
int ConvertToBase10(int n, int init_base)
{
    int mod = 0, // остаток от деления
        count = 0, // счётчик разрядов
        result = 0; // результат вычисления функции

    while (n > 0)
    {
        mod = n % 10;
        int s = Convert.ToInt32(Math.Pow(init_base, count));
        result += mod * s;
        count++;
        n /= 10; // переход к высшему разряду
    }
    return result;
}

Console.WriteLine("Введите последовательно через пробел два числа: число, которое будет преобразовано в десятичную систему, и основание системы счисления введённого числа:");
string[] str = Console.ReadLine().Split(' ');
int n = Convert.ToInt32(str[0]), b = Convert.ToInt32(str[1]);
Console.WriteLine($"Число {n} с основанием системы счисления {b} в десятичной системе счисления: {ConvertToBase10(n, b)}");

// подзадача 2
for (int i = 10; i < 100; i++) // цикл по всем двузначным числам
{
    for (int j = 10; j < 100; j++)
    {
        int s = (i * 100 + j) % (i * j); // остаток от деления четырёхзначного числа на произведение
        if (s == 0)
        {
            Console.WriteLine(String.Format("Первое двузначное число: {0}, второе двузначное число: {1}", i, j));
        }
    }
}