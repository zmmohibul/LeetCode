using MinimumAmountOfTimeToCollectGarbage;

var sl = new Solution();
Console.WriteLine(sl.GarbageCollection(new []{ "G", "P", "GP", "GG" }, new []{ 2, 4, 3 }));
Console.WriteLine(sl.GarbageCollection(new []{ "MMM","PGM","GP" }, new []{ 3,10 }));