Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] arrayNum = new int [number.ToString().Length];

int sum = 0;
int multiplication = 1;
for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = number % 10;
    number = number / 10;
    sum += arrayNum[i];
    multiplication *= arrayNum[i];
}

Console.WriteLine($"Сумма цифр введенного числа = {sum} \n Произведение цифр введенного числа равно {multiplication}");