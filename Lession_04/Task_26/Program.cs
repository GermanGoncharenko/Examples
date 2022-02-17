int number = new Random().Next(1, 10);
int exponent = new Random().Next(1, 10);

int GetExponentiation(int number, int exponent)
{
    int count = 1;
    int result = number;
    while (count < exponent)
    {
        result = result * number;
        count++;
    }
    return result;
}

int result = GetExponentiation(number, exponent);
Console.WriteLine($"{number} ^ {exponent} = {result}");