Console.WriteLine("Primeira nota");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Peso da primeira nota");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("Segunda nota");
float c = float.Parse(Console.ReadLine());

Console.WriteLine("peso da segunda nota");
float d = float.Parse(Console.ReadLine());

float nota = ((a*b) + (c*d)) / (b+d) ;

Console.WriteLine("A Media do aluno é: " + nota);