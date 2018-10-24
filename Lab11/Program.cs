using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        public const string ANIMATED = "Animated";
        public const string HORROR = "Horror";
        public const string SCIFI = "SciFi";
        public const string DRAMA = "Drama";

        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Howl's Moving Castle", ANIMATED);
            Movie movie2 = new Movie("It", HORROR);
            Movie movie3 = new Movie("The Shawshank Redemption", DRAMA);
            Movie movie4 = new Movie("The Lion King", ANIMATED);
            Movie movie5 = new Movie("It's a Wonderful Life", DRAMA);
            Movie movie6 = new Movie("The Blair Witch Project",HORROR);
            Movie movie7 = new Movie("Inception", SCIFI);
            Movie movie8 = new Movie("The Martian", SCIFI);
            Movie movie9 = new Movie("Princess Mononoke", ANIMATED);
            Movie movie10 = new Movie("Up", ANIMATED);
            Movie movie11 = new Movie("Moana", ANIMATED);
            Movie movie12 = new Movie("Paranormal Activity", HORROR);
            Movie movie13 = new Movie("Schindler's List", DRAMA);
            Movie movie14 = new Movie("E.T.", SCIFI);
            Movie movie15 = new Movie("Eternal Sunshine of the Spotless Mind", DRAMA);
            Movie movie16 = new Movie("The Ring", HORROR);
            Movie movie17 = new Movie("Avatar", SCIFI);
            Movie movie18 = new Movie("I Am Legend", SCIFI);
            Movie movie19 = new Movie("Pocahontas", ANIMATED);
            Movie movie20 = new Movie("Aladdin", ANIMATED);

            List<string> movieTitles = new List<string> { };

            List<Movie> movieList = new List<Movie> {movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8,
                movie9, movie10, movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20};

            Console.WriteLine("Welcome to the Movie List Application!");
            AlphabetizeTitles(movieList, movieTitles);
            MainMenu(movieList, movieTitles);
        }
        public static void MainMenu(List<Movie> movieList, List<string> movieTitles)
        {
            Console.WriteLine($"There are {movieList.Count} movies in the List.");
            while (true)
            {
                string switchAnswer = GetInput("Would you like to view 1) Animated 2) Drama 3) SciFi or 4) Horror movies? ");
                Console.WriteLine(" ");

                switch (switchAnswer.ToLower())
                {
                    case "1":
                    case "animated":
                        DisplayList(movieList, ANIMATED, movieTitles);
                        break;
                    case "2":
                    case "drama":
                        DisplayList(movieList, DRAMA, movieTitles);
                        break;
                    case "3":
                    case "scifi":
                        DisplayList(movieList, SCIFI, movieTitles);
                        break;
                    case "4":
                    case "horror":
                        DisplayList(movieList, HORROR, movieTitles);
                        break;

                    default:
                        Console.WriteLine("That is not a valid selection, please try again.");
                        continue;
                }

                string endProgram = GetInput("Would you like to continue to the main menu?  Press Y to continue ");
                if (endProgram.ToUpper() != "Y")
                {
                    break;
                }
                Console.Clear();
            }
        }

        public static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void DisplayList(List<Movie> movieList, string category, List<string> movieTitles)
        {
            Console.WriteLine($"Movies in the {category} genre:");

            for (int i = 0; i < movieList.Count; i++)
            {
                foreach (Movie movie in movieList)
                {
                    if (movie.returnCategory(movie) == category && movie.returnTitle(movie) == movieTitles[i])
                    {
                        Console.WriteLine("{0, -20:0}", movie.returnTitle(movie));
                    }
                }
            }
            Console.WriteLine(" ");
        }

        public static void AlphabetizeTitles(List<Movie> movieList, List<string> movieTitles)
        {
            foreach (Movie movie in movieList)
            {   
                string entry = movie.returnTitle(movie);
                movieTitles.Add(entry);          
            }

            movieTitles.Sort();
        }
    }
}
