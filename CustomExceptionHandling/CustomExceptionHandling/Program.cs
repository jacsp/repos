using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-2);

                Console.WriteLine(posValue);
                Console.ReadLine();
            }
            catch (NegativeIndexOutOfRangeException ex)
            {
                
            }
        }
    }
}