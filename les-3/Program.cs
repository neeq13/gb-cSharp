Console.WriteLine("Задача 1:");
Console.Write("Введите 5-и значное число: ");

string b = Console.ReadLine();
void Palindrome(string b)
{
    if (b[0].Equals(b[b.Length-1]) && b[1].Equals(b[b.Length-2]))
        Console.WriteLine("Является");
    else
        Console.WriteLine("Не является");
}
if (b.Length == 5)
    Palindrome(b);
else
    Console.WriteLine("Введено не 5-и значное число");

Console.WriteLine("Задача 2");
int x1 = Coordinate("X", "A");
int y1 = Coordinate("Y", "A");
int z1 = Coordinate("Z", "A");
int x2 = Coordinate("X", "B");
int y2 = Coordinate("Y", "B");
int z2 = Coordinate("Z", "B");

int Coordinate(string plane, string point)
{
    Console.Write($"Введите координату {plane} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(double x1, double x2, double y1, double y2, double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double distance =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {distance}");

Console.WriteLine("Задача 3");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int cube){
  int count = 1;
  while (count <= cube){
    Console.WriteLine(Convert.ToInt32(Math.Pow(count, 3)));
    count++;
  }
}

Cube(cube);