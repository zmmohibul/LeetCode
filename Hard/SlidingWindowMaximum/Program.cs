using SlidingWindowMaximum;

var sl = new Solution();
sl.MaxSlidingWindow(new []{1,3,-1,-3,5,3,6,7}, 3).ToList().ForEach(item => Console.Write($"{item} "));