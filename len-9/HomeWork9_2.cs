public class HomeWork9_2
{
    private int sumNatural(int numM, int numN, int sum)
    {
        if (numM != numN)
        {
            sum += numM;
            numM++;
            return sumNatural(numM, numN, sum);
        }
        return sum += numN;
    }

    public void start()
    {
        Console.Write("Введите число M: ");
        int numM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int numN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sumNatural(numM, numN, 0));
    }

}
