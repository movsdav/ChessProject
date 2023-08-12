namespace ChessLib.Shared;

public abstract class ChessFigure
{
    public Color Color { get; init; }
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }

    public ChessFigure(Color color, (int, int) coords)
    {
        Color = color;
        XCoordinate = coords.Item1;
        YCoordinate = 7 - coords.Item2;
    }
}
