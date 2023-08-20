namespace ChessLib.Shared;

public abstract class ChessFigure
{
    public Color Color { get; init; }
    public Coordinate Coordinate { get; set; }

    public ChessFigure(Color color, Coordinate coordinates)
    {
        Color = color;
        Coordinate = coordinates;
    }
}
