using GenerateParentheses;

var sl = new Solution();
sl.GenerateParenthesis(3).ToList().ForEach(item => Console.Write($"{item}, "));