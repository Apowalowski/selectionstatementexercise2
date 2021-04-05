using System;

namespace selectionstatementSwitch
{
    class Program
    {
        static void Main(string[] subject)
        {
            //exercise 2
            Console.WriteLine("What is your favorite subject?");
            string fave = Console.ReadLine();


            switch
                    (fave)
            {
                case "Math":
                    Console.WriteLine($"{fave}uses a lot of numbers.");
                    break;
                case "History":
                    Console.WriteLine($"{fave}talks about cool old stories.");
                    break;
                default:
                    Console.WriteLine($"school is neat.");
                    break;
            }











            //exercise 1
            var newRandom = 225;
            Console.WriteLine("Guess my random number");
            var guess = int.Parse(Console.ReadLine());

            if (guess < newRandom)
            {
                Console.WriteLine("Too low.Guess again");
            }
            else if (guess > newRandom)
            {
                Console.WriteLine("Too high.Guess again");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }


    }
}