namespace ChessLib.Shared;

public class King : ChessFigure
{
    public King(Color color, (int,int) coords) : base(color,coords)
    {

    }

    public override string ToString() => "K";
}
