static float VolumeRetangulo(float a, float b, float c)
{
    return a * b * c;
}

Console.WriteLine("digite o primeiro valor");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo valor");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("digite o terceiro valor");
float c = float.Parse(Console.ReadLine());



Console.WriteLine("O volume do retangulo é de: "+ VolumeRetangulo(a, b, c));