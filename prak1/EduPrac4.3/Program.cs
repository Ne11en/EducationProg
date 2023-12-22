using System.Threading.Channels;

string pathTask3 = "../../../Task3.txt";

string [] readTask3 = File.ReadAllLines(pathTask3);

int [] nums = new int[readTask3.Length];

nums = readTask3[0].Split(',').Select(int.Parse).ToArray();

int maxNum = nums[0];
int minNum = nums[0];

for (int i = 0; i < nums.Length; i++)
{
  Console.WriteLine(nums[i]);
}
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == 0)
    {
        break;
    }
    
    if (maxNum < nums[i])
    {
        maxNum = nums[i];
    }
    if (minNum > nums[i])
    {
        minNum = nums[i];
        Console.WriteLine(minNum);
    } 
    
}

double res = minNum / maxNum;

Console.WriteLine($"Отношение минимального элемента массива к максимальному = {minNum} : {maxNum} = {res}");
Console.WriteLine(nums[0]);
Console.WriteLine(nums[nums.Length - 1]);
