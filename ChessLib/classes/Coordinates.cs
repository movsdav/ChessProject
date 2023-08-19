using System.Reflection.Metadata.Ecma335;

namespace ChessLib.Shared;

public struct Coordinate
{
    public static string[] xCords = { "1", "2", "3", "4", "5", "6", "7", "8" };
    public static string[] yCords = { "A", "B", "C", "D", "E", "F", "G", "H" };

    public static bool IsValidCoordinate(string row)
    {
        string y = row[0].ToString();
        string x = row[1].ToString();

        return Array.IndexOf(xCords, x) != -1 && Array.IndexOf(yCords, y) != -1;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(int x, int y)
    {
        X = x - 1;
        Y = y - 1;
    }

    public Coordinate(string row)
    {
        string y = row[0].ToString();
        string x = row[1].ToString();

        Y = Array.IndexOf(yCords, y);
        X = Array.IndexOf(xCords, x);
    }
}