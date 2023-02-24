Console.WriteLine("Задача 1:");
Console.Write("Введите длинну массива: ");
int mass = Convert.ToInt32(Console.ReadLine());

void Mass(int mass)
{
    int[] list = new int[mass];
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(100, 999);
        if (list[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", list));
    Console.WriteLine($"Количество чётных цифр в массиве = {count}");
}

Mass(mass);

Console.WriteLine("Задача 2:");
Console.Write("Введите длинну массива: ");
int massiv = Convert.ToInt32(Console.ReadLine());

void Odd(int mass)
{
    int[] list = new int[mass];
    int result = 0;
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(0, 99);
        if (i % 2 != 0 & i != 0)
            result += list[i];
    }
    Console.WriteLine("[{0}]", string.Join(", ", list));
    Console.WriteLine($"Сумма нечётных элементов массива = {result}");
}

Odd(massiv);

Console.WriteLine("Задача 3:");
Console.Write("Введите длинну массива: ");
int arr = Convert.ToInt32(Console.ReadLine());

void Difference(int mass)
{
    int[] list = new int[mass];
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(0, 99);
    }
    Console.WriteLine("[{0}]", string.Join(", ", list));
    Console.WriteLine($"Разница между минимальным и максимальным элементами массива = {list.Max() - list.Min()}");
}

Difference(arr);