using System;
using System.Web;

namespace NumberGuess
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AppInfo();

            Greeting();

            //Play Again Loop
            while (true)
            {

                //Number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                //Guessing
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        ColorText(ConsoleColor.Red, "Please enter a number.");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} is incorrect, try again.", guess);
                        Console.ResetColor();
                    }
                }
                //Correct Answer
                ColorText(ConsoleColor.Blue, "Thats correct, great job.");

                //Play Again
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                } 
                else if (answer == "N")
                {
                    ColorText(ConsoleColor.Green, "Thanks for playing, have a nice day.");
                    return;
                }
                else
                {
                    Console.WriteLine("{0} is not a valid answer", answer);
                }

            }
        }

        static void AppInfo()
        {
            //App Info
            string appName = "Number Guess";
            string appVersion = "1.0.0";
            string appAuthor = "Thomas Crowe";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(appName);
            Console.WriteLine("Version: " + appVersion);
            Console.WriteLine("By: " + appAuthor);
            Console.ResetColor();
        }

        static void Greeting()
        {
            //User Info
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("What's up {0}, let's play a game.", inputName);
        }

        static void ColorText(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
