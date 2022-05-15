
public class NumeralConverter
{
    private string DictType { get; set; }
    public Dictionary<string, string>? NumDictionary;
    private string UserInput = "";
    public string ConvertedNumeral = "";

    public NumeralConverter(string dictype) { DictType = dictype; }

    public void setDictionary(INumeralDictionary _dictionary) =>
        NumDictionary = (Dictionary<string, string>?)_dictionary.NumeralDictionary();

    public void ConvertRomanNumeral(string? _userinput)
    {
        try
        {
            CheckUserInput(_userinput);
            DoConversion(UserInput);
            PrintResult(ConvertedNumeral);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public string CheckUserInput(string? _userinput) =>
    UserInput = !string.IsNullOrEmpty(_userinput) && NumDictionary.ContainsKey(_userinput) ?
        _userinput : throw new ArgumentException($"Error: Please enter a valid numeral");

    public string DoConversion(string UserInput) =>
        ConvertedNumeral = NumDictionary[UserInput];

    private void PrintResult(string ConvertedNumeral) =>
        Console.WriteLine($"You converted the {DictType} Numeral {UserInput} " +
            $"to the number {ConvertedNumeral}");
}

