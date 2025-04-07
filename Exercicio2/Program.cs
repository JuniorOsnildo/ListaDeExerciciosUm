static double VolumeCilindro(double raio, double altura)
{
    return (Math.PI * Math.Pow(raio, 2)) * altura;
}

Console.WriteLine("digite o raio do cilindro");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("digite a Altura do cilindro");
float b = float.Parse(Console.ReadLine());


Console.WriteLine("O volume do cilindro é de: "+ VolumeCilindro(a, b));