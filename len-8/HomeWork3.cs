class HomeWork3
{

    private int[, ] doubleMass()
    {
        Console.Write("Размер матирцы по X: ");
        int arrX = Convert.ToInt32(Console.ReadLine());
        Console.Write("Размер матирцы по Y: ");
        int arrY = Convert.ToInt32(Console.ReadLine());
        int[,] list = new int[arrY, arrX];
        for (int i = 0; i < arrY; i++)
        {
            for(int j = 0; j < arrX; j++)
            {
                list[i, j] = new Random().Next(0, 10);
            }
        }
        return list;
    }

    private void print(int[, ] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, 4}", arr[i, j]);
            }
            Console.WriteLine("]");
        }
    }

    private void matrixPrint(int[, ] list1, int[, ] list2)
    {
        Console.WriteLine("-- Заданные матрицы --");
        int temp = list1.GetLength(0) > list2.GetLength(0) ? list1.GetLength(0) : list2.GetLength(0);
        for (int i = 0; i < temp; i++)
        {
            if(i < list1.GetLength(0))
            {
                Console.Write("[");
                for(int j = 0; j < list1.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", list1[i, j]);
                }
                Console.Write("]");
            }
            else
                Console.Write("           ");
            if(i > list2.GetLength(0))
                continue;
            else
            {
                Console.Write(" [");
                for(int j = 0; j < list2.GetLength(1); j++)
                {
                    
                    Console.Write("{0, 3}", list2[i, j]);
                }
                Console.Write("]");
            }
            Console.WriteLine();
        }
    }

    public void matrixMult()
    {
        // int[, ] A = {{2, 4}, {3, 2}}; // Проверочный вариант
        // int[, ] B = {{3, 4}, {3, 3}}; // Проверочный вариант
        Console.WriteLine("Задайте параметры матриц, но учитывайти они должны быть ьлдбкл квадратными 3х3");
        Console.WriteLine("Первая матирца: ");
        int[, ] A = doubleMass();
        Console.WriteLine("Вторая матирца: ");
        int[, ] B = doubleMass();
        matrixPrint(A, B);
        int[, ] C = new int[A.GetLength(0), A.GetLength(1)];

        Console.WriteLine();
        Console.WriteLine("-- Произведение матриц --");
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for(int j = 0; j < C.GetLength(1); j++)
            {
                Console.Write($"C[{i}, {j}] = ");
                for(int k = 0; k < C.GetLength(0); k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                    Console.Write($"{A[i, k]} * {B[k, j]}");
                    if(k + 1 < C.GetLength(0))
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine($" = {C[i, j]}");
            }
        }
        print(C);
    }
}