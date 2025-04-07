Console.WriteLine("Quilometro inicial");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("quilometro final");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("Gasto em litros");
float c = float.Parse(Console.ReadLine());

float kmRodados = b - a;
float gastoPorLitro = c / kmRodados;


Console.WriteLine($"O carro faz {gastoPorLitro:F2} litros por quilometro");
