using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9A
{
    //Object Oriented Programming (Lập trình hướng đối tượng)
    internal class Movie
    {
        private string name;
        private string director;
        private int year;
        public double Revenue { get; set; }

        public Movie() { }

        public Movie (string name, string director, int y)
        {
            this.name = name;
            this.director = director;
            year = y;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDirector(string director) 
        {
            this.director = director;
        }

        public int getYear()
        {
            return year;
        }

        public void showMovieInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Director: " + director);
            Console.WriteLine("Year: " + this.year);
        }


    }
}
