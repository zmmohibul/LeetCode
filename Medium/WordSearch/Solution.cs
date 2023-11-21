using System.Text;

namespace WordSearch;

public class Solution
{
    private bool found = false;
    public bool Exist(char[][] board, string word)
    {
        var sb = new StringBuilder(word);
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    Search(board, sb, new StringBuilder(), i, j, new HashSet<Tuple<int, int>>());
                    if (found) return found;
                }
            }
        }
        return false;
    }

    public void Search(char[][] board, StringBuilder word, StringBuilder curr, int row, int col, HashSet<Tuple<int, int>> visited)
    {
        var t = new Tuple<int, int>(row, col);
        if (visited.Contains(t))
        {
            return;
        }
        
        if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length)
        {
            return;
        }

        if (word.Length == curr.Length && word.Equals(curr))
        {
            found = true;
        }

        if (curr.Length == word.Length)
        {
            return;
        }

        curr.Append(board[row][col]);
        visited.Add(t);
        
        Search(board, word, curr, row + 1, col, visited);
        Search(board, word, curr, row - 1, col, visited);
        Search(board, word, curr, row, col + 1, visited);
        Search(board, word, curr, row, col - 1, visited);
        
        curr.Remove(curr.Length - 1, 1);
        visited.Remove(t);
    }
}