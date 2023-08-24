namespace ChessLib.Shared;

public abstract class ChessFigure
{
    public Color Color { get; init; }
    public Coordinate Coordinate { get; set; }

    protected readonly ChessBoard board;

    public ChessFigure(Color color, Coordinate coordinate, ChessBoard board)
    {
        Color = color;
        Coordinate = coordinate;
        this.board = board;
    }

    public abstract Coordinate[] GetPossibleMovesCoordinates();
}
