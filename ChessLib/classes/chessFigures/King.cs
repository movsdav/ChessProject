namespace ChessLib.Shared;

public class King : ChessFigure, IMovable
{
    public King(Color color, Coordinate coordinates,ChessBoard board) : base(color, coordinates, board)
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

            if (xCoordMoveLength <= 1 && yCoordMoveLength <= 1 && xCoordMoveLength + yCoordMoveLength != 0) result.Add(cellCoordinate);
        }

        return result.ToArray();
    }

    public void Move(Coordinate MoveCoordinate)
    {
        
    }

    public override string ToString() => "K";
}
