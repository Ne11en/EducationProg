Random rnd = new Random();

int[] maxArray = new int[10];
int [,] array = new int[2, 10];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[i, j] = rnd.Next(0, 10);
    }
}

FindMaxValues(array, maxArray);

Console.WriteLine($"Исходный массив: ");
PrintArray(array, maxArray);

static void PrintArray (int [,] array, int[] maxArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Массив с наибольшими числами: ");
    for (int i = 0; i < maxArray.Length; i++)
    {
        Console.Write($"{maxArray[i]} \t");
    }
}

static void FindMaxValues(int[,] array, int[] maxArray)
{
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (i == 0 && array[i, j] > array[i + 1, j])
            {
                maxArray[j] = array[i, j];
            }
            else
            {
                maxArray[j] = array[i + 1, j];
            }
        }
    }
}
