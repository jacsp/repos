namespace ConsoleThing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Menu\n\n1. Gør dit\n2. Gør dat\n3. Noget\n4. Andet\n\n(Tryk menupunk 1, 2, 3 eller 4)");

            //int choice = Int32.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Ting nummer 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Ting nummer 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Ting nummer 3");
            //        break;
            //    case 4:
            //        Console.WriteLine("Ting nummer 4");
            //        break;
            //    default:
            //        Console.WriteLine("¨Vælg et tal fra 1 til 4");
            //        break;
            //}

            int age = 0xf;

            Person ting = new Person("Ting", age);

            ting.sayHello();
        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void sayHello()
        {
            Console.WriteLine("Hej, mit navn er {0}, jeg er {1} år gammel.", name, age);
        }
    }
}