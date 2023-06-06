    using System;
    using System.Security.Cryptography;

    public class Program
    {
        public static int userScore = 0;
        public static int computerScore = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Rock-Paper-Scissors");
            Console.WriteLine("-------------------");

            Console.WriteLine("Select the difficulty level");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.Write("Enter the difficulty level (1-3): ");

        int difficultyLevel = ReadDifficultyLevel();



        bool exit = false;
    while(!exit) {

            Console.Clear();


            Console.WriteLine("-------------------");
            Console.WriteLine("Rock-Paper-Scissors");
            Console.WriteLine("-------------------");

            Console.WriteLine("R. Rock");
            Console.WriteLine("P. Paper");
            Console.WriteLine("S. Scissors");
            Console.WriteLine("0. Exit");
            Console.Write("Make your choice (R/P/S): ");

            string userChoice = Console.ReadLine().ToUpper();
       
        
            if (userChoice == "0")
                {
                    exit = true;
                    Console.WriteLine("Exiting the game...");
                    break;
                }

            if (userChoice!="R" && userChoice!="P" && userChoice != "S")
            {
                Console.WriteLine("Invalid choice. Please enter R, P or S.");
                Console.WriteLine("Please Enter to continue...");
                Console.ReadLine();
                continue;
            }

            string computerChoice = GenerateComputerChoice(difficultyLevel,userChoice);

            Console.WriteLine("Your Choice: " + userChoice);
            Console.WriteLine("Computer Choice: " + computerChoice);

            string result = DetermineWinner(userChoice, computerChoice);
            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            if (result == "You Win!")
            {
                userScore++;
            }
            else if (result == "Computer wins!")
            {
                computerScore++;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Final Scores");
        Console.WriteLine("------------");
        Console.WriteLine("User Score: " + userScore);
        Console.WriteLine("Computer Score: " + computerScore);
        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();

    }

    public static int ReadDifficultyLevel()
    {
        while (true)
        {
            Console.Write("Enter the difficulty level (1-3): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int difficultylevel))
            {
                if (difficultylevel >= 1 && difficultylevel <= 3)
                {
                    return difficultylevel;
                }
            }
            Console.WriteLine("Invalid difficulty level. Please enter a number between 1 and 3.");
        }

        
    }


    public static string GenerateComputerChoice(int difficultyLevel, string userChoice)
        {
            Random random = new Random();

            // Easy level: Computer choses randomly

            if (difficultyLevel == 1)
            {
                int randomNumber = random.Next(1, 4);
                return GetChoiceFromNumber(randomNumber);
            }

            // Medium level: Computer tends to chose the winning choice
            else if (difficultyLevel == 2)
            {
                int randomNumber = random.Next(1, 101);

                if (randomNumber <= 60)
                {
                    // Choose winning choice
                    return GetWinningChoice(userChoice);
                }
                else
                {
                    // Choose random choice
                    randomNumber = random.Next(1, 4);
                    return GetChoiceFromNumber(randomNumber);
                }

            }

            // Hard level: Computer tried to predict the user's choice and counter it
            else if (difficultyLevel == 3)
            {
                // Implement your strategy for predicting and countering the user's choice
                // Example: If the user tends to choose "Rock," the computer chooses "Paper"
                // You can use conditional statements or a more advanced algorithm for this
                if (userChoice == "R")
                {
                    return "P";
                }
                else if (userChoice == "P")
                {
                    return "S";
                }
                else if (userChoice == "S")
                {
                    return "R";
                }
            }

            return " ";
        }

        static string GetChoiceFromNumber(int number)
        {
            switch (number)
            {
                case 1:
                    return "R";
                case 2:
                    return "P";
                case 3:
                    return "S";
                default:
                    return "";
            }
        }

        static string GetWinningChoice(string userChoice)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            string winningChoice = "";
            switch (userChoice)
            {
                case "R":
                    winningChoice= "P";
                    break;
                case "P":
                    winningChoice= "R";
                    break;
                case "S":
                    winningChoice = "R";
                    break;

            }
    

        // If the random number is 1, return the winning choice
        // Otherwise, return a random choice
        return randomNumber == 1 ? winningChoice : GetChoiceFromNumber(randomNumber);

        }


    public static string DetermineWinner(string userChoice, string computerChoice)
    {
        if (userChoice==computerChoice)
        {
            return "It's a tie!";
        }
    
        else if(
            (userChoice == "R" && computerChoice == "S") ||
            (userChoice == "P" && computerChoice == "R") ||
            (userChoice == "S"  && computerChoice == "P")
        )
        {
            return "You Win!";
        }
        else
        {
            return "Computer wins!";
        }
    }
    
}