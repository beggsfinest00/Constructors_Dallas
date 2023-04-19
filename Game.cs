using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Dallas
{
    class Game
    {
        //makes a baking feild of title and genre
        public string title, genre;

        //sets title to unknown title, sets genre to casual
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") 
        {
            //makes title equal to prvious asignment 
            title = titleParam;
            //makes genre equal to prvious asignment
            genre = genreParam;
        }
    }
}
