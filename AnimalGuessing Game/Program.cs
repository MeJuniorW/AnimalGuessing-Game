using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGuessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            

            Animal giraffe = new Animal("giraffe", "savannah", "spots");
            Animal polarbear = new Animal("polarbear", "arctic", "white fur");
            Animal kingfisher = new Animal("kingfisher", "rainforest", "feathers");
            Animal clownfish = new Animal("clownfish", "ocean", "scales");

            List<Animal> animalsInZoo = new List<Animal>();
            animalsInZoo.Add(clownfish);
            animalsInZoo.Add(polarbear);
            animalsInZoo.Add(kingfisher);
            animalsInZoo.Add(giraffe);
            
            do
            {
                string[] listAnimal = new string[] { "giraffe", "polarbear", "kingfisher", "clownfish" };
                Random r = new Random();
                string randAnimal = listAnimal[r.Next(0, listAnimal.Length)];
                foreach (var animal in animalsInZoo)
                {
                    if (animal.name == randAnimal)
                    {
                        Console.WriteLine($"Animal lives in {animal.location} and has {animal.covering}");
                        Console.WriteLine("Guess the animal:");
                        string guess = Console.ReadLine();
                        if (guess == animal.name)
                        {
                            Console.WriteLine($"You are right! It is a {animal.name}");
                        }
                        else
                            Console.WriteLine($"Nope! It's a {animal.name}");
                    }
                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string s = Console.ReadLine();
                if (s == "y")
                    playAgain = true;
                else
                    break;
            } while (playAgain == true);
        }
    }
}
