int numPlan = 3;            
int min = -5;               
int max = 6;                

int[] GetPointCoords(int numPlan)
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoords(int[] array)
{
    Console.Write($"(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double FindDistance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointA = GetPointCoords(numPlan);
int[] PointB = GetPointCoords(numPlan);

Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

Console.WriteLine($"Расстояние между точками А и В: {FindDistance(PointA, PointB)}");