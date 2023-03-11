class HomeWork3
{

    private int[, ] doubleMass(int arrX, int arrY)
    {
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
                Console.Write("{0, 3}", arr[i, j]);
            }
            Console.WriteLine("]");
        }
    }

    private void matrixPrint(int[, ] list1, int[, ] list2)
    {
        Console.WriteLine("-- Заданные матрицы --");
        for (int i = 0; i < list1.GetLength(0); i++)
        {
            Console.Write("[");
            for(int j = 0; j < list1.GetLength(1); j++)
            {
                Console.Write("{0, 3}", list1[i, j]);
            }
            Console.Write("]");
            Console.Write(" [");
            for(int j = 0; j < list1.GetLength(1); j++)
            {
                Console.Write("{0, 3}", list2[i, j]);
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    public void matrixMult()
    {
        int[, ] A = doubleMass(2, 2);
        int[, ] B = doubleMass(2, 2);
        matrixPrint(A, B);
        int[, ] C = new int[A.GetLength(1), A.GetLength(0)];

        Console.WriteLine();
        Console.WriteLine("-- Произведение матриц --");
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for(int j = 0; j < C.GetLength(1); j++)
            {
                C[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
                Console.WriteLine($"C[{i}, {j}] = {A[i, 0]} * {B[0, j]} + {A[i, 1]} * {B[1, j]} = {C[i, j]}");
            }
        }
        print(C);
    }
}