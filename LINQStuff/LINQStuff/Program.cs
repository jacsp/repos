using System.Linq;

namespace LINQStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jacob", "Mikkel", "Nikolai", "Lars", "Oliver" };

            //IEnumerable<string> filteredNames = names.Where(n => n.Length > 5);

            IEnumerable<string> filteredNames = from n in names
                                                where n.Contains('a')
                                                select n;

            IEnumerable<string> query =
                from n in names
                where n.Contains('a')
                orderby n.Length
                select n.ToUpper();



            foreach (string name in query) Console.WriteLine(name);

        }
    }
}