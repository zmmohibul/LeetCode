using MinimumNumberOfOperationsToMoveAllBallsToEachBox;

var sl = new Solution();
sl.MinOperations("110").ToList().ForEach(it => Console.Write($"{it} "));
Console.WriteLine();
sl.MinOperations("001011").ToList().ForEach(it => Console.Write($"{it} "));
