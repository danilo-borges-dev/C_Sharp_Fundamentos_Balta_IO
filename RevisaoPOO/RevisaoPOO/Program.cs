public class Program
{
    private static void Main(string[] args)
    {
        using (var pagamento = new Pagamento())
        {
            Console.WriteLine("Objeto iniciado.");
        }
    }
}

public class Pagamento : IDisposable
{
   public Pagamento ()
    {
        Console.WriteLine("Iniciando o Objeto Pagamento.");
    }

    public void Dispose()
    {
        Console.WriteLine("Encerrando o Objeto Pagamento.");
    }
}