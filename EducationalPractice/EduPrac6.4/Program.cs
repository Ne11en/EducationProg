Console.WriteLine("Введите число, на которое хотите поделить");
int a = Int32.Parse(Console.ReadLine());

int sum = 0;
int num = 0;

Console.WriteLine("Введите положительные числа (для завершения ввода и получения суммы чисел, делящихся нацело на введенное вами ранее число, введите отрицательное число)");

while (true)
{  
    num = Int32.Parse(Console.ReadLine());
    if (num < 0)   
    {
        break;
    }
    
    if (num % a == 0)
    {  
        sum += num;
    }
}

Console.WriteLine($"Сумма чисел, делящихся нацело на введенное вами ранее число = {sum}");