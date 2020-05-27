using System;

namespace MovieCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie citizenKane = new Movie()
            {
                Title = "Citizen Kan",
                Year = 1946,
                IsGood = true,
            };
            Movie bladeRunner = new Movie()
            {
                Title = "Blade Runner",
                Year = 1982,
                IsGood = true,
            };

            Collection myCollection = new Collection();
            myCollection.AddMovie(citizenKane);
            myCollection.AddMovie(bladeRunner);

            myCollection.PrintMovies();

            Console.Write("Enter a movie index to see details> ");
            string strIndex = Console.ReadLine();
            int index;

            if (!int.TryParse(strIndex, out index))
            {
                Console.WriteLine("You didn't enter a number, using zero...");
                index = 0;
            }

            try
            {
                Movie selectedMovie = myCollection.GetMovie(index);

                Console.WriteLine();
                Console.WriteLine("Selected Movie");
                Console.WriteLine("------------------");
                Console.WriteLine($" Title: {selectedMovie.Title}");
                Console.WriteLine($" Year: {selectedMovie.Year}");
                Console.WriteLine($" Is it good? {selectedMovie.IsGood}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("You entered an invalid index. Try harder.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}