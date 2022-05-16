using NUnit.Framework;
using FluentAssertions;
using System;
using System.Linq;

namespace RomanNumeralsConverter.Tests
{
    public class ValidateInputTests
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
        public void CheckNumberToConvertValue_Should_Return_False_If_Null_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            string _input = null;
            bool expected = ValidateInput.CheckNumberToConvertValue(_input, Dict.NumDictionary);
            Assert.AreEqual(false, expected);
        }

        [Test]
        public void CheckNumberToConvertValue_Should_Return_False_If_Empty_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            string _input = "";
            bool expected = ValidateInput.CheckNumberToConvertValue(_input, Dict.NumDictionary);
            Assert.AreEqual(false, expected);
        }

        [Test]
        public void CheckNumberToConvertValue_Should_Return_True_If_A_Valid_Parameter_Is_Passed_And_Dictionary_Is_Roman()
        {
            string _input = "V";
            bool expected = ValidateInput.CheckNumberToConvertValue(_input, Dict.NumDictionary);
            Assert.AreEqual(true, expected);
        }

        [Test]
        public void CheckDictionaryOptions_Should_Return_False_If_Null_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            string _input = null;
            bool expected = ValidateInput.CheckDictionaryOptions(_input, totalDictsCount);
            Assert.AreEqual(false, expected);
        }

        [Test]
        public void CheckDictionaryOptions_Should_Return_False_If_Empty_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            string _input = "";
            bool expected = ValidateInput.CheckDictionaryOptions(_input, totalDictsCount);
            Assert.AreEqual(false, expected);
        }

        [Test]
        public void CheckDictionaryOptions_Should_Return_True_If_A_Valid_Parameter_Is_Passed_And_Dictionary_Is_Roman()
        {
            string _input = "1";
            bool expected = ValidateInput.CheckDictionaryOptions(_input, totalDictsCount);
            Assert.AreEqual(true, expected);
        }
    }
}