namespace ChessLib.Shared;

class Pawn : ChessFigure
{
    public Pawn(Color color) : base(color)
    {

    }

    public override string ToString() => "P";
}