public class HomeWork9_3
{
    private int akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else
            if ((m != 0) && (n == 0))
                return akkerman(m - 1, 1);
            else
                return akkerman(m - 1, akkerman(m, n - 1));
    }

    public void start()
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A({m}, {n}) = {akkerman(m, n)}");
    }

}
