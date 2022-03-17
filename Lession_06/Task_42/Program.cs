int volume = 5;   
int count = 0;

while (volume > 0)
{
    Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

Console.WriteLine($"Количество чисел больше 0: {count}");
