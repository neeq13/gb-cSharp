Console.WriteLine("Задача 1:");
Console.Write("Введите длинну массива: ");
int arr = Convert.ToInt32(Console.ReadLine());

void NegativeNumbers(int mass)
{
    int[] list = new int[mass];
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(-10, 10);
        if (list[i] > 0) 
        {
            count++;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", list));
    Console.WriteLine($"Количество чисел в массиве больше 'нуля' = {count}");
}

NegativeNumbers(arr);