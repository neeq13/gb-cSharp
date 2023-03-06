Console.WriteLine("Задача 1:");
Console.Write("Введите длинну массива по длинне: ");
int arrX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива по высоте: ");
int arrY = Convert.ToInt32(Console.ReadLine());

void doubleMass(int arrX, int arrY)
{
    int[,] list = new int[arrY, arrX];
    for (int i = 0; i < arrY; i++)
    {
        for(int j = 0; j < arrX; j++)
        {
            list[i, j] = new Random().Next(-10, 10);
            Console.Write("[{0, 3}]", list[i, j]);
        }
        Console.WriteLine();
    }
}

doubleMass(arrX, arrY);

Console.WriteLine("Задача 2:");
Console.Write("Введите искомую позицию в массиве по Х: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомую позицию в массиве по Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

void searchPoint(int arrX, int arrY)
{
    int[,] list = new int[5, 5];
    
    for (int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            list[i, j] = new Random().Next(-10, 10);
            Console.Write("[{0, 3}]", list[i, j]);
        }
        Console.WriteLine();
    }
    if (arrX >= list.GetLength(0) || arrY >= list.GetLength(1))
    {
        Console.WriteLine("Такой точки не существет");
    } else
    {
        Console.WriteLine("Искомый элемент массива = [{0,3}]", list[arrX, arrY]);
    }
}

searchPoint(numY, numX);


Console.WriteLine("Задача 3:");
Console.Write("Введите длинну массива по Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массиве по Y: ");
int y = Convert.ToInt32(Console.ReadLine());

void average(int arrX, int arrY)
{
    float[] result = new float[arrX];
    int[,] list = new int[arrY, arrX];
    int count = 0;
    
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for(int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = new Random().Next(0, 10);
            Console.Write("[{0, 3}]", list[i, j]);
            count += list[i, j];
        }
        result[i] = (float)count / arrX;
        Console.WriteLine();
        count = 0;
        
    }
    Console.WriteLine("[{0}]", string.Join(", ", result));
}

average(x, y);