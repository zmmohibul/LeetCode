using SubdomainVisitCount;

var sl = new Solution();
sl.SubdomainVisits(new []{"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"})
    .ToList()
    .ForEach(Console.WriteLine);