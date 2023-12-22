
// Задание 5
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int res = 0;

Console.WriteLine("В каком формате вы его ввели? (Байты(1)/Килобайты(2))");
string format = Console.ReadLine();

switch (format)
{
    case "1":
        res = number / 1024;
        Console.WriteLine($"Ваше число в килобайтах: {res}");
        break;
    case "2":
        res = number * 1024;
        Console.WriteLine($"Ваше число в байтах: {res}");
        break;
}
