namespace ChessLib.Shared;

public class Queen : ChessFigure
{
    public Queen(Color color,(int,int) coords) : base(color,coords)
    {

    }

    public override string ToString() => "Q";
}