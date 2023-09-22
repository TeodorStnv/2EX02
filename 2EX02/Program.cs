namespace _2EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string TimeDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (TimeDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (TimeDay == "Afternoon" || TimeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (TimeDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (TimeDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (TimeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }


            }
            if (degrees >= 25)
            {
                if (TimeDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (TimeDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (TimeDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
           // string Message = "It's " + degrees + " degrees, get your " + outfit + " and " + " shoes .";
           // Console.WriteLine (Message);

               Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                
        }
    }
}