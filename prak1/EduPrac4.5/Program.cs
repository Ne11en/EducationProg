Console.WriteLine("Введите координату оси Х");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату оси У");
double y = Convert.ToDouble(Console.ReadLine());

if ((x <= 3 && x >= -1) && (y <= 4 && y >= -2))
{
    Console.WriteLine("Введенные вами точки принадлежат заштрихованной области");
}
else
{
    Console.WriteLine("Введенные вами точки не принадлежат заштрихованной области");
}