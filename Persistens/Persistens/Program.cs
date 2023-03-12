namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // git slettede hele opgave 11 for mig, så jeg er ret sur, at jeg blev nødt til at lave hele opgaven igen.

            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePerson(person);

            Console.Write("Writing person: ");
            Console.WriteLine(person.MakeTitle());

            Console.ReadLine();
        }
    }
}