namespace ChessLib.Shared;

public class Knight : ChessFigure
{
    public Knight(Color color,(int,int) coords) : base(color,coords)
    {

    }

    public override string ToString() => "k";
}