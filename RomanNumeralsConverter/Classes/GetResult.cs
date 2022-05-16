public class GetResult
{
    public static void PrintResult(string DictType, string SelectedDictLastName, string UserInput, string ConvertedValue) =>
        Console.WriteLine($"You converted the {DictType} Numeral {UserInput} " +
            $"to the {SelectedDictLastName} number {ConvertedValue}");
}