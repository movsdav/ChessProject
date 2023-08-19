namespace ChessLib.Shared;

public class Queen : ChessFigure
{
    public Queen(Color color,Coordinate coordinates) : base(color,coordinates)
    {

    }

    public override string ToString() => "Q";
}