namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            do
            {
                Console.WriteLine("Vælg en af tingene fra menuen\n1. Add\n2. Subtract\n3. Division\n4. Multiply\n");
                string input = Console.ReadLine();
                int inputNum = ToInt(input);
                double result = 0;

                if (inputNum == 1)
                {
                    Console.WriteLine("Skriv to tal");
                    int num1 = ToInt(Console.ReadLine());
                    int num2 = ToInt(Console.ReadLine());
                    result = calc.Add(num1, num2);
                } 
                else if (inputNum == 2)
                {
                    Console.WriteLine("Skriv to tal");
                    int num1 = ToInt(Console.ReadLine());
                    int num2 = ToInt(Console.ReadLine());
                    result = calc.Subtract(num1, num2);
                }
                else if (inputNum == 3)
                {
                    Console.WriteLine("Skriv to tal");
                    int num1 = ToInt(Console.ReadLine());
                    int num2 = ToInt(Console.ReadLine());
                    result = calc.Divide(num1, num2);
                }
                else if (inputNum == 4) 
                {
                    Console.WriteLine("Skriv to tal");
                    int num1 = ToInt(Console.ReadLine());
                    int num2 = ToInt(Console.ReadLine());
                    result = calc.Multiply(num1, num2);
                }
                else
                {
                    Console.WriteLine("Fejl, den mulighed findes ikke på menuen.\n");
                    continue;
                }

                Console.WriteLine("Resultat: " + result + "\n");
                
            } while (true);

            int ToInt(string input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Fejl, kun skriv heltal");
                        return 0;
                    }
                }

                return Int32.Parse(input);
            }
        }
    }
}