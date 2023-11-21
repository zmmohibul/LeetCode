// See https://aka.ms/new-console-template for more information

using WordSearch;

var board = new char[3][];
// {
//     { 'C', 'A', 'A' },
//     { 'A', 'A', 'A' },
//     { 'B', 'C', 'D' }
// };

board[0] = new[] { 'C', 'A', 'A' };
board[1] = new[] { 'A', 'A', 'A' };
board[2] = new[] { 'B', 'C', 'D' };
var sl = new Solution();

Console.WriteLine(sl.Exist(board, "AAB"));