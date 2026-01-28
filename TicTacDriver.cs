namespace mission4TicTacToe;

public class TicTacDriver
{
    public void Run()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (true)
        {
            int menuChoice = GetMenuChoice();
            if (menuChoice == 2)
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            PlayGame();
        }
    }

    private void PlayGame()
    {
        string[] board = new string[9];
        TicTacSupport support = new TicTacSupport();
        string currentPlayer = "X";
        string winner = "None";

        Console.WriteLine(support.PrintBoard(board));

        while (winner == "None")
        {
            int choice = GetChoice(board, currentPlayer);
            board[choice - 1] = currentPlayer;

            Console.WriteLine(support.PrintBoard(board));

            winner = support.CheckWin(board);
            if (winner != "None")
            {
                break;
            }

            currentPlayer = currentPlayer == "X" ? "O" : "X";
        }

        if (winner == "Tie")
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            string playerLabel = winner == "X" ? "Player 1" : "Player 2";
            Console.WriteLine($"{playerLabel} wins!");
        }
    }

    private int GetMenuChoice()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice == 1 || choice == 2))
            {
                return choice;
            }

            Console.WriteLine("Invalid choice. Enter 1 or 2.");
        }
    }

    private int GetChoice(string[] board, string player)
    {
        while (true)
        {
            Console.Write($"Player {player}, choose a square (1-9): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 9)
            {
                int index = choice - 1;
                if (board[index] != "X" && board[index] != "O")
                {
                    return choice;
                }

                Console.WriteLine("That square is already taken. Try again.");
                continue;
            }

            Console.WriteLine("Invalid input. Enter a number from 1 to 9.");
        }
    }
}
