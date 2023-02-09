internal class Program
{
    private static void Main(string[] args)
    {
        // Bruger input
        Console.Write("Indtast navn: ");
        string? navn = Console.ReadLine();
        Console.Write("Indtast alder: ");
        string? alder = Console.ReadLine();

        // Print to console
        Console.WriteLine(navn + " er " + alder + " år gammel.");
    }
}