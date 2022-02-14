Console.Write("Введите число:   ");
string num = Console.ReadLine();
int n = Convert.ToInt32(num);

int[] GetCubeTable(int n)
{
    int[] cubs = new int[n + 1];
    for (int i = 1; i < cubs.Length; i++)
    {
        cubs[i] = i * i * i;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{i} ^ 3 = ");
        Console.WriteLine(array[i]);
    }
}

int[] CubeTable = GetCubeTable(n);
PrintCubs(CubeTable);