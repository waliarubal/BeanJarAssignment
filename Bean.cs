using System;

namespace BeanieApplication
{
    public enum BeanColor
    {
        Pink,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Brown,
        Black,
        White
    }

    public enum BeanFlavor
    {
        CottonCandy,
        Cherry,
        MandarinOrange,
        Lemon,
        Melon,
        Blueberry,
        Grape,
        RootBeer,
        Licorice,
        Popcorn
    }

    public class Bean
    {
        public Bean()
        {
            var random = new Random();

            var colorCount = Enum.GetValues(typeof(BeanColor)).Length;

            Color = (BeanColor)Enum.ToObject(typeof(BeanColor), random.Next(0, colorCount)); // generate random color bean
            Flavor = (BeanFlavor)Enum.ToObject(typeof(BeanFlavor), (int)Color); //one to one color matching with flavor
        }

        public BeanColor Color { get; set; }

        public BeanFlavor Flavor { get; }

        public override string ToString()
        {
            return $"{Color} - {Flavor}";
        }
    }
}
