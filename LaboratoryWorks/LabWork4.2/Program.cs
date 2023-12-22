Console.WriteLine("Введите начало диапазона: ");
int startArray = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конец диапазона: ");
int endArray = int.Parse(Console.ReadLine());

static int[] RandomArray(int startArray, int endArray)
{
    Random rnd = new Random();
    
    int []rndArray = new int[endArray - startArray];

    for (int i = 0; i < rndArray.Length; i++)
    {
        rndArray[i] = rnd.Next(startArray, endArray);
        Console.Write(rndArray[i] + " ");
    }

    return rndArray;
}

RandomArray(startArray, endArray);
