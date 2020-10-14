using System;

namespace Goodson_Lab_3
{
    class Program
    {
        //method so I don't have to keep asking if they want to play again
        //I practiced these and arrays/lists on Edabit prior to bootcamp because I had too much free time on my hands :)

        static bool continueGame()
        {
            string userPlay;
            bool validInput = false;

            while (validInput == false)
            {
                Console.WriteLine($"\nWould you like to continue? Please enter 'y' for yes and 'n' for no:");
                userPlay = Console.ReadLine();

                if (userPlay.ToLower().Equals("y"))
                {
                    return false;
                }
                else if (userPlay.ToLower().Equals("n"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                    continue;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            
            bool endProgram = false;

            Console.WriteLine("Please provide your name: ");
            string userName = Console.ReadLine();

            while (endProgram == false)
            {
                endProgram = false;
                bool realInt = false; //validate userInput
                int userNum = 0;

                Console.WriteLine($"\nHi, {userName}! Please enter an integer between 1 and 100: ");
                string userInput = Console.ReadLine();

                //validate user input first to make sure it's a positive integer
                realInt = int.TryParse(userInput, out userNum);

                if (userNum <= 0 || userNum > 100 || realInt == false)
                {
                    Console.WriteLine($"\nSorry, {userName}, the number needs to be a positive whole number between 1 and 100");
                    continue;
                }

                //determine what will be output if userInput is positive integer between 1 and 100

                if (userNum % 2 != 0)
                {
                    Console.WriteLine($"\n{userName}, here are your results: {userNum} Odd");
                    endProgram = continueGame();
                    
                }
                else if (userNum%2==0 && userNum<=25 && userNum>=2)
                {
                    Console.WriteLine($"\n{userName}, here are your results: Even and less than 25");
                    endProgram = continueGame(); 
                }
                else if (userNum % 2 == 0 && userNum <= 60 && userNum >= 26)
                {
                    Console.WriteLine($"\n{userName}, here are your results: Even");
                    endProgram = continueGame();
                }
                else if (userNum % 2 == 0 && userNum > 60)
                {
                    Console.WriteLine($"\n{userName}, here are your results: {userNum} Even");
                    endProgram = continueGame();
                } 
                else if (userNum % 2 !=0 && userNum > 60)
                {
                    Console.WriteLine($"\n{userName}, here are your results: {userNum} Odd");
                    endProgram = continueGame();
                }
            }

            Console.WriteLine($"\nBYE, {userName}!");
        }
    }
}
