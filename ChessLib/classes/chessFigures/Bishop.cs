namespace ChessLib.Shared;

public class Bishop : ChessFigure
{
    public Bishop(Color color,Coordinate coordinates) : base(color,coordinates)
    {

    }

    public override string ToString() => "B";
}