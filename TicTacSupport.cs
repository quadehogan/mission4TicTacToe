namespace mission4TicTacToe;

public class TicTacSupport
{
    public string PrintBoard(string[] board)
    {
        string boardString = "";

        for (int i = 0; i < board.Length; i++)
        {
            if (i == 0 || i== 1 || i == 3 || i == 4 || i == 6 || i == 7)
            {
                boardString += board[i];
                boardString += " | ";
            }

            if (i == 2 || i == 5)
            {
                boardString += board[i];
                boardString += "\n";
                boardString += "----------\n";
            }

            if (i == 8)
            {
                boardString += board[i];
            }
        }
        return boardString;
    }

    public string CheckWin(string[] board)
    {
        bool xWin = false;
        bool oWin = false;
        string win = "None";
        
        string xInput = "X";
        string oInput = "O";

        if (board[0] == board[1] && board[1] == board[2])
        {
            if (board[0] == xInput)
            {
                xWin = true;
            }

            if (board[0] == oInput)
            {
                oWin = true;
            }
        }
        if (board[3] == board[4] && board[4] == board[5])
        {
            if (board[3] == xInput)
            {
                xWin = true;
            }

            if (board[3] == oInput)
            {
                oWin = true;
            }
        }
        if (board[6] == board[7] && board[7] == board[8])
        {
            if (board[6] == xInput)
            {
                xWin = true;
            }

            if (board[6] == oInput)
            {
                oWin = true;
            }
        }
        if (board[0] == board[3] && board[3] == board[6])
        {
            if (board[0] == xInput)
            {
                xWin = true;
            }

            if (board[0] == oInput)
            {
                oWin = true;
            }
        }
        if (board[1] == board[4] && board[4] == board[7])
        {
            if (board[1] == xInput)
            {
                xWin = true;
            }

            if (board[1] == oInput)
            {
                oWin = true;
            }
        }
        if (board[2] == board[5] && board[5] == board[8])
        {
            if (board[2] == xInput)
            {
                xWin = true;
            }

            if (board[2] == oInput)
            {
                oWin = true;
            }
        }
        if (board[0] == board[4] && board[4] == board[8])
        {
            if (board[0] == xInput)
            {
                xWin = true;
            }

            if (board[0] == oInput)
            {
                oWin = true;
            }
        }
        if (board[2] == board[4] && board[4] == board[6])
        {
            if (board[2] == xInput)
            {
                xWin = true;
            }

            if (board[2] == oInput)
            {
                oWin = true;
            }
        }

        if (xWin)
        {
            win = "X";
        }
        else if (oWin)
        {
            win = "O";
        }
        
        if(!xWin && !oWin)
        {
            int filledSpaces = 0;
            
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == "X" || board[i] == "O")
                {
                    filledSpaces++;
                }
            }

            if (filledSpaces == 9)
            {
                win = "Tie";
            }
        }

        return win;
    }
    
}