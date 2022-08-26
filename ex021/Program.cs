Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

double a = x2 - x1;
double b = y2 - y1;
double c = z2 - z1;

double a2 = Math.Pow(a, 2);
double b2 = Math.Pow(b, 2);
double c2 = Math.Pow(c, 2);

Console.WriteLine();
Console.WriteLine("Расстояние между точками = " + Math.Sqrt(a2 + b2 + c2));
