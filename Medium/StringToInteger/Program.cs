using StringToInteger;

var sl = new Solution();
Console.WriteLine(sl.MyAtoi("-42"));
Console.WriteLine(sl.MyAtoi("42"));
Console.WriteLine(sl.MyAtoi("21474836460"));
Console.WriteLine(sl.MyAtoi("-91283472332"));
Console.WriteLine(sl.MyAtoi("-91283472332"));
Console.WriteLine(sl.MyAtoi("2147483800"));
Console.WriteLine(sl.MyAtoi("2147483648"));
Console.WriteLine(sl.MyAtoi("-+12"));
Console.WriteLine(sl.MyAtoi(""));
