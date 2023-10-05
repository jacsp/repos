namespace TheMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Command Line UI for now
            Console.WriteLine("The Movies");

            MovieRepository movieRepository = new MovieRepository();

            string userInput;

            string[] userInputSplit;

            while (true)
            {
                Console.WriteLine("Tilføj film (titel,længde i minutter,genre)");

                // Read user input
                userInput = Console.ReadLine();

                // Split the string into three parts
                userInputSplit = userInput.Split(",");

                // Create a new movie with the three parts as parameters
                Movie movie = new Movie(userInputSplit[1], 2, "horror");

                Console.Clear();
            }
        }
    }
}