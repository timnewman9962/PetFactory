using System;

namespace PetFactory
{
    class Program
    {
        class Gerbil : IPet
        {
            public void Companion()
            {
                Console.WriteLine("Making a new gerbil!");
            }
        }
        class Cat : IPet
        {
            public void Companion()
            {
                Console.WriteLine("Making a new cat!");
            }
        }
        class Dog : IPet
        {
            public void Companion()
            {
                Console.WriteLine("Making a new dog!");
            }
        }
        class PetFactory
        {
            public static IPet GetPet(string size)
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
