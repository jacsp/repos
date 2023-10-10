using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace LambdaAndExtensionMethods
{
    internal class Program
    {
        // Øvelse 2
        //delegate double Calculate(string expression);
        //delegate int Sequence(int num);
        //delegate void Delete(int index);
        //delegate string Get();
        //delegate void Alert(string message);
        //delegate bool Exists(int id);
        //delegate void Area(int x, int y);

        Func<string, double> Calculate;
        Func<int, int> Sequence;
        Action<int> Delete;
        Func<string> Get;
        Action<string> Alert;
        Predicate<int> Exists;
        Action<int, int> Area;

        // Øvelse 4 Anonyme delegates til lambda
        /*
         * 1: (x, y) => x + y;
         * 2: x => x * 10;
         * 3: x => x * x;
         */

        static void Main(string[] args)
        {
            
        }
    }
}