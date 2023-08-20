namespace ChessLib.Shared;

public class Knight : ChessFigure
{
    public Knight(Color color,Coordinate coordinates) : base(color,coordinates)
    {

    }

    public override string ToString() => "N";
}