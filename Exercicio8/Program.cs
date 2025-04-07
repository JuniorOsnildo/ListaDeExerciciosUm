Console.WriteLine("digite o primeiro valor");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo valor");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("digite o terceiro valor");
float c = float.Parse(Console.ReadLine());

Console.WriteLine(a + b < c
    ? $"{a} + {b} = {a + b} que é menor que {c}"
    : $"{a} + {b} = {a + b} que não é menor que {c}");