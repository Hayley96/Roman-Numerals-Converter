
public class RunConversion
{
    public string ConvertedValue { get; private set; }
    public RunConversion(SetDictionary dict, string ValueToConvert)
    {
        ConvertedValue = dict.NumDictionary[ValueToConvert];
    }
}

