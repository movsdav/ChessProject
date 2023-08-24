namespace ChessLib.Shared;

public class Rock : ChessFigure
{
    public Rock(Color color, Coordinate coordinates,ChessBoard board) : base(color, coordinates, board)
    {

    }

    public override Coordinate[] GetPossibleMovesCoordinates()
    {
        List<Coordinate> result = new List<Coordinate>();

        Coordinate figureCoordinate = Coordinate;

        int xCoordMoveLength;
        int yCoordMoveLength;
        Coordinate cellCoordinate;
        foreach (ChessCell coord in board.Board)
        {
            cellCoordinate = coord.Coordinate;

            xCoordMoveLength = Math.Abs(figureCoordinate.X - cellCoordinate.X);
            yCoordMoveLength = Math.Abs(figureCoordinate.Y - cellCoordinate.Y);

            if (
                    (xCoordMoveLength > 0 && yCoordMoveLength == 0) || (yCoordMoveLength > 0 && xCoordMoveLength == 0)
                ) result.Add(cellCoordinate);
        }

        return result.ToArray();
    }

    public override string ToString() => "R";
}