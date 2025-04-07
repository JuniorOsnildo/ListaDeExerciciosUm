Console.WriteLine("Salario base");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Total de vendas");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("Porcentagem da comissão");
float c = float.Parse(Console.ReadLine());


float salario = (a + b * (c / 100f));

Console.WriteLine($"O salario do vendedor é: {salario:F2}R$");