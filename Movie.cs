using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Lecture_Example___Classes
{
    public class Movie
    {
        public string movieName;
        public double movieRating;
        public string director;
        public int year;

        public Movie(string movieName, double movieRating, string director, int year)
        {
            this.movieName = movieName;
            this.movieRating = movieRating;
            this.director = director;
            this.year = year;
        }

        public Movie(string movieName, double movieRating)
        {
            this.movieName = movieName;
            this.movieRating = movieRating;            
        }

        public string MovieName { get => movieName; set => movieName = value; }
        public double MovieRating { get => movieRating; set => movieRating = value; }
        public string Director { get => director; set => director = value; }
        public int Year { get => year; set => year = value; }
    }       
}
