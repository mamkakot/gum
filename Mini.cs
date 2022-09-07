public class Mini
{
    // среднеарифметическое
    public double Avg(int a, int b)
    {
        return (double)(a + b) / 2;
    }

    // сумма 3 цифр
    public int SumOfThree(int n)
    {
        return n % 10 + (n / 10) % 10 + n / 100;
    }
    // наименьшее число из 3
    public int MinOfThree(int n)
    {
        return n % 10 < (n / 10) % 10 ? n % 10 :
               (n / 10) % 10 < n / 100 ? (n / 10) % 10 :
               n / 100;
    }
}
