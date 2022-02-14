int quarter = new Random().Next(1, 5);
string range = "";

if (quarter == 1) range = "x > 0, y > 0";
else if (quarter == 2) range = "x < 0, y > 0";
else if (quarter == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

Console.WriteLine($"Для {quarter}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");