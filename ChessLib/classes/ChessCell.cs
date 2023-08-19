namespace ChessLib.Shared;

public class ChessCell
{
    private readonly Color color;
    private string placeholder = "   ";
    public ChessFigure? Figure { get; set; }

    public Coordinate Coordinate { get; init; }

    public ChessCell(Color color, Coordinate coordinate)
    {
        Coordinate = coordinate;
        this.color = color;
    }

    public ChessCell(Color color, Coordinate coordinate, ChessFigure figure) : this(color, coordinate)
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