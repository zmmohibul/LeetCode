public class FrequencyTracker
{
    public Dictionary<int, int> Frequency { get; set; }
    public Dictionary<int, int> NumFrequency { get; set; }
    
    public FrequencyTracker()
    {
        Frequency = new Dictionary<int, int>();
        NumFrequency = new Dictionary<int, int>();
    }
    
    public void Add(int number)
    {
        if (NumFrequency.ContainsKey(number))
        {
            var numberCurrFreq = NumFrequency[number];
            Frequency[numberCurrFreq] -= 1;
            if (Frequency[numberCurrFreq] == 0)
            {
                Frequency.Remove(numberCurrFreq);
            }
        }
        
        NumFrequency[number] = NumFrequency.GetValueOrDefault(number, 0) + 1;
        Frequency[NumFrequency[number]] = Frequency.GetValueOrDefault(NumFrequency[number], 0) + 1;
    }
    
    public void DeleteOne(int number)
    {
        if (!NumFrequency.ContainsKey(number))
        {
            return;
        }
        Frequency[NumFrequency[number]] -= 1;
        if (Frequency[NumFrequency[number]] == 0)
        {
            Frequency.Remove(NumFrequency[number]);
        }
        
        NumFrequency[number] -= 1;
        if (NumFrequency[number] == 0)
        {
            NumFrequency.Remove(number);
        }
        else
        {
            Frequency[NumFrequency[number]] = Frequency.GetValueOrDefault(NumFrequency[number], 0) + 1;
        }
    }
    
    public bool HasFrequency(int frequency) 
    {
        if (!Frequency.ContainsKey(frequency))
        {
            return false;
        }

        return true;
    }
}