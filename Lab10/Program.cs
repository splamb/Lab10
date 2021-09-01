using System;
using System.Collections.Generic;
namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = "y";

            var alien = new Movie("Alien", "horror");
            var benjaminButton = new Movie("The Curious Case of Benjamin Button", "drama");
            var starWars = new Movie("Star Wars Episode IV: A New Hope", "scifi");
            var cars = new Movie("Cars", "animated");
            var insidious = new Movie("Insidious", "horror");
            var casablanca = new Movie("Casablanca", "drama");
            var dune = new Movie("Dune", "scifi");
            var toyStory = new Movie("Toy Story", "animated");
            var angryMen = new Movie("12 Angry Men", "drama");
            var theMatrix = new Movie("The Matrix", "scifi");

            List<Movie> movies = new List<Movie>();
            movies.Add(alien);
            movies.Add(benjaminButton);
            movies.Add(starWars);
            movies.Add(cars);
            movies.Add(insidious);
            movies.Add(casablanca);
            movies.Add(dune);
            movies.Add(toyStory);
            movies.Add(angryMen);
            movies.Add(theMatrix);

            Console.WriteLine("Welcome to Sean's movie list!");

            while(cont == "y")
            {
                Console.WriteLine("Please input a genre type:");
                string genre = Console.ReadLine().ToLower();

                List<string> outputMovies = new List<string>();
                foreach(Movie movie in movies)
                {
                    if(movie.Category == genre)
                    {
                        outputMovies.Add(movie.Title);
                    }
                }

                if(outputMovies.Count >= 1)
                {
                    for(int i=0; i < outputMovies.Count; i++)
                    {
                        Console.WriteLine(outputMovies[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Your input was invalid.");
                }
                Console.WriteLine("Would you like to try again? (y/n)");
                cont = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Thank you for using our software. Have a wonderful day!");
        }
    }
}
