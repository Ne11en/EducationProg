// УП Практическая работа 1.1


/* Задание 1.1

Console.WriteLine("Массив из 10 рандомных чисел: ");
int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
    Console.WriteLine(array[i]);
}

int MinNum = 0;
int MinValue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < MinValue)
    {
        MinValue = array[i];
        MinNum = i;
    }
}
Console.WriteLine($"Минимальное число: {MinValue} \t его порядковый номер: {MinNum} ");


// Задание 1.2

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



// Задание 1.3

List<string> words = new List<string>();

string input;

for (;;)
{
    input = Console.ReadLine();

    if (input == "")
    {
        break;
    }
    words.Add(input);
}

string MaxWord = words[0];
string MinWord = words[0];
int MaxLen = words[0].Length;
int MinLen = words[0].Length;
int index1 = 0;
int index2 = 0;

for (int i = 0; i < words.Count; i++)
{
    if (words[i].Length > MaxLen)
    {
        MaxWord = words[i];
        MaxLen = words[i].Length;
        index1 = i;
    }
}

for (int i = 0; i < words.Count; i++)
{
    if (words[i].Length < MinLen)
    {
        MinWord = words[i];
        MinLen = words[i].Length;
        index2 = i;
    }
}

Console.WriteLine($"Самый длинный элемент списка: {MaxWord} \tЕго длина: {MaxLen} \tЕго порядковый номер: {index1}");
Console.WriteLine($"Самый короткий элемент списка: {MinWord} \tЕго длина: {MinLen} \tЕго порядковый номер: {index2}");


// Задание 2.1

int [] array = new int [100];
array[0] = 100;
for (int i = 0; i < array.Length; i++)
{
    if (i == 0)
    {
        Console.Write($"{array[i]} ");
    }
    
    else
    {
        array[i] = array[i - 1] - 3;
        Console.Write($"{array[i]} ");
    }
}



// Задание 2.2

Console.WriteLine("Сколько НЕчетных чисел вы хотите получить, начиная с 1? ");
int ArraySize = Int32.Parse(Console.ReadLine());
int [] array = new int [ArraySize];

array[0] = 1;
Console.WriteLine(array[0]);

for (int i = 1; i < array.Length; i++)
{
    array[i] = array[i - 1] + 2;
    Console.WriteLine(array[i]);
}


// Задание 2.3

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



// Задание 2.4
 
Random rnd = new Random();

int m = 12;
int d = 30;

int[,] temp = new int[m,d];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < d; j++)
    {
        if (i == 0 || i == 1 || i == 11)
        {
            temp[i, j] = rnd.Next(-35, 0);
        }
        else if (i == 2 || i == 3 || i == 4)
        {
            temp[i, j] = rnd.Next(0, 20);
        }
        else if (i == 5 || i == 6 || i == 7)
        {
            temp[i, j] = rnd.Next(5, 35);
        }
        else
        {
            temp[i, j] = rnd.Next(-15, 10);
        }
    }
}

double[] AvgTemp(int[,] temperature)
{
    double[] avg = new double[12];
    double SumTemp = 0;
    for (int i = 0; i < 12; i++)
    {
        for (int j = 0; j < 30; j++)
        {
            SumTemp += temperature[i, j];
        }

        avg[i] = Math.Round(SumTemp / 30.0, 2, MidpointRounding.ToEven);
        SumTemp = 0;
    }

    return avg;
}
double [] AverageTemperature = AvgTemp(temp);
Array.Sort(AverageTemperature);

foreach (double i in AverageTemperature)
{
    Console.WriteLine($"Средняя температура : {i}");
}



// Задание 2.5

Random rnd = new Random();

int[] junuaryTemp = new int[30];
for (int i = 0; i < junuaryTemp.Length; i++)
{
    junuaryTemp[i] = rnd.Next(-35, 0);
}

int[] februaryTemp = new int[30];
for (int i = 0; i < februaryTemp.Length; i++)
{
    februaryTemp[i] = rnd.Next(-30, 0);
}

int[] marchTemp = new int[30];
for (int i = 0; i < marchTemp.Length; i++)
{
    marchTemp[i] = rnd.Next(-5, 10);
}

int[] aprilTemp = new int[30];
for (int i = 0; i < aprilTemp.Length; i++)
{
    aprilTemp[i] = rnd.Next(-5, 15);
}

int[] mayTemp = new int[30];
for (int i = 0; i < mayTemp.Length; i++)
{
    mayTemp[i] = rnd.Next(0, 25);
}

int[] juneTemp = new int[30];
for (int i = 0; i < juneTemp.Length; i++)
{
    juneTemp[i] = rnd.Next(5, 35);
}

int[] julyTemp = new int[30];
for (int i = 0; i < julyTemp.Length; i++)
{
    julyTemp[i] = rnd.Next(10, 35);
}

int[] augustTemp = new int[30];
for (int i = 0; i < augustTemp.Length; i++)
{
    augustTemp[i] = rnd.Next(5, 30);
}

int[] septemberTemp = new int[30];
for (int i = 0; i < septemberTemp.Length; i++)
{
    septemberTemp[i] = rnd.Next(0, 15);
}

int[] octoberTemp = new int[30];
for (int i = 0; i < octoberTemp.Length; i++)
{
    octoberTemp[i] = rnd.Next(-10, 10);
}

int[] novemberTemp = new int[30];
for (int i = 0; i < novemberTemp.Length; i++)
{
    novemberTemp[i] = rnd.Next(-15, 5);
}

int[] decemberTemp = new int[30];
for (int i = 0; i < decemberTemp.Length; i++)
{
    decemberTemp[i] = rnd.Next(-35, 0);
}

Dictionary <string, int[]> temp = new Dictionary<string, int[]>()
{
    { "Январь", junuaryTemp },
    { "февраль", februaryTemp },
    { "март", marchTemp },
    { "апрель", aprilTemp },
    { "май", mayTemp },
    { "июнь", juneTemp },
    { "июль", julyTemp },
    { "август", augustTemp },
    { "сентябрь", septemberTemp },
    { "октябрь", octoberTemp },
    { "ноябрь", novemberTemp },
    { "декабрь", decemberTemp }
};

Dictionary<string, double> AvgTemp(Dictionary<string, int[]> temperature)
{
    Dictionary <string, double> avg = new Dictionary<string, double>();
    double sumTemp = 0;
    foreach (var i in temperature )
    {
        for (int j = 0; j <i.Value.Length; j++)
        {
            sumTemp = sumTemp + i.Value[j];
        }
        
        avg[i.ToString()] = Math.Round(sumTemp / 30.0, 2, MidpointRounding.ToEven);
        sumTemp = 0;
        Console.WriteLine($"{avg.Keys} {avg.Values}");
    }
    

    return avg;
}

Dictionary<string, double> averageTemp = AvgTemp(temp);
foreach (var i in averageTemp)
{
    Console.WriteLine($"{i.Key} {i.Value}");
}



// Задание 3.1

string pathInput = "../../../input.txt";
string pathOutput = "../../../output.txt";

string [] readText = File.ReadAllLines(pathInput);

int [] numbers = new int [10];
int [] ticket = new int [6];

int n = 0;

IEnumerable <int> k = new int[6];

numbers = readText[0].Split(' ').Select(int.Parse).ToArray();

n = int.Parse(readText[1]);

for (int i = 2; i < n + 2; i++)
{
    ticket = readText[i].Split(' ').Select(int.Parse).ToArray();
    k = ticket.Intersect(numbers);
    if (k.Count() >= 3)
    {
        File.AppendAllText(pathOutput, "Lucky \n");
    }
    
    else
    {
        File.AppendAllText(pathOutput, "Unlycky:( \n");
    }
} 
*/


// Задание 3.2

string pathNums = "../../../nums.txt";

string [] readNums = File.ReadAllLines(pathNums);

int [] numbers;

string res = ""; 

numbers = readNums[0].Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        res = res + (Convert.ToString(numbers[i]) + " ");
    }
}
File.WriteAllText(pathNums, res);
