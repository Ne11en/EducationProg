Console.WriteLine("Введите размер массива: ");
int arLen = int.Parse(Console.ReadLine());

int[] array = new int [arLen];

Console.WriteLine("Заполните массив (через Enter): ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int minNum = array[0];
int res = 0;

for (int i = 0; i < array.Length; i++)
{
    if ((array[i]) < minNum)
    {
        minNum = array[i];
        res = i;
    }
}

Console.WriteLine($"Номер минимального элемента массива: {res}");