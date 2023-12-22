using static System.Console;

int sum = 0;

WriteLine("Введите число, от которого вы хотите посчитать сумму всех чисел до 500: ");
int a = int.Parse(ReadLine());

if (a < 500)
{
    for (int i = a; i <= 500; i++)
    {
        sum = sum + i;
    }
}

else
{
    WriteLine("Введите число МЕНЬШЕ 500");
}

WriteLine($"Сумма всех чисел от {a} до 500 = {sum}");