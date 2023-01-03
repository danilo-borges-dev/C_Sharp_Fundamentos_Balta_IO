using System.Globalization;

//Soma();
Subtracao();


void Soma()
{
    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 + n2;
    Console.WriteLine($"Resultado da Soma é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}

void Subtracao()
{
    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 - n2;
    Console.WriteLine($"Resultado da Subtração é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}