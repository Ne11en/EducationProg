Console.WriteLine("Введите количество строк квадратной матрицы: ");
int a = int.Parse(Console.ReadLine());
int[,] array = new int[a, a];
for (int i = 0; i < a; i++) // обозначение единиц
{
    for (int j = 0; j < a; j++)
    {
        array[0, j] = 1;
        array[i, 0] = 1;
    }
}

for (int i = 1; i < a; i++) // обозначение сумм матрицы
{
    for (int j = 1; j < a; j++)   
    {
    array[i, j] = array[i - 1, j] + array[i, j - 1];
    }
}

for (int i = 0; i < a; i++) // вывод матрицы
{
    for (int j = 0; j < a; j++)
    {
        Console.Write($"{array[i,j]}\t ");
    } 
    Console.WriteLine();
}