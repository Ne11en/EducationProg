Console.WriteLine("Введите число, которое хотите поделить:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число, на которое хотите поделить:");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"Число {a} является делителем числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является делителем числа {b}");
}