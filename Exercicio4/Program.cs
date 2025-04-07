Console.WriteLine("Temperatura em celcius");
float c = float.Parse(Console.ReadLine());

float f = (c * 9f / 5f) + 32f;

Console.WriteLine($"{c}Cº em fahrenheit: {f:F2}");