namespace ChessLib.Shared;

public abstract class ChessFigure
{
    public Color Color { get; init;}

    public ChessFigure(Color color)
    {
        Color = color;
    }
}
