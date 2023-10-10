using System.ComponentModel;

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

        static void Main(string[] args)
        {
            
        }
    }
}