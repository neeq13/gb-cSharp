class HomeWork2
{

    public void doubleMass()
    {
        Console.Write("Введите длинну массива по длинне: ");
        int arrX = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длинну массива по высоте: ");
        int arrY = Convert.ToInt32(Console.ReadLine());
        int[,] list = new int[arrY, arrX];
        Console.WriteLine();
        Console.WriteLine("-- Заданный массив --");
        for (int i = 0; i < arrY; i++)
        {
            Console.Write("[");
            for(int j = 0; j < arrX; j++)
            {
                list[i, j] = new Random().Next(0, 10);
                Console.Write("{0, 3}", list[i, j]);
            }
            Console.WriteLine("]");
        }
        print(list);
    }

    private void print(int[, ] arr)
    {
        int count = 0;
        int min = 0;
        int num = 0;
        Console.WriteLine();
        Console.WriteLine("-- Обработанный массив --");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write($"Строка №{i + 1} [");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, 3}", arr[i, j]);
                count += arr[i, j];
            }
            Console.WriteLine($"] = {count}");
            if(count < min){
                min = count;
                num = i;
                count = 0;
            }
        }
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {num + 1} строка");
    }
}