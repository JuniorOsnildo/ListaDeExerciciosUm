Console.WriteLine("digite o valor");
float a = float.Parse(Console.ReadLine());

double soma = a;

Console.Write($"{a}");

for (float i = a-1; i >= 1; i--)
{
    soma *= i;
    Console.Write($"x{i}");
    
}
    


Console.WriteLine(" | Resulatado: " +soma);