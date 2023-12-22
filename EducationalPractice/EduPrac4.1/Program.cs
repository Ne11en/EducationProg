Console.WriteLine("Введите натуральное число больше трех");
int n = Int32.Parse(Console.ReadLine());

int res = 1;

for (int i = n; i > 0; i--)
{
    if (n > 3)
    {
        if (i % 3 == 0)
            res *= i;
    }
    
    else
    {
        Console.WriteLine("Введите число больше трех");
    }
}

Console.WriteLine($"Произведение натуральных чисел, кратных трем и не превышающих введенное число: {res}");