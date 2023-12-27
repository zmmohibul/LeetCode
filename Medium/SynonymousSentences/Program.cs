using SynonymousSentences;

var sl = new Solution();
var synonyms = new List<IList<string>>();
synonyms.Add(new List<string> {"happy","joy"});
synonyms.Add(new List<string> {"sad","sorrow"});
synonyms.Add(new List<string> {"joy","cheerful"});
sl.GenerateSentences(synonyms, "I am happy today but was sad yesterday");