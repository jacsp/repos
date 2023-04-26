using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posValue = 0;

            try
            {
                posValue = TotallySafe.GetValueAtPosition(-2);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NegativeIndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(posValue);
            Console.ReadLine();
        }
    }
}