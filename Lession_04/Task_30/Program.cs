int N = new Random().Next(1, 30);
Console.WriteLine($"N = {N}");

int number = 1;
Console.WriteLine("By While");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.Write(cube + " ");
    number++;
}
Console.WriteLine();