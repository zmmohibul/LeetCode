using SenderWithLargestWordCount;

var messages = new string[] {"Hello userTwooo","Hi userThree","Wonderful day Alice","Nice day userThree"};
var senders = new string[] { "Alice","userTwo","userThree","Alice" };
var solution = new Solution();
Console.WriteLine(solution.LargestWordCount(messages, senders));