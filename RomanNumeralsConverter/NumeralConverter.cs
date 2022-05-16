using System.Linq;

SetDictionary dict = new();

StandardMessages.Welcome();
string? SelectedConverterType = Console.ReadLine();

if (ValidateInput.CheckDictionaryOptions(SelectedConverterType, SetDictionary.TotalDicts))
{
    if (SelectedConverterType.Equals("1"))
    {
        dict = new(new RomanDictToEnglish());
    }
    else if (SelectedConverterType.Equals("2"))
    {
        dict = new(new EnglishDictToSpanish());
    }
    StandardMessages.SelectedOptionWelcome(dict.SelectedDictFirstName, dict.DictFirstValue, dict.DictLastValue);
    string? _userinput = Console.ReadLine();
    if (ValidateInput.CheckNumberToConvertValue(_userinput, dict.NumDictionary)){
        RunConversion run = new(dict, _userinput);
        GetResult.PrintResult(dict.SelectedDictFirstName, dict.SelectedDictLastName, _userinput, run.ConvertedValue);
    }
}
else
{
    StandardMessages.DictOptionError();
}
