class HomeWork4
{

    public void triplMass()
    {
        int[, , ] list = new int[2, 2, 2];
        for (int i = 0; i < list.GetLength(0); i++)
            for(int j = 0; j < list.GetLength(1); j++)
                for(int k = 0; k < list.GetLength(2); k++)
                    list[i, j, k] = new Random().Next(0, 10);
        print(list);
    }

    private void print(int[, , ] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("[");
                for(int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write("{0, 3}", arr[i, j, k]);
                    Console.Write($" [{i}, {j}, {k}]");
                }
                Console.Write("]");  
            }
            Console.WriteLine("]");
        }
    }
}