namespace DetermineColorOfAChessboardSquare;

public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        var blackSquares = new HashSet<char> { 'a', 'c', 'e', 'h' };
        var whiteSquares = new HashSet<char> { 'b', 'd', 'f', 'g' };

        var num = Convert.ToInt32(coordinates[1]);

        if (blackSquares.Contains(coordinates[0]))
        {
            return num % 2 == 0;
        }

        return num % 2 != 0;
    }
}