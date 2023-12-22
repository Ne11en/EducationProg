int [] numbers = new int[11];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
}

Console.WriteLine("Введите число, для которого хотите увидеть таблицу умножения: ");

int num = int.Parse(Console.ReadLine());

int res;

for (int i = 1; i < numbers.Length; i++)
{
    res = num * i;
    Console.WriteLine($"{num} * {i} = {res}");
}
