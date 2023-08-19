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
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if ((x + y) % 2 == 0)
                {
                    result[x, y] = new ChessCell(Color.Black, new Coordinate(x + 1, y + 1));
                }
                else
                {
                    result[x, y] = new ChessCell(Color.White, new Coordinate(x + 1, y + 1));
                }
            }
        }

        return result;
    }

    public void AddFigureToBoard(ChessFigure figure)
    {
        int figureY = figure.Coordinate.X;
        int figureX = figure.Coordinate.Y;

        foreach(ChessCell cell in board){
            if(cell.Coordinate.X == figureX && cell.Coordinate.Y == figureY){
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
                    Console.Write($"{Enumerable.Reverse(Coordinate.xCords).ToArray()[y]} ");
                }
                else if (y == 8)
                {
                    Console.Write($"  {Coordinate.yCords[x - 1]}");
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