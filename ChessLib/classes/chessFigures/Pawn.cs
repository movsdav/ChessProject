namespace ChessLib.Shared;

public class Pawn : ChessFigure
{
    private bool canGoTwoSquares = false;

    public Pawn(Color color, Coordinate coordinates,ChessBoard board) : base(color, coordinates, board)
    {
        if (color == Color.White && coordinates.Y == 2 || color == Color.Black && Coordinate.Y == 7) canGoTwoSquares = true;
    }

    public override Coordinate[] GetPossibleMovesCoordinates()
    {
        List<Coordinate> result = new List<Coordinate>();

        Coordinate figureCoordinate = Coordinate;

        int yCoordMoveLength;
        int xCoordMoveLength;
        Coordinate cellCoordinate;

        int twoSquaresMove = canGoTwoSquares ? 1 : 0;

        foreach (ChessCell coord in board.Board)
        {
            cellCoordinate = coord.Coordinate;

            yCoordMoveLength = cellCoordinate.Y - figureCoordinate.Y;
            xCoordMoveLength = Math.Abs(figureCoordinate.X - cellCoordinate.X);

            if (
                (Color == Color.White &&
                xCoordMoveLength == 0 &&
                yCoordMoveLength > 0 &&
                yCoordMoveLength <= 1 + twoSquaresMove)
                 ||
                (Color == Color.Black
                && xCoordMoveLength == 0
                && yCoordMoveLength < 0
                && yCoordMoveLength >= -1 - twoSquaresMove))
                result.Add(cellCoordinate);
        }

        return result.ToArray();
    }

    public override string ToString() => "P";
}