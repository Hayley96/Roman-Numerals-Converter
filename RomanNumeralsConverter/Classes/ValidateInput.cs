public class ValidateInput
{
    public static bool CheckNumberToConvertValue(string? _userinput, Dictionary<string, string> selectedDict)
    {
        try
        {
            return !string.IsNullOrEmpty(_userinput) && selectedDict.ContainsKey(_userinput) ?
                true : throw new ArgumentException("Error: Please enter a valid numeral");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }

    public static bool CheckDictionaryOptions(string? _options, string[] TotalDictionariesCount)
    {
        try
        {
            return !string.IsNullOrEmpty(_options) && TotalDictionariesCount.Contains(_options) ?
                true : throw new ArgumentException("Error: Please enter a valid numeral");
        }
        catch (ArgumentException ex)
        {
            return false;
        }

    }
}