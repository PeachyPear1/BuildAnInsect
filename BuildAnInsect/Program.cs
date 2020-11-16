using System;

namespace BuildAnInsect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hannah Hamilton
            //Rhona Filgueras
            //Jack Gunther
            //Jonathan Gonzalez
            Console.WriteLine("Welcome to The Legend of Insects! What's your name?");
            Insect Insect1 = new Insect();
            Insect1.Name = "Gabe";
            Insect1.NumberofLegs = 8;
            Insect1.BreedingSeason = "Summer";
            Insect1.Diet = "Insects";
            Player Player1 = new Player();
            Player1.Name = Console.ReadLine();
            Console.WriteLine($"Hello {Player1.Name}!");
            Console.WriteLine($"Would like to adopt {Insect1.Name}?");
            string UserInput = Console.ReadLine();
            if (UserInput == "yes")
            {
                Player1.Adopt(Insect1);
            }
            else {
                Console.WriteLine("Too bad. :(");
                    }



            //Player1.Clothing = "Leather Armor";
            //Player1.HairColor = "Platinum Blonde";
            //Player1.Weapon = "Bow";
            //Player1.Height = 8;


        }
    }
}
