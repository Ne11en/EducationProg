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