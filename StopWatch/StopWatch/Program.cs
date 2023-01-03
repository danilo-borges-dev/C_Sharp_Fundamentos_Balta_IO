Menu();

void Start(int time)
{
    int currentTime = 0;
    while (currentTime <= time)
    {
        Console.Clear();
        Console.WriteLine(currentTime++);
        Thread.Sleep(1000);
    }
    Console.WriteLine("Stopwatch finalizado.");
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("nS - Segundos (10S - Significa 10 Segundos)");
    Console.WriteLine("nM - Minutos (1M - Significa 1 Minuto)");
    Console.WriteLine("nH - Horas (2H - Significa 2 Horas)");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");
    string data = Console.ReadLine().ToUpper();
    char type = char.Parse(data.Substring((data.Length - 1), 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    int multiplier = 1;

    if (type == 'M')
    {
        multiplier = 60;
    }

    if (type == '0')
    {
        Environment.Exit(0);
    }

    Start(time * multiplier);
}