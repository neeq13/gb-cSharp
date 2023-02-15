// Console.WriteLine("Задача 1:");
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
//     Console.Write($"Max: {a}");
// else
//     Console.Write($"Max: {b}");

// Console.WriteLine("Задача 2:");
// Console.Write("Введите первое число: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num_3 = Convert.ToInt32(Console.ReadLine());
// if (num_1 > num_2 && num_1 > num_3)
//     Console.Write($"Max: {num_1}");
// else if (num_2 > num_1 && num_2 > num_3)
//     Console.Write($"Max: {num_2}");
// else
//     Console.Write($"Max: {num_3}");

// Console.WriteLine("Задача 3:");
// Console.Write("Введите число: ");
// int even = Convert.ToInt32(Console.ReadLine());

// if (even % 2 == 0)
//     Console.Write("Yes");
// else
//     Console.Write("No");

Console.WriteLine("Задача 4:");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");