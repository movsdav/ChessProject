namespace ChessLib.Shared;

public class Knight : ChessFigure
{
    public Knight(Color color, Coordinate coordinates,ChessBoard board) : base(color, coordinates,board)
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
                (xCoordMoveLength == 2 && yCoordMoveLength == 1) || (xCoordMoveLength == 1 && yCoordMoveLength == 2)
            ) result.Add(cellCoordinate);
        }

        return result.ToArray();
    }

    public override string ToString() => "N";
}