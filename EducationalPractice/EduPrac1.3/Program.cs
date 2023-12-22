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