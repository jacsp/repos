namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 3.1
            //int _height = 20;
            //int _width = 10;
            //int _area = _height * _width;

            //Console.WriteLine(area);

            //////////////////////////////////////////////////////////

            // Øvelse 3.2
            // Using double because result will contain decimals
            //double _x1 = 3;
            //double _y1 = 12;
            //double _x2 = 20;
            //double _y2 = 111
            //double _h = (_y2 - _y1) / (_x2 - _x1);

            //Console.WriteLine(_h);

            ////////////////////////////////////////////////////////

            // Øvelse 4.1 
            string _someString = "contains 5 letters";
            Console.WriteLine(_someString.Length);

            // Øvelse 4.2
            Console.WriteLine(_someString.Substring(3, 6));

            // Øvelse 4.3
            char _specialLetter = 't';
            
            if (_someString.IndexOf(_specialLetter) > 0)
            {
                Console.WriteLine("Character found at letter number: " + _someString.IndexOf(_specialLetter) + 1);
            }
            else
            {
                Console.WriteLine("Error, letter not found in string");
            }
        }
    }
}