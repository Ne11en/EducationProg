Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

if (n > m)
{
    Console.WriteLine($"Number m < n");
}
else if (m > n)
{
    Console.WriteLine("Number m > n");
}
else
{
    Console.WriteLine("The numbers are equal");
}