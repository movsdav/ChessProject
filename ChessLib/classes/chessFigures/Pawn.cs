namespace ChessLib.Shared;

public class Pawn : ChessFigure
{
    public Pawn(Color color,Coordinate coordinates) : base(color, coordinates)
    {

    }

    public override string ToString() => "P";
}