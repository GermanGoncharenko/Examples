int number = new Random().Next(100, 1000);
int result = 0;

int NumberWithoutSecDig()
{
    result = number / 100 * 10 + number % 10;
    return result;
}

NumberWithoutSecDig();

Console.WriteLine($"Число: {number}");
Console.WriteLine($"После удаления второй цифры: {result}");