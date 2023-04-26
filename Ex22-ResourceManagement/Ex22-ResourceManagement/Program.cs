namespace Ex22_ResourceManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string thing = "";

            using (StreamReader sr = new (@"C:\Users\jacob\source\repos\Ex22-ResourceManagement\Ex22-ResourceManagement\TextFile1.txt"))
            {
                try
                {
                    thing = sr.ReadLine();
                }
                finally
                {
                    sr.Close();
                }
            }

            Console.Write(thing);
        }
    }
}