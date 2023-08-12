namespace ChessLib.Shared;

public class Bishop : ChessFigure
{
    public Bishop(Color color,(int,int) coords) : base(color,coords)
    {

    }

    public override string ToString() => "B";
}