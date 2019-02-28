using System;
using System.Windows;

namespace MovieList
{ 
    public class Movie
    {
       private string movieName;
       private int releaseYear;
        private string director;
        private int legnth;
        private string genre;
        public Movie (string name, int releaseYear, string director, int legnth, string genre)
        {
            this.movieName = name;
            this.releaseYear = releaseYear;
            this.director = director;
            this.legnth = legnth;
            this.genre = genre;
        }
        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear + Environment.NewLine + director + Environment.NewLine + legnth + Environment.NewLine + genre);
        }
    }
}
