Random rnd = new Random();

int [] randArray = new int[200];

for (int i = 0; i < randArray.Length; i++)
{
    randArray[i] = rnd.Next(-100, 100);
}

int posCount, negCount, zeroCount;
CountNumbers(randArray, out posCount, out negCount, out zeroCount);

Console.WriteLine($"Положительных чисел: {posCount}");
Console.WriteLine($"Отрицательных чисел: {negCount}");
Console.WriteLine($"Нулевых чисел: {zeroCount}");

static int CountNumbers (int[] randArray, out int posCount, out int negCount, out int zeroCount)
{
    posCount = 0;
    negCount = 0;
    zeroCount = 0;
    
    for (int i = 0; i < randArray.Length; i++)
    {
        if (randArray[i] > 0)
        {
            posCount += 1;
        }
        else if (randArray[i] < 0)
        {
            negCount += 1;
        }
        else
        {
            zeroCount += 1;
        }
    }
    return 0;
}
