namespace ChessLib.Shared;

public class Knight : ChessFigure
{
    public Knight(Color color, Coordinate coordinates, ChessBoard board) : base(color, coordinates, board)
    {
    }


    public int GetMinimalRequiredMoves(Coordinate targetCell)
    {
        int k = 1;
        bool canMove = true;
        bool finish = false;

        board[Coordinate].numberToReach = k;
        board[targetCell].numberToReach = 999;

        void Step(Coordinate coord)
        {
            ChessCell currentCell = board[coord];

            if (currentCell.numberToReach == 999)
            {
                finish = true;
            }
            else if (currentCell.numberToReach == 0)
            {
                canMove = true;
                currentCell.numberToReach = k + 1;
            }
        }

        while (canMove)
        {
            canMove = false;

            foreach (ChessCell cell in board.Board)
            {
                if (cell.numberToReach == k)
                {
                    Coordinate[] possibleMoves = GetPossibleMovesCoordinates(cell.,board);
                    foreach (Coordinate move in possibleMoves)
                    {
                        Step(move);
                    }
                }
            }

            if (finish) return k;

            k++;
        }

        foreach (var cell in board.Board)
        {
            Console.WriteLine($"{cell.Coordinate}: {cell.numberToReach}, k: {k}");
        }

        return -1;
    }

    public override Coordinate[] GetPossibleMovesCoordinates()
    {
        List<Coordinate> result = new List<Coordinate>();

        Coordinate figureCoordinate = Coordinate;

        int xCoordMoveLength;
        int yCoordMoveLength;
        Coordinate cellCoordinate;
        foreach (ChessCell cell in board.Board)
        {
            cellCoordinate = cell.Coordinate;

            xCoordMoveLength = Math.Abs(figureCoordinate.X - cellCoordinate.X);
            yCoordMoveLength = Math.Abs(figureCoordinate.Y - cellCoordinate.Y);

            if (
                (xCoordMoveLength == 2 && yCoordMoveLength == 1) || (xCoordMoveLength == 1 && yCoordMoveLength == 2)
            ) result.Add(cellCoordinate);
        }

        return result.ToArray();
    }

    private Coordinate[] GetPossibleMovesCoordinates(Coordinate coordinate, ChessBoard board)
    {
        List<Coordinate> result = new List<Coordinate>();

        Coordinate figureCoordinate = coordinate;

        int xCoordMoveLength;
        int yCoordMoveLength;
        Coordinate cellCoordinate;
        foreach (ChessCell cell in board.Board)
        {
            cellCoordinate = cell.Coordinate;

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