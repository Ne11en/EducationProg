Console.WriteLine("Введите число a (отличное от чисел b и c)");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b (отличное от чисел a и c)");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c (отличное от a и b)");
int c = int.Parse(Console.ReadLine());

int m;

if (a > b && a > c)
{
    m = a;
}

else if (b > a && b > c)
{
    m = b;
}

else
{
    m = c;
}

Console.WriteLine($"The biggest number is {m}");