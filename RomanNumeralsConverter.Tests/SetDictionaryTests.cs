using NUnit.Framework;
using FluentAssertions;
using System;
using System.Linq;

namespace RomanNumeralsConverter.Tests
{
    public class SetDictionaryTests
    {
        private RunConversion? NumeralConverter;
        private SetDictionary Dict;
        string[] totalDictsCount = { "1", "2" };
        [SetUp]
        public void Setup()
        {
            Dict = new SetDictionary(new RomanDictToEnglish());
        }

        [Test]
        public void setDictionary_Should_Accept_An_Injected_Dictionary_Object_And_Assign_To_Class_Proparty_NumDictionary()
        {
            Dict = new SetDictionary(new RomanDictToEnglish());
            int? expected = Dict.NumDictionary.Count;
            Assert.IsTrue(expected > 0);
        }
    }
}