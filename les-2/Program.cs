Console.WriteLine("Задача 1:");
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра: {a / 10 % 10}");

Console.WriteLine("Задача 2:");
Console.Write("Введите число: ");
string b = Console.ReadLine();
if (b.Length <= 2)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine($"Третья цифра: {b[2]}");

Console.WriteLine("Задача 3:");
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if ((day == 6) || (day == 7))
    Console.Write("Выходной день");
else
    Console.Write("Рабочий день");