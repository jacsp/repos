using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace CsvHelperExperiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\jacob\\Downloads\\HundeDataSmall.csv";

            try
            {
                using (StreamReader streamReader = new(filePath))
                {
                    string? line;

                    // Setup
                    line = streamReader.ReadLine();

                    line.ToLower();

                    string[] mapping = line.Split(";");

                    int navnIndex = Array.IndexOf(mapping, "navn");
                    int pedigreeIndex = Array.IndexOf(mapping, "Stambog");
                    int sexIndex = Array.IndexOf(mapping, "sex");

                    while (line != null)
                    {
                        line = streamReader.ReadLine();

                        string[] values = line.Split(';');

                        Dog dog = new(values[pedigreeIndex], values[navnIndex], values[sexIndex]);

                        Console.WriteLine(dog.Name + " " + dog.PedigreeNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}