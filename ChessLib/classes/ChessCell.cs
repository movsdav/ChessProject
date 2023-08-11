namespace ChessLib.Shared;

public class ChessCell
{
    private readonly Color color;
    private readonly string placeholder = "   ";
    private ChessFigure? figure;

    public string XCoordinate { get; init; }
    public string YCoordinate { get; init; }

    public ChessCell(Color color, (string, string) coods)
    {
        (XCoordinate, YCoordinate) = coods;
        this.color = color;
    }

    public ChessCell(Color color, (string, string) coods, ChessFigure figure) : this(color, coods)
    {
        this.figure = figure;
        this.placeholder = $" {this.figure} " ?? "   ";
    }

    public void DrawCell()
    {
        Console.BackgroundColor = this.color == Color.Black ? ConsoleColor.DarkCyan : ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(placeholder);
        Console.ResetColor();

    }
}