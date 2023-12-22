List<int> values = new List<int>();

int Sum = 0;
int X = 1;
int avg = 0;
int input;

for (;;)
{
    input = int.Parse(Console.ReadLine());
    
    if (input == 0)
    {
        break;
    }   
    values.Add(input);
}

for (int i = 0; i < values.Count; i++)
{
    Sum += values[i];  
    X *= values[i];
}
avg = Sum / values.Count;

Console.WriteLine($"Сумма введенных чисел: {Sum} \nПроизведение введенных чисел чисел: {X} \nСреднее арифметическоевведенных чисел: {avg}");