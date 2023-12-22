int startRange, endRange, arrayLength;

Console.Write("Введите начало диапазона: ");
startRange = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец диапазона: ");
endRange = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину массива: ");
arrayLength = Convert.ToInt32(Console.ReadLine());

int[] randomArray = FillRandomArray(startRange, endRange, arrayLength);
PrintArray(randomArray);


static int[] FillRandomArray(int start, int end, int length)
{
    Random random = new Random(); 
    int[] array = new int[length];
    
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = random.Next(start, end + 1); 
    }
    return array;
}

static void PrintArray(int[] array)
{
    foreach (int num in array) 
    { 
        Console.Write(num + " "); 
    }
}
