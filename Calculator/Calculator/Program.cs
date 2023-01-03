using System.Globalization;

//Soma();
//Subtracao();
//Divisao();
//Multiplicacao();

Menu();

void Soma()
{
    Console.Clear();

    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 + n2;
    Console.WriteLine($"Resultado da Soma é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}

void Subtracao()
{
    Console.Clear();

    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 - n2;
    Console.WriteLine($"Resultado da Subtração é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}

void Divisao()
{
    Console.Clear();

    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 / n2;
    Console.WriteLine($"Resultado da Divisão é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}

void Multiplicacao()
{
    Console.Clear();

    Console.Write("Digite o primeiro número: ");
    float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float n2 = float.Parse(Console.ReadLine());

    float result = n1 * n2;
    Console.WriteLine($"Resultado da Multiplicação é {result.ToString("F2", CultureInfo.InvariantCulture)}");
}

void Menu()
{
    Console.Clear();

    Console.WriteLine("------------------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("------------------------");
    Console.Write("Selecione uma opção: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao) 
    {
        case 1: 
            Soma(); 
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }

}