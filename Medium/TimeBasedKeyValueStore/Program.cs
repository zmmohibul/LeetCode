using TimeBasedKeyValueStore;

var tm = new TimeMap();
tm.Set("love", "high", 10);
tm.Set("love", "low", 20);
Console.WriteLine(tm.Get("love", 5));
Console.WriteLine(tm.Get("love", 10));
Console.WriteLine(tm.Get("love", 15));
Console.WriteLine(tm.Get("love", 20));
Console.WriteLine(tm.Get("love", 25));
tm.Set("foo", "bar2", 4);