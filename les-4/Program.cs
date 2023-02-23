Console.WriteLine("Задача 1:");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степеь: ");
int degree = Convert.ToInt32(Console.ReadLine());

int Degree(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++){
        result = result * number;
    }
    return result;
}

Console.WriteLine($"Возведение числа {number} в степень {degree} = {Degree(number, degree)}");

Console.WriteLine("Задача 2:");
Console.Write("Введите число: ");
string numbers = Console.ReadLine();

int Summator(string number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        result += int.Parse(number[i].ToString());
    }
    return result;
}

Console.WriteLine($"Сумма всех чисел в числе {numbers} = {Summator(numbers)}");

Console.WriteLine("Задача 3:");
Console.Write("Введите длинну массива: ");
int mass = Convert.ToInt32(Console.ReadLine());

void Mass(int mass)
{
    int[] list = new int[mass];
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(1, 20);
    }
    Console.WriteLine("[{0}]", string.Join(", ", list));
}

Mass(mass);