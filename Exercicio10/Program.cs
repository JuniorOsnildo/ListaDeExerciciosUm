Console.WriteLine("digite sua altura (em metros)");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("digite seu peso");
float b = float.Parse(Console.ReadLine());

double imc = b / Math.Pow(a,2);

if(imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 & imc <= 25)
{
    Console.WriteLine("Peso Normal");
}
else if (imc > 25 && imc <= 30)
{
    Console.WriteLine("Acima do peso");
}
else if (imc > 30)
{
    Console.WriteLine("Obesidade");
}