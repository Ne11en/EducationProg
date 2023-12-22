Console.WriteLine("Введите координату Х");  
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату У");
double y = double.Parse(Console.ReadLine());

double x1 = 0, x2 = 2, x3 = -2;
double y1 = 2, y2 = -3, y3 = -3;

double res1 = (x1 - x)*(y2-y1)-(x2-x1)*(y1-y);
double res2 = (x2 - x)*(y3-y2)-(x3-x2)*(y2-y);
double res3 = (x3 - x)*(y1-y3)-(x1-x3)*(y3-y);

if ((res1 >= 0 && res2 >= 0 && res3 >= 0) || (res1 <= 0 && res2 <= 0 && res3 <= 0))
{        
    Console.WriteLine("Введенные вами координаты принадлежат заштрихованной области");
}   

else
{
    Console.WriteLine("Введенные вами координаты не принадлежат заштрихованной области"); 
}