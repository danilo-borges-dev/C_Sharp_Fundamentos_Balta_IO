Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Abrir();
            break;
        case 2:
            Editar();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void Abrir()
{

}

void Editar()
{
    Console.WriteLine("Digite seu texto abaixo (ESC para Sair)");
    Console.WriteLine("-----------------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    using (StreamWriter stream = new(path))
    {
        stream.Write(text);
    }
    Console.WriteLine($"Arquivo salvo {path} com sucesso.");
    Menu();
}
