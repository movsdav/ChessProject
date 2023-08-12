namespace ChessLib.Shared;

public class ChessBoard
{
    public static string[] xCords = { "8", "7", "6", "5", "4", "3", "2", "1" };
    public static string[] yCords = { "A", "B", "C", "D", "E", "F", "G", "H" };

    private readonly ChessCell[,] board;

    public ChessBoard()
    {
        this.board = GenerateBoard();
    }

    private ChessCell[,] GenerateBoard()
    {
        ChessCell[,] result = new ChessCell[8, 8];
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if ((x + y) % 2 == 0)
                {
                    result[x, y] = new ChessCell(Color.Black, (x + 1, y + 1));
                }
                else
                {
                    result[x, y] = new ChessCell(Color.White, (x + 1, y + 1));
                }
            }
        }

        return result;
    }

    public void AddFigureToBoard(ChessFigure figure)
    {
        int figureX = figure.XCoordinate;
        int figureY = figure.YCoordinate;

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if (x == figureX && y == figureY)
                {
                    board[x, y].Figure = figure;
                }
            }
        }
    }

    public void DrawBoard()
    {
        ChessCell square;

        for (int y = 0; y < 9; y++)
        {
            for (int x = 0; x < 9; x++)
            {
                if (x == 0 && y == 8)
                {
                    Console.Write(" ");
                    continue;
                }

                if (x == 0)
                {
                    Console.Write($"{xCords[y]} ");
                }
                else if (y == 8)
                {
                    Console.Write($"  {yCords[x - 1]}");
                }
                else
                {
                    square = board[x - 1, y];
                    square.DrawCell();
                }
            }
            Console.WriteLine();


        }
        Console.WriteLine();
    }
}