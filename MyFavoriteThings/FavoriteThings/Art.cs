using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Art
    {

        public string Style { get; set; }

        public string Culture { get; set; }

        public int Price { get; set; }

        public bool isAvailable { get; set; }

        public Art(string style, string culture, int price)
        {
            Style = style;
            Culture = culture;
            Price = price;

            Console.WriteLine($"{style} got instantiated");
            Console.WriteLine($"{culture} got instantiated");
            Console.WriteLine($"{price} got instantiated");
        }

        public void Purchase(bool isAvailable)
        {
            if (isAvailable)
            {
                Console.WriteLine($"This {Style} art style is common amongst {Culture} cultures. It can be purchased for {Price} dollars!");
            } else
            {
                Console.WriteLine($"This {Style} is common amongst {Culture} cultures. It has already been purchased for {Price} dollars.");
            }
        }

        public void Purchase()
        {
            Purchase(true);
        }

    }
}
