namespace Calculator.Utilities
{
    public static class Soma
    {           
        public static float Somar () 
        {
            float primeiroValor = new float();
            float segundoValor = new float();

            Console.WriteLine("Primeiro valor: ");
            primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            segundoValor = float.Parse(Console.ReadLine());
            return primeiroValor + segundoValor;
        }
    }
}