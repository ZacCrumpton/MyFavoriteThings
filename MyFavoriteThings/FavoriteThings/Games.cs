using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Games
    {
        public bool isBeginner { get; set; }

        public Character Best  { get; set; }

        public void Choosing(Character best)
        {
            Best = best;
        }

        public void startFight()
        {
            if (isBeginner)
            {
                Console.WriteLine($"Hello i'm new to the game and have only played with a hand full of characters.");
            }
            else
            {
                Console.WriteLine($"Back in the saddle again. I'm going to choose {Best}. Lets get started!");
            }
        }

        

    }
        enum Character
        {
            Ryu = 1,
            Ken,
            Bison,
            Vega,
            Alex,
            Ibuki,
            Oro,
            Shawn
        }
}
