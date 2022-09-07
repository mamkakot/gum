var menuText = @"  1) Мини-задачки с первого практического занятия
  2) ЛР5
  3) ЛР7
  4) ЛР8";
Console.WriteLine($"Введите номер пункта меню:\n{menuText}");
int.TryParse(Console.ReadLine(), out int p);
switch (p)
{
    case 1:
        var m = new Mini();

        Console.Write("Введите последовательно через пробел два числа: ");
        string[] str2 = Console.ReadLine()!.Split(' ');
        int v = int.Parse(str2[0]), z = int.Parse(str2[1]);
        Console.WriteLine($"Среднее чисел {v} и {z}: {m.Avg(v, z)}");

        Console.Write("Введите трёхзначное число: ");
        string str = Console.ReadLine()!;
        int n = int.Parse(str);
        Console.WriteLine($"Сумма цифр числа {n}: {m.SumOfThree(n)}");

        Console.Write("Введите трёхзначное число: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Меньшее из цифр числа {n2}: {m.MinOfThree(n2)}");
        break;
    case 2:
        var lab5 = new Lab5();
        lab5.Task1();
        lab5.Task2();
        break;
    case 3:
        Console.Write("Введите размерность массива: ");
        int arraySize;
        if (!int.TryParse(Console.ReadLine(), out arraySize))
        {
            Console.WriteLine($"Ошибка в вводе данных!");
            break;
        }
        var lab7 = new Lab7(arraySize);
        break;
    case 4:
        var lab8 = new Lab8();
        break;
    default:
        Console.WriteLine("Такого пункта нету.");
        break;
}