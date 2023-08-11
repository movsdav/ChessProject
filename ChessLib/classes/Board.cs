namespace ChessLib.Shared;

public class Board
{
    private readonly Square[,] board;

    public Board()
    {
        this.board = GenerateBoard();
    }

    private Square[,] GenerateBoard()
    {
        Square[,] result = new Square[8, 8];
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if ((x + y) % 2 == 0)
                {
                    result[x, y] = new Square(Color.Black);
                }
                else
                {
                    result[x, y] = new Square(Color.White);
                }
            }
        }

        return result;
    }

    public void PrintBoard()
    {
        Square square;

        string[] xCords = { "8", "7", "6", "5", "4", "3", "2", "1" };
        string[] yCords = { "A", "B", "C", "D", "E", "F", "G", "H" };

        for (int y = 0; y < 24; y++)
        {
            for (int x = 0; x < 25; x++)
            {
                if (x < 1)
                {
                    Console.Write(" A ");

                }
                else
                {
                    square = board[(x-1) / 3, y / 3];
                    square.PrintSquare();
                }



            }
            Console.WriteLine();


        }
        Console.WriteLine();
    }
}