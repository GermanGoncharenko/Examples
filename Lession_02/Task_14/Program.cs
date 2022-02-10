int Number = new Random().Next(1, 1000);
Console.WriteLine($"Дано число: {Number}");

if (Number > 100) 
    Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
else 
    Console.WriteLine($"У числа {Number} нет третьей цифры");
