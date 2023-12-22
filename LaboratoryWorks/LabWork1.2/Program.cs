Console.WriteLine("Введите расстояние в километрах: ");
int distInKm = int.Parse(Console.ReadLine()) * 1000;

Console.WriteLine("Введите расстоение в метрах: ");
int distInM = int.Parse(Console.ReadLine());

if (distInKm > distInM)
{
    Console.WriteLine($"Первое расстояние больше ({distInKm}м)");
}

else if (distInM > distInKm)
{
    Console.WriteLine($"Второе расстояние больше ({distInM}м)");
}

else
{
    Console.WriteLine("Введенные расстояния равны");
}
