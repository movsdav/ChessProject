using ChessLib.Shared;

RunProgramm();

int GetXCoordinate()
{
    int xCoord;
    while (true)
    {
        Console.WriteLine("Enter new figure X position(A-H): ");

        xCoord = Array.IndexOf(ChessBoard.yCords, Console.ReadLine());

        if (xCoord != -1) return xCoord;
        else Console.WriteLine("Invalid coordinate. Try again.");
    }
}

int GetYCoordinate()
{
    int yCoord;
    while (true)
    {
        Console.WriteLine("Enter new figure Y position(1-8): ");

        if (int.TryParse(Console.ReadLine(), out yCoord) && yCoord > 0 && yCoord < 9)
        {
            yCoord--;
            return yCoord;
        }
        else Console.WriteLine("Invalid coordinate. Try again.");
    }
}

Color GetColor()
{
    while (true)
    {
        Console.WriteLine("Enter new figure color: ");

        string? color = Console.ReadLine();

        if (color == "White") return Color.White;
        else if (color == "Black") return Color.Black;
        else Console.WriteLine("Invalid color. Try again. ");
    }
}

ChessFigure GetChessFigure(Color figureColor, (int, int) coords)
{
    while (true)
    {
        Console.WriteLine("Enter figure type: ");

        string? figureType = Console.ReadLine();

        switch (figureType)
        {
            case "Pawn":
                return new Pawn(figureColor, coords);
            case "Knight":
                return new Knight(figureColor, coords);
            case "Bishop":
                return new Bishop(figureColor, coords);
            case "Rock":
                return new Rock(figureColor, coords);
            case "Queen":
                return new Queen(figureColor, coords);
            case "King":
                return new King(figureColor, coords);
            default:
                Console.WriteLine("Invalid figure type. Try again. ");
                break;
        }
    }
}

void RunProgramm()
{
    ChessBoard board = new ChessBoard();

    board.DrawBoard();

    while (true)
    {
        Console.WriteLine("Do you want add new figure?(Yes/No - exit programm)");
        string? answer = Console.ReadLine();

        if (answer == "No") break;
        else if (answer == "Yes")
        {
            int xCoord = GetXCoordinate();
            int yCoord = GetYCoordinate();
            Color color = GetColor();
            ChessFigure? figure = GetChessFigure(color, (xCoord, yCoord));

            board.AddFigureToBoard(figure);
            board.DrawBoard();
        }
        else Console.WriteLine("Invalid answer. Try again");
    }
}