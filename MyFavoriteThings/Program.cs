using MyFavoriteThings.FavoriteThings;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var StreetFighterP1 = new Games();
            StreetFighterP1.Choosing(Character.Ryu);

            var StreetFighterP2 = new Games();
            StreetFighterP2.Best = Character.Alex;

            StreetFighterP1.startFight(true);
            StreetFighterP2.startFight(false);

            var JapaneseArt = new Art("Japanese", "Asian", 500);
            var EuropeanArt = new Art("18th Century", "European", 700);
            
            JapaneseArt.Purchase(true);
            EuropeanArt.Purchase(false);
        }
    }
}
