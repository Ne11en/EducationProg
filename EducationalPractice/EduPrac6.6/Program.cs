Random rnd = new Random();  
double[] array = new double[rnd.Next(10, 20)];

int countPos = 0;   
int countNeg = 0;

Console.WriteLine("Все числа:");
for (int i = 0; i < array.Length; i++)
{    
    array[i] = rnd.NextDouble() * ((10.0) - (-10.0)) + (-10.0);
    array[i] = Math.Round(array[i], 2);      
    Console.WriteLine(array[i]);
    
    if (array[i] < 0)    
    {
        countNeg++;
    }
    
    else if (array[i] > 0)    
    {
        countPos++;
    }
}     

double[] positive = new double[countPos]; 
double[] negative = new double[countNeg];

countPos = 0;
countNeg = 0;

for (int i = 0; i < array.Length; i++)
{          
    if (array[i] < 0)
    {
        negative[countNeg] = array[i];
        countNeg++;
    }
    
    else if (array[i] > 0)     
    {
        positive[countPos] = array[i];  
        countPos++;
    }
}

Console.WriteLine("Отрицательные числа:");   
foreach (double i in negative)
{
    Console.WriteLine(i);
}   

Console.WriteLine("Положительные числа:");
foreach (double i in positive)
{
    Console.WriteLine(i);
}