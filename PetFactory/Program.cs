using System;

namespace PetFactory
{
    class Program
    {
        class Gerbil : Pet
        {
            public override void  Companion()
            {
                Console.WriteLine("Making a new gerbil!");
            }
        }
        class Cat : Pet
        {
            public override void Companion()
            {
                Console.WriteLine("Making a new cat!");
            }
        }
        class Dog : Pet
        {
            public override void Companion()
            {
                Console.WriteLine("Making a new dog!");
            }
        }
        class PetFactory
        {
            public static Pet GetPet(string size)
            {
                switch(size.ToLower())
                {
                    case "small": return new Gerbil();
                    case "medium": return new Cat();
                    case "large": return new Dog();
                    default: return null;
                }
            }
        }

        static void Main(string[] args)
        {
            bool quit = false;
            do
            {
                Console.WriteLine("What size of pet do you prefer (small, medium, large)?");
                string petSize = Console.ReadLine();

                var myPet = PetFactory.GetPet(petSize);
                if (myPet != null)
                    myPet.Companion();
                else
                    quit = true;
            }
            while (quit == false);

            Console.WriteLine("Finished making pets");
        }
    }
}
