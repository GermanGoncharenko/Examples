int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k)
{
    int[,] coor = new int[4, 2];
    for (int ii = 0; ii < 2; ii++)
    {
        for (int j = 0; j < 2; j++)
        {
            if (ii == j)
            {
                coor[0, j] = a[ii];
                coor[1, j] = (b[ii] - a[ii]) * k + a[ii];
                coor[2, j] = (c[ii] - a[ii]) * k + a[ii];
                coor[3, j] = (d[ii] - a[ii]) * k + a[ii];
            }
        }
    }
    return coor;
}

void PrintCords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write($"({arr[i, j]}, ");
            else System.Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 2;
int[] pointA = { 1, 1 };
int[] pointB = { 2, 3 };
int[] pointC = { 5, 3 };
int[] pointD = { 4, 1 };
char[] pointName = { 'A', 'B', 'C', 'D' };

System.Console.WriteLine();
System.Console.WriteLine("Первый способ");
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCords(newCords, pointName);

// Второй способ

int[] MergeArray(int[] arr1, int[] arr2, int[] arr3, int[] arr4)
{
    int[] u1 = arr1.Concat(arr2).ToArray();
    int[] u2 = u1.Concat(arr3).ToArray();
    int[] unitedArr = u2.Concat(arr4).ToArray();
    return unitedArr;
}

int[] GetScalingCords(int[] arr, int k)
{
    int[] newCords = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2) newCords[i] = arr[i];
        else if (i > 1 && i % 2 == 0) newCords[i] = arr[i] * k - arr[0] * (k - 1);
        else if (i > 1 && i % 2 != 0) newCords[i] = arr[i] * k - arr[1] * (k - 1);
    }
    return newCords;
}

void PrintArray(int[] arr, char[] letters)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) System.Console.Write($"{letters[j]}  ({arr[i]}, ");
        else if (i % 2 != 0)
        {
            System.Console.WriteLine($"{arr[i]})");
            j++;
        }
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Второй способ:");
int[] unitedCords = (MergeArray(pointA, pointB, pointC, pointD));
int[] scallingCords = GetScalingCords(unitedCords, k);
PrintArray(scallingCords, pointName);
