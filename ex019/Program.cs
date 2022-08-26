Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());
x = Math.Abs(x);

while (x < 9999 || x > 100000)
{
    Console.WriteLine("Введите пятизначное число: ");
    x = int.Parse(Console.ReadLine());
}

if (x > 9999 || x < 100000)
{
    int a = x / 1000;
    int b = x % 100;

    if (a / 10 == b % 10 && a % 10 == b / 10)
    {
        Console.WriteLine("Это число является палиндромом");
    }
    else
    {
        Console.WriteLine("Это число не является палиндромом");
    }
}
