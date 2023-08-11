namespace ChessLib.Shared;

public class Square
{
    private readonly Color color;
    private readonly string placeholder = "   ";

    public Square(Color color)
    {
        this.color = color;
    }

    public void PrintSquare()
    {
        if (this.color == Color.Black)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(placeholder);
            Console.BackgroundColor = defaultColor;
        }
        else
        {
            Console.Write(placeholder);
        }
    }
}