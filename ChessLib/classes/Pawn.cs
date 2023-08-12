namespace ChessLib.Shared;

public class Pawn : ChessFigure
{
    public Pawn(Color color,(int,int) coords) : base(color, coords)
    {

    }

    public override string ToString() => "P";
}