//Решение без функции

//Console.Write("Дано 3-х значное число: ");
//int result = new Random().Next(100, 1000);
//Console.WriteLine(result);
//int numberA = (result / 10) % 10;
//Console.Write("2-цифра = ");
//Console.WriteLine(numberA);

using System;
class Program
{
    static void Main(string[] args)
    {
        var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
        while (n >= 100)
        {
            n /= 10;
        }
        var r = n % 10;
        Console.WriteLine(r);
    }
}