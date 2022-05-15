using System.Linq;

string[] DictOptionRange = { "1", "2" };

Console.WriteLine("Please select a number 1 0r 2\n" +
    "1 - Convert Roman numeral to equivalent English number (Example: input 'V' returns '5')\n" +
    "2 - Convert English numeral to Spanish equivalent number word (Example: input '3' returns 'Tres')");

string? ConvertType = Console.ReadLine();
if (!string.IsNullOrEmpty(ConvertType) && DictOptionRange.Contains(ConvertType))
{
    if (ConvertType.Equals("1"))
    {
        Console.WriteLine("Please enter a Roman Numeral between I and X");
        string? _userinput = Console.ReadLine();
        NumeralConverter convert = new("Roman");
        convert.setDictionary(new RomanDict());
        convert.ConvertRomanNumeral(_userinput);
    }
    else if (ConvertType.Equals("2"))
    {
        Console.WriteLine("Please enter a English Numeral between 1 and 10");
        string? _userinput = Console.ReadLine();
        NumeralConverter convert = new("English");
        convert.setDictionary(new SpanishDict());
        convert.ConvertRomanNumeral(_userinput);
    }
}
else { Console.WriteLine("Please enter a valid option number"); }




