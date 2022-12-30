Console.Clear();

float primeiroValor = new float();
float segundoValor = new float();

Console.WriteLine("Primeiro valor: ");
primeiroValor = float.Parse(Console.ReadLine());
Console.WriteLine("Segundo valor: ");
segundoValor = float.Parse(Console.ReadLine());

Console.WriteLine($"\nO resultado da Soma: {primeiroValor + segundoValor}");
