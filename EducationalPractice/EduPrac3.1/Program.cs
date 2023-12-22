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