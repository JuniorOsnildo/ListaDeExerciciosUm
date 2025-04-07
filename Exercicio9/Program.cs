Console.WriteLine("digite o primeiro valor");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo valor");
int b = int.Parse(Console.ReadLine());

int max = Math.Max(a, b);
int min = Math.Min(a, b);

Console.WriteLine("digite o terceiro valor");
int c = int.Parse(Console.ReadLine());


Console.WriteLine($"{Math.Max(Math.Max(a,b),c)}");
Console.WriteLine($"{Math.Min(Math.Max(a,b),Math.Max(a,c))}");
Console.WriteLine($"{Math.Min(Math.Min(a,b),c)}");