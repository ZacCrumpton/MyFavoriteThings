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

            StreetFighterP1.startFight();
            StreetFighterP2.startFight();
        }
    }
}
