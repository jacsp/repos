internal class Program
{
    private static void Main(string[] args)
    {
        // Bruger input
        Console.Write("Input name: ");
        string? name = Console.ReadLine();
        Console.Write("Input age: ");
        int age = Int32.Parse(Console.ReadLine());

        // Print to console
        //Console.WriteLine(name + " er " + age + " år gammel.");
        Person person = new Person(name, age);
        person.ageAndName();
    }
}

class Person
{
    // Initialize class variables
    public string name;
    public int age;

    // Class constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Class method
    public void ageAndName()
    {
        Console.WriteLine(name + " er " + age + " år gammel.");
    }
}