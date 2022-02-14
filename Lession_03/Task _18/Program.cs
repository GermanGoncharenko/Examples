int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int x = a;
int y = b;

bool XY = x != a || y == b;
bool notXY = XY != true;
bool notXnotY = x != a | y != b;

Console.WriteLine(notXnotY);
Console.WriteLine(notXY);

if (notXY == notXnotY) Console.WriteLine("Утвеждение истинно");
else Console.WriteLine("Утверждение ложно");