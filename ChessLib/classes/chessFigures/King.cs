namespace ChessLib.Shared;

public class King : ChessFigure
{
    public King(Color color, Coordinate coordinates) : base(color,coordinates)
    {

    }

    public override string ToString() => "K";
}
