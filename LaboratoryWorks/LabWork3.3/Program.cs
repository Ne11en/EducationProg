Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second nimber: ");
int b = int.Parse(Console.ReadLine());

(a, b) = (b, a);

Console.WriteLine($"First number: {a} \t Second number: {b}");