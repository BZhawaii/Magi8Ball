using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Magi8Ball
{

    /// <summary>
    /// Entry point for Magic 8 Ball program (By Richard Beese)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();


            // Create a randomizer object
            Random randomObject = new Random();


            while (true)
            {

                string questionString = GetQuestionFromUser();

                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking about your answer, stand by..");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                // Check to make sure there is a question
                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question fool!");
                    continue;
                }

                // If the user insults with 'you suck' smack them
                if(questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more!  Fuck off!");
                    break;
                }

                // See if the user typed 'quit' as the question
                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                // Get a random number
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                

                // Use random number to determine response
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG YES!");
                            break;
                        }
                }

            }  // End of while loop

            // Cleaning up
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// This will print the name of the program and who created it
        /// </summary>
        static void TellPeopleWhatProgramThisIs()
        {
            //Change console text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Magic");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 8 Ball (by: Richard Beese)");
        }

        /// <summary>
        /// This function will return the text the user types
        /// </summary>
        /// <returns></returns>
        static string GetQuestionFromUser()
        {
            // This block of code will ask eht user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question? (type 'quit' to exit): ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
