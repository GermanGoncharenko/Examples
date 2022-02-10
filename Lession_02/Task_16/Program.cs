int day = new Random().Next(1, 8);
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string txtresult = "";

if (day > 5) txtresult = $"Выходной";
else txtresult = $"Рабочий день";

Console.WriteLine($"{day}-й день недели - {days[day - 1]}. {txtresult}");