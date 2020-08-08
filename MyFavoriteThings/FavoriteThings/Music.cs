using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Music
    {
        public string Genre { get; set; }

        public string Title { get; set; }

        public float Length { get; set; }

        public Music(string genre, string title, float length)
        {
            Genre = genre;
            Title = title;
            Length = length;

            Console.WriteLine($"{genre} is instantiated");
            Console.WriteLine($"{title} is instantiated");
            Console.WriteLine($"{length} is instantiated");
        }
    }
}
