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

        public void Play()
        {
            if(Length > 2.5f)
            {
                Console.WriteLine($"You're now listening to {Title}, by an unanmed {Genre} band. Strap in, its going to be a long one.");
            }
            else
            {
                Console.WriteLine($"You're now listening to {Title}. We know this is your favorite kind of music, {Genre}. Its short and sweet!");
            }
        }
    }
}
