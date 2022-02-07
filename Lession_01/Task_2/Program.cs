int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
if (numberA > numberB)
{
    Console.WriteLine("max");
    Console.WriteLine(numberA);
    Console.WriteLine("min");
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine("max");
    Console.WriteLine(numberB);
    Console.WriteLine("min");
    Console.WriteLine(numberA);
}