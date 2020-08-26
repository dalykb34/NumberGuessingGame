using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" What is your favorite school subject?");

            string userInput = Console.ReadLine();

            switch (userInput.ToLower()) 
            {
                case "physical education":
                    Console.WriteLine("Mine too!");
                    break;
                case "english":
                    Console.WriteLine("That is no fun.");
                    break;
                case "science":
                    Console.WriteLine("Let do an experiment!");
                        break;
                case "math":
                    Console.WriteLine("I would rather have Pi.");
                        break;
                case "art":
                    Console.WriteLine("Can you draw a picture of me?");
                        break;
                default:
                    Console.WriteLine("That is a new one!");
                    break;

            }

        }
    }
}
