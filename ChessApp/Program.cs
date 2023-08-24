using ChessLib.Shared;

RunProgramm();

Coordinate GetCoordinates()
{
    while (true)
    {
        Console.Write("Enter coordinates: ");
        string? answer = Console.ReadLine();

        if (answer is not null && Coordinate.IsValidCoordinate(answer.ToUpper()))
        {
            return new Coordinate(answer.ToUpper());
        }
        else
        {
            Console.WriteLine("Please enter valid coordinates");
        }
    }
}

Color GetColor()
{
    while (true)
    {
        Console.Write("Enter new figure color(White/Black): ");

        string? color = Console.ReadLine();

        if (color == "White") return Color.White;
        else if (color == "Black") return Color.Black;
        else Console.WriteLine("Invalid color. Try again. ");
    }
}

string GetChessFigureType()
{
    while (true)
    {
        Console.Write("Enter figure type(King/Queen/Rock/Knight/Bishop/Pawn): ");

        string? figureType = Console.ReadLine();

        switch (figureType)
        {
            case "Pawn":
            case "Knight":
            case "Bishop":
            case "Rock":
            case "Queen":
            case "King":
                return figureType;
            default:
                Console.WriteLine("Invalid figure type. Try again. ");
                break;
        }

    }
}

ChessFigure? CreateChessFigure(string figureType, Color figureColor, Coordinate coordinate, ChessBoard board)
{
    switch (figureType)
    {
        case "Pawn":
            return new Pawn(figureColor, coordinate, board);
        case "Knight":
            return new Knight(figureColor, coordinate, board);
        case "Bishop":
            return new Bishop(figureColor, coordinate, board);
        case "Rock":
            return new Rock(figureColor, coordinate, board);
        case "Queen":
            return new Queen(figureColor, coordinate, board);
        case "King":
            return new King(figureColor, coordinate, board);
        default:
            return null;
    }
}

void RunProgramm()
{
    ChessBoard board = new ChessBoard();

    board.DrawBoard();

    while (true)
    {
        Console.Write("Do you want add new figure?(Yes/No - exit programm): ");
        string? answer = Console.ReadLine();

        if (answer == "No") break;
        else if (answer == "Yes")
        {
            Coordinate coordinate = GetCoordinates();
            Color color = GetColor();
            ChessFigure? figure = CreateChessFigure(GetChessFigureType(), color, coordinate, board);

            board.AddFigureToBoard(figure!);
            board.DrawBoard();
        }
        else Console.WriteLine("Invalid answer. Try again");
    }
}