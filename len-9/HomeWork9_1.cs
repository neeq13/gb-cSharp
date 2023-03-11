public class HomeWork9_1
{
    private int natural(int num)
    {

        if (num != 1)
        {
            Console.Write($"{num} ");
            return natural(num - 1);
        }
        return num;
    }

    public void start()
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write($"N = {num} => ");
        Console.WriteLine($"{natural(num)} ");
    }

}
