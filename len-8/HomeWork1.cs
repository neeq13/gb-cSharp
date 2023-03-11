class HomeWork1
{
    public int[,] doubleMass()
    {
        Console.Write("Введите длинну массива по длинне: ");
        int arrX = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длинну массива по высоте: ");
        int arrY = Convert.ToInt32(Console.ReadLine());
        int[,] list = new int[arrY, arrX];
        Console.WriteLine();
        Console.WriteLine("-- Не сортированный массив --");
        for (int i = 0; i < arrY; i++)
        {
            Console.Write("[");
            for(int j = 0; j < arrX; j++)
            {
                list[i, j] = new Random().Next(-10, 10);
                Console.Write("{0, 3}", list[i, j]);
            }
            Console.WriteLine("]");
        }
        return list;
    }

    public void sort(int[, ] arr)
    {
        int[] row = new int[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                row[j] = arr[i, j];
            }
            Array.Sort(row);
            Array.Reverse(row);
            Insert(true, i, row, arr);
        }
        print(arr);
    }

    private void Insert(bool isRow, int dim, int[] source, int[,] dest)
    {
        for (int k = 0; k < source.Length; k++)
        {
            if (isRow)
                dest[dim, k] = source[k];
            else
                dest[k, dim] = source[k];
        }
    }

    private void print(int[, ] arr)
    {
        Console.WriteLine();
        Console.WriteLine("-- Сортированный массив --");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, 3}", arr[i, j]);
            }
            Console.WriteLine("]");
        }
    }
}