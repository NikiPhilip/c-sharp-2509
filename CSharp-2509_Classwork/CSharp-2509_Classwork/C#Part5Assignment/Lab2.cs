//Define a Movie class with properties like Title and Year. Create a MovieLibrary class
//that stores an array of Movie objects and displays each movie’s information. 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class Movie
    {
        //properties for movie class
        public string Title;
        public int year;

        //constructor
        public Movie(string title, int year)
        {
            Title = title;
            this.year = year;
        }

        //Method for displaying movie information
        public void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title},Year:{year}");
        }
    }
    public class MovieLibrary
    {
        private Movie[] movies;
        private int count = 0;

        //constructor to initilaize movie library with size
        public MovieLibrary(int size)
        {
            movies = new Movie[size];
            count = 0;
        }

        //method for adding movie
        public void Addmovie(Movie movie)
        {
            if (count < movies.Length)
            {
                movies[count] = movie;
                count++;
                Console.WriteLine($"Added movie {movie.Title}");
            }
            else
            {
                Console.WriteLine("Movie library is full.Can't add more movies");
            }

        }

        //method to display all movie infromation
        public void Displaymovies()
        {
            Console.WriteLine("Movies in the movie library are");
            for (int i = 0; i < count; i++)
            {
                movies[i].DisplayInfo();
            }
        }
    }

}
