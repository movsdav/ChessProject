namespace ChessLib.Shared;

public class Rock : ChessFigure
{
    public Rock(Color color,(int,int) coords) : base(color,coords)
    {

    }

    public override string ToString() => "R";
}