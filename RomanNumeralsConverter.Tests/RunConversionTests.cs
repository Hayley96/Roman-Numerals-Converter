using NUnit.Framework;
using FluentAssertions;
using System;
using System.Linq;

namespace RomanNumeralsConverter.Tests
{
    public class RunConversionTests
    {
        private RunConversion? RunConv;
        private SetDictionary Dict;

        [SetUp]
        public void Setup()
        {
            Dict = new SetDictionary(new RomanDictToEnglish());
            RunConv = new RunConversion(Dict, "V");          
        }

        [Test]
        public void RunConversion_Should_Return_English_Number_10_To_Roman_Input_X()
        {
            string _input = "X";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("10", expected);
        }

        [Test]
        public void RunConversion_Should_Return_English_Number_1_To_Roman_Input_I()
        {
            string _input = "I";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("1", expected);
        }

        [Test]
        public void RunConversion_Should_Return_English_Number_5_To_Roman_Input_V()
        {
            string _input = "V";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("5", expected);
        }

        [Test]
        public void RunConversion_Should_Return_Spanish_Word_Uno_To_English_Input_1()
        {
            Dict = new SetDictionary(new EnglishDictToSpanish());
            string _input = "1";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("Uno", expected);
        }

        [Test]
        public void RunConversion_Should_Return_Spanish_Word_Tres_To_English_Input_3()
        {
            Dict = new SetDictionary(new EnglishDictToSpanish());
            string _input = "3";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("Tres", expected);
        }

        [Test]
        public void RunConversion_Should_Return_Spanish_Word_Cinco_To_English_Input_5()
        {
            Dict = new SetDictionary(new EnglishDictToSpanish());
            string _input = "5";
            RunConv = new RunConversion(Dict, _input);
            string expected = RunConv.ConvertedValue;
            Assert.AreEqual("Cinco", expected);
        }
    }
}