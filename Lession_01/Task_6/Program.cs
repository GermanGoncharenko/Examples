int numberA = new Random().Next(1,100);

if (numberA % 2 == 0)
{
    Console.Write(numberA);
    Console.WriteLine(" четное");
 }
else
{
    Console.Write(numberA);
    Console.WriteLine(" нечетное");
}