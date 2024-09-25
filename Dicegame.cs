using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Player 1 name: ");
        string player1 = Console.ReadLine();

        Console.WriteLine("Play against another player? (type 'player')\nOr against the computer? (type 'computer')?"); // Input to know who player1 will play against.
        string choice = Console.ReadLine().ToLower();

        string player2; // future declaration of player2 depending on the user's choice
        bool isComputer = false; // bool to know if it's a computer or not

        if (choice == "player")
        {
            Console.WriteLine("Player 2 name: ");
            player2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome to the dice game, {player1} and {player2}.");
        }
        else
        {
            player2 = "Computer";
            isComputer = true;
            Console.WriteLine($"Welcome to the dice game, {player1}.");
        }

        Random random = new Random(); // random function for the dice
        int player1Points = 0;
        int player2Points = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Round number {i}, press any key to start."); // round counter
            Console.ReadKey();
            Console.WriteLine();

            int playerDice = random.Next(1, 7);
            int computerDice = random.Next(1, 7);

            if (isComputer == false) // if else for the loop with a real opponent
            {
                if (playerDice > computerDice)
                {
                    Console.WriteLine($"{player1} rolled {playerDice}, and {player2} rolled {computerDice}. {player1} won the round.");
                    player1Points++;
                }
                else if (playerDice < computerDice)
                {
                    Console.WriteLine($"{player1} rolled {playerDice}, and {player2} rolled {computerDice}. {player2} won the round.");
                    player2Points++;
                }
                else
                {
                    Console.WriteLine($"Both rolled {playerDice}. It's a tie.");
                }
                Console.WriteLine();
            }
            else
            {
                if (playerDice > computerDice)
                {
                    Console.WriteLine($"{player1} rolled {playerDice}, and {player2} rolled {computerDice}. {player1} won the round.");
                    player1Points++;
                }
                else if (playerDice < computerDice)
                {
                    Console.WriteLine($"{player1} rolled {playerDice}, and {player2} rolled {computerDice}. {player2} won the round.");
                    player2Points++;
                }
                else
                {
                    Console.WriteLine($"Both rolled {playerDice}. It's a tie.");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Final result: {player1}: {player1Points} points, and {player2}: {player2Points} points.");
        Console.ReadLine();
    }
}
