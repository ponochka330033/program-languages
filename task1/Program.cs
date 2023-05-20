// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int DayWeek = int.Parse(Console.ReadLine()!);

if (DayWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (DayWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (DayWeek == 3)
{
    Console.WriteLine("Среда");
}
else if (DayWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (DayWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (DayWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (DayWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}