namespace ChessLib.Shared;

public class ChessCell
{
    private readonly Color color;
    private string placeholder = "   ";
    public ChessFigure? Figure { get; set; }

    public int XCoordinate { get; init; }
    public int YCoordinate { get; init; }

    public ChessCell(Color color, (int, int) cords)
    {
        XCoordinate = cords.Item1;
        YCoordinate = 7 - cords.Item2;
        this.color = color;
    }

    public ChessCell(Color color, (int, int) coods, ChessFigure figure) : this(color, coods)
    {
        Figure = figure;
    }

    public void DrawCell()
    {
        if (Figure is not null)
        {
            placeholder = $" {Figure} ";
            Console.ForegroundColor = Figure.Color == Color.Black ? ConsoleColor.Black : ConsoleColor.White;
        }
        Console.BackgroundColor = color == Color.Black ? ConsoleColor.Blue : ConsoleColor.DarkGray;

        Console.Write(placeholder);
        Console.ResetColor();

    }
}