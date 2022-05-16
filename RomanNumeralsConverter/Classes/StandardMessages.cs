public class StandardMessages
{
    public static void Welcome()
    {
        Console.WriteLine("Please select a number 1 0r 2\n" +
            "1 - Convert Roman numeral to equivalent English number (Example: input 'V' returns '5')\n" +
            "2 - Convert English numeral to Spanish equivalent number word (Example: input '3' returns 'Tres')");
    }

    public static void SelectedOptionWelcome(string DictType, string firstNumInDict, string lastNumInDict)
    {
        Console.WriteLine($"Please enter a {DictType} Numeral between {firstNumInDict} and {lastNumInDict}");
    }

    public static void DictOptionError()
    {
        Console.WriteLine("Please enter a valid option number");
    }
}