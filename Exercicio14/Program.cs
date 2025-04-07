Console.WriteLine("digite o valor");
double a = float.Parse(Console.ReadLine());

double atual = 1;
double anterior = 0;

Console.WriteLine(atual);

for (int i = 0; i < a; i++)
{
    double aux = atual;
    atual += anterior;
    anterior = aux;
    
    if (atual < a)
    {
        Console.WriteLine(atual);
    }
    
}