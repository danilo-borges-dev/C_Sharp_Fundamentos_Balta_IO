using System.Text.RegularExpressions;

namespace EditorHTML.Entities
{
    internal class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------");
            Replace(text);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(" ");
            
            foreach (var w in words) 
            {
                if (strong.IsMatch(w))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        w.Substring(
                            w.IndexOf('<') + 1,
                            ((w.LastIndexOf('<') - 1) - w.IndexOf('>'))
                            )
                        );
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(w);
                }
            }
        }
    }
}
