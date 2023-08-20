using System.Reflection.Metadata.Ecma335;

namespace ChessLib.Shared;

public struct Coordinate
{
    public static byte[] yCords = { 8, 7, 6, 5, 4, 3, 2, 1 };
    public static char[] xCords = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

    public static bool IsValidCoordinate(string row)
    {
        byte y = Convert.ToByte(row[1].ToString());
        char x = row[0];

        return Array.IndexOf(xCords, x) != -1 && Array.IndexOf(yCords, y) != -1;
    }

    public char X { get; set; }
    public byte Y { get; set; }

    public Coordinate(char x, byte y)
    {
        X = x;
        Y = y;
    }

    public Coordinate(string row)
    {
        Y = Convert.ToByte(row[1].ToString());
        X = row[0];
    }
}