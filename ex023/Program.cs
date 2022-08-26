Console.WriteLine("Введите число отличное от нуля: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int j = -1;



while (n == 0)
{
    Console.WriteLine("Введите число отличное от нуля: ");
    n = int.Parse(Console.ReadLine());
}
Console.Write(n + "    -> ");
if (n > 0)
{
    
    while (i <= n)
    {
        Console.Write(Math.Pow(i, 3) + ",");
        i++;
    }
}
else
{
    while (j >= n)
    {   
        Console.Write(Math.Pow(j, 3) + ", ");
        j--;
    }
}
