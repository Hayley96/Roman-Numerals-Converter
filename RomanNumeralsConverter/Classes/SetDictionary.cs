public class SetDictionary
{
    public Dictionary<string, string> NumDictionary { get; private set; }
    public string SelectedDictFirstName { get; private set; }
    public string SelectedDictLastName { get; private set; }
    public string DictFirstValue { get; private set; }
    public string DictLastValue { get; private set; }

    public static readonly string[] TotalDicts = { "1", "2" };

    public SetDictionary(INumeralDictionary _dictionary)
    {
        NumDictionary = (Dictionary<string, string>)_dictionary.NumeralDictionary();
        SelectedDictFirstName = _dictionary.ToString()[.._dictionary.ToString().IndexOf('D')];
        SelectedDictLastName = _dictionary.ToString()[(_dictionary.ToString().LastIndexOf('o') + 1)..];
        DictFirstValue = NumDictionary.Keys.First();
        DictLastValue = NumDictionary.Keys.Last();
    }

    public SetDictionary()
    {
    }




}