class HomeWork5
{

    public void doubleMass()
    {
        string[, ] list = new string[4, 4];
        int count = list.GetLength(0) * list.GetLength(1);
        for (int i = 0; i < list.GetLength(0); i++)
            for(int j = 0; j < list.GetLength(1); j++)
            {
                if (i == 0)
                {
                    list[i, j] = "0" + (j + 1);
                }
                else if (i == 1 && j != list.GetLength(1) - 1){
                    list[i, j] = "1" + (j + 2);
                }
                else if (i == 1 && j == list.GetLength(1) - 1)
                {
                    list[i, j] = "0" + (j + 2);
                }
                else if (i == 2 && j == 0)
                {
                    list[i, j] = "11";
                }
                else if (i == 2 && j != list.GetLength(1) - 1)
                {
                    list[i, j] = $"{count}";
                    count--;
                }
                else if (i == 2 && j == list.GetLength(1) - 1)
                {
                    list[i, j] = "0" + (j + 3);
                    count = 10;
                }
                else if (i == 3 && j == 0){
                    list[i, j] = $"{count}";
                    count--;
                } else
                {
                    list[i, j] = "0" + $"{count}";
                    count--;
                }
            }
                
        print(list);
    }

    private void print(string[, ] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for(int j = 0; j < arr.GetLength(1); j++)
                Console.Write("{0, 3}", arr[i, j]);
            Console.WriteLine("]");
        }
    }
}