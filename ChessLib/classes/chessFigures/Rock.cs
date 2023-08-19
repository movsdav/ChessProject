namespace ChessLib.Shared;

public class Rock : ChessFigure
{
    public Rock(Color color,Coordinate coordinates) : base(color,coordinates)
    {

    }

    public override string ToString() => "R";
}