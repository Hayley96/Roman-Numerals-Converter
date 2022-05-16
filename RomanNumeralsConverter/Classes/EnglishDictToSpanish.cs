public class EnglishDictToSpanish : INumeralDictionary
{
    public IDictionary<string, string> NumeralDictionary()
    {
        return new Dictionary<string, string>()
            { {"1", "Uno"}, {"2", "Dos" }, {"3","Tres"}, {"4","Cuatro"}, {"5","Cinco"},
                {"6","Seis"}, {"7","Siete"}, {"8","Ocho"}, {"9","Nueve"}, {"10","Diez"} };
    }
}