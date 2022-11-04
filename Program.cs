public class Program
{
    private static long completedMovements;
    private static int soleKnightMoveCompleted;

    private static string[,] board = new string[5,5]
    {
        {"a","b","c","","e" },
        {"","g","h","i","j" },
        {"k","l","m","n","o" },
        {"p","q","r","s","t" },
        {"u","v","","","y" }
    };

    public static void Main(string[] args)
    {
        SolveMatrix();
    }

    private static long SolveMatrix()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                Console.WriteLine("----------Index board round: { " + i + "," + y + "}---------");
                if (UpRight(i, y) && UpLeft(i, y) && DownRight(i, y) && DownLeft(i, y) && RightUp(i, y) && RightDown(i, y) && LeftUp(i, y) && LeftDown(i, y))
                {
                    completedMovements++;
                }
                Console.WriteLine("----------End round: { " + i + "," + y + "}. Total Solo Movements Completed: " + soleKnightMoveCompleted + " ---------");
                soleKnightMoveCompleted = 0;
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        Console.WriteLine("Amount of 8 movements completed: "+ completedMovements);
        return completedMovements;
    }

    private static bool isValidMove(string position)
    {
        return string.IsNullOrEmpty(position) ? false : true; 
    }

    private static bool isVowel(string position)
    {
        return (position.Equals("a") && position.Equals("e") && position.Equals("i") && position.Equals("o") && position.Equals("u") && position.Equals("y")) ? false : true;
    }

    private static bool DownRight(int row, int col)
    {
        int colcount = 1;
        int rowcount = 2;
        int vowelcount = 0;
        bool failKnightMove = true;

        if (rowcount + row < board.GetLength(0) && colcount + col < board.GetLength(1))
        {
            if (isValidMove(board[row + 1, col]))
            {
                if (isVowel(board[row + 1, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownRight));
                return false;
            }

            if (isValidMove(board[row + rowcount, col]))
            {
                if (isVowel(board[row + rowcount, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownRight));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownRight));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownRight));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownRight));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool DownLeft(int row, int col)
    {
        int colcount = -1;
        int rowcount = 2;
        int vowelcount = 0;
        bool failKnightMove = true;

        if (rowcount + row < board.GetLength(0) && (colcount + col >= 0 && colcount + col < board.GetLength(1)))
        {
            if (isValidMove(board[row + 1, col]))
            {
                if (isVowel(board[row + 1, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownLeft));
                return false;
            }

            if (isValidMove(board[row + rowcount, col]))
            {
                if (isVowel(board[row + rowcount, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownLeft));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownLeft));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move Fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownLeft));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(DownLeft));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool UpRight(int row, int col)
    {
        int colcount = 1;
        int rowcount = -2;
        int vowelcount = 0;
        bool failKnightMove = true;

        if ((rowcount + row >= 0 && rowcount + row < board.GetLength(0)) && colcount + col < board.GetLength(1))
        {
            if (isValidMove(board[row - 1, col]))
            {
                if (isVowel(board[row - 1, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpRight));
                return false;
            }

            if (isValidMove(board[row + rowcount, col]))
            {
                if (isVowel(board[row + rowcount, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpRight));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpRight));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpRight));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpRight));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool UpLeft(int row, int col)
    {
        int colcount = -1;
        int rowcount = -2;
        int vowelcount = 0;
        bool failKnightMove = true;

        if ((rowcount + row >= 0 && rowcount + row < board.GetLength(0)) && (colcount + col >= 0 && colcount + col < board.GetLength(1)))
        {
            if (isValidMove(board[row - 1, col]))
            {
                if (isVowel(board[row - 1, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpLeft));
                return false;
            }

            if (isValidMove(board[row + rowcount, col]))
            {
                if (isVowel(board[row + rowcount, col]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpLeft));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpLeft));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpLeft));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(UpLeft));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool RightUp(int row, int col)
    {
        int colcount = 2;
        int rowcount = 1;
        int vowelcount = 0;
        bool failKnightMove = true;

        if (rowcount + row < board.GetLength(0) && colcount + col < board.GetLength(1))
        {
            if (isValidMove(board[row, col + 1]))
            {
                if (isVowel(board[row, col + 1]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightUp));
                return false;
            }

            if (isValidMove(board[row, col + colcount]))
            {
                if (isVowel(board[row, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightUp));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightUp));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightUp));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightUp));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool RightDown(int row, int col)
    {
        int colcount = 2;
        int rowcount = -1;
        int vowelcount = 0;
        bool failKnightMove = true;

        if ((rowcount + row >= 0 && rowcount + row < board.GetLength(0)) && colcount + col < board.GetLength(1))
        {
            if (isValidMove(board[row, col + 1]))
            {
                if (isVowel(board[row, col + 1]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightDown));
                return false;
            }

            if (isValidMove(board[row, col + colcount]))
            {
                if (isVowel(board[row, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightDown));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightDown));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightDown));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(RightDown));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool LeftUp(int row, int col)
    {
        int colcount = -2;
        int rowcount = 1;
        int vowelcount = 0;
        bool failKnightMove = true;

        if (rowcount + row < board.GetLength(0) && (colcount + col >= 0 && colcount + col < board.GetLength(1)))
        {
            if (isValidMove(board[row, col - 1]))
            {
                if (isVowel(board[row, col - 1]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftUp));
                return false;
            }

            if (isValidMove(board[row, col + colcount]))
            {
                if (isVowel(board[row, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftUp));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftUp));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftUp));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftUp));
            soleKnightMoveCompleted++;
            return true;
        }
    }

    private static bool LeftDown(int row, int col)
    {
        int colcount = -2;
        int rowcount = -1;
        int vowelcount = 0;
        bool failKnightMove = true;

        if ((rowcount + row >= 0 && rowcount + row < board.GetLength(0)) && (colcount + col >= 0 && colcount + col < board.GetLength(1)))
        {
            if (isValidMove(board[row, col - 1]))
            {
                if (isVowel(board[row, col - 1]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftDown));
                return false;
            }

            if (isValidMove(board[row, col + colcount]))
            {
                if (isVowel(board[row, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftDown));
                return false;
            }

            if (isValidMove(board[row + rowcount, col + colcount]))
            {
                if (isVowel(board[row + rowcount, col + colcount]))
                {
                    vowelcount++;
                }
                failKnightMove = false;
            }
            else
            {
                Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftDown));
                return false;
            }
        }

        if (failKnightMove || vowelcount < 2)
        {
            Console.WriteLine("Knight move fail from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftDown));
            return false;
        }
        else
        {
            Console.WriteLine("Knight move completed from position [" + board[row, col] + ", {" + row + "," + col + "}] addressing " + nameof(LeftDown));
            soleKnightMoveCompleted++;
            return true;
        }
    }
}