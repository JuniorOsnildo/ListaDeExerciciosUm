Console.WriteLine("Digite um numero");
var numero = float.Parse(Console.ReadLine());


if (numero is 1 or 2){
    Console.WriteLine("é primo");
}
else if (numero % 2 == 0)
{
    Console.WriteLine("Não é primo");
}
else
{
    var primo = false;
    
    for (int i = 0; i < Math.Round(Math.Sqrt(numero)); i++)
    {
        if(numero % i == 0)
            primo = true;
    }
    
    Console.WriteLine(primo 
        ? "é primo" 
        : "Não é primo");

}