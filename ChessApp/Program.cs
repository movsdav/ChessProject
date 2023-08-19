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
        Console.WriteLine("Enter new figure color: ");

        string? color = Console.ReadLine();

        if (color == "White") return Color.White;
        else if (color == "Black") return Color.Black;
        else Console.WriteLine("Invalid color. Try again. ");
    }
}

ChessFigure GetChessFigure(Color figureColor, Coordinate coordinate)
{
    while (true)
    {
        Console.WriteLine("Enter figure type: ");

        string? figureType = Console.ReadLine();

        switch (figureType)
        {
            case "Pawn":
                return new Pawn(figureColor, coordinate);
            case "Knight":
                return new Knight(figureColor, coordinate);
            case "Bishop":
                return new Bishop(figureColor, coordinate);
            case "Rock":
                return new Rock(figureColor, coordinate);
            case "Queen":
                return new Queen(figureColor, coordinate);
            case "King":
                return new King(figureColor, coordinate);
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
            Coordinate coordinate = GetCoordinates();
            Color color = GetColor();
            ChessFigure? figure = GetChessFigure(color, coordinate);

            board.AddFigureToBoard(figure);
            board.DrawBoard();
        }
        else Console.WriteLine("Invalid answer. Try again");
    }
}