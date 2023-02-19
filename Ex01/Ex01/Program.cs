namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 3.1 og 3.2
            string name = "";
            int age = 0;

            name = Console.ReadLine();
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} er {1} år gammel", name, age);
        }
    }
}