namespace ChessLib.Shared;

public class ChessBoard
{
    private readonly ChessCell[,] board;

    public ChessBoard()
    {
        board = GenerateBoard();
    }

    private ChessCell[,] GenerateBoard()
    {
        ChessCell[,] result = new ChessCell[8, 8];
        for (byte x = 0; x < 8; x++)
        {
            for (byte y = 0; y < 8; y++)
            {
                if ((x + y) % 2 == 0)
                {
                    result[x, y] = new ChessCell(Color.Black, new Coordinate(Coordinate.xCords[x], Coordinate.yCords[y]));
                }
                else
                {
                    result[x, y] = new ChessCell(Color.White, new Coordinate(Coordinate.xCords[x], Coordinate.yCords[y]));
                }
            }
        }

        return result;
    }

    public void AddFigureToBoard(ChessFigure figure)
    {
        byte figureY = figure.Coordinate.Y;
        char figureX = figure.Coordinate.X;


        foreach (ChessCell cell in board)
        {
            if (cell.Coordinate.X == figureX && cell.Coordinate.Y == figureY)
            {
                cell.Figure = figure;
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
                    Console.Write($"{Coordinate.yCords[y]} ");
                }
                else if (y == 8)
                {
                    Console.Write($"  {Coordinate.xCords[x - 1]}");
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