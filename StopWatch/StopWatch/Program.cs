Start();

void Start()
{
    int time = 1;

    while (time <= 10)
    {
        Console.Clear();
        Console.WriteLine(time++);
        Thread.Sleep(1000);
    }
}