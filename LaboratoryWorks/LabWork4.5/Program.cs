int [,,] arr = new int[3, 3, 3];

Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = rnd.Next(0, 10);
        }
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.WriteLine($"Слой {i}");

    int minValue = arr[i, 0, 0];
    List<string> indexes = new List<string>();
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            if (arr[i, j, k] < minValue)
            {
                minValue = arr[i, j, k];
                indexes.Clear();
                indexes.Add(string.Format("{0}, {1}, {2}", i, j, k));
            }
            else if (arr[i, j, k] == minValue)
            {
                indexes.Add(string.Format("{0}, {1}, {2}", i, j, k));
            }
        }
    }

    Console.WriteLine("Индексы минимальных элементов слоя: ");
    foreach (string index in indexes)
    {
        Console.WriteLine(index);
    }

    Console.WriteLine();
}
