int count = 1;
while(count < new Random().Next(1,100))
{
    if (count % 2 == 0)
    Console.Write(count);
    Console.Write(" ");
    count++;
}