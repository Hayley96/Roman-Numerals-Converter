using NUnit.Framework;
using FluentAssertions;
using System;
using System.Linq;

namespace RomanNumeralsConverter.Tests
{
    public class RomanNumeralConverterTest
    {
        private NumeralConverter? NumeralConverter;
        [SetUp]
        public void Setup()
        {
            NumeralConverter = new NumeralConverter("Roman");
            NumeralConverter.setDictionary(new RomanDict());
        }

        [Test]
        public void setDictionary_Should_Accept_An_Injected_Dictionary_Object_And_Assign_To_Class_Dictionary_Object()
        {
            NumeralConverter?.setDictionary(new RomanDict());
            int? expected = NumeralConverter?.NumDictionary?.Count;
            Assert.IsTrue(expected > 0);
        }

        [Test]
        public void CheckUserInput_Should_Return_Same_Value_As_The_Parameter_Passed_When_Parameter_Is_Valid_And_Dictionary_Is_Roman()
        {
            NumeralConverter?.CheckUserInput("I").Should().Be("I");
            NumeralConverter?.CheckUserInput("V").Should().Be("V");
            NumeralConverter?.CheckUserInput("VII").Should().Be("VII");
        }

        [Test]
        public void CheckUserInput_Should_Throw_Exception_If_Null_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            var exNull = Assert.Throws<ArgumentException>(() => NumeralConverter?.CheckUserInput(null));
        }

        [Test]
        public void CheckUserInput_Should_Throw_Exception_If_Empty_Parameter_Passed_And_Dictionary_Is_Roman()
        {
            var exEmpty = Assert.Throws<ArgumentException>(() => NumeralConverter?.CheckUserInput(""));
        }

        [Test]
        public void DoConversion_Should_Return_English_Number_1_To_Roman_Input_I_And_Dictionary_Is_Roman()
        {
            NumeralConverter?.DoConversion("I").Should().Be("1");
        }

        [Test]
        public void DoConversion_Should_Return_English_Number_5_To_Roman_Input_V_And_Dictionary_Is_Roman()
        {
            NumeralConverter?.DoConversion("V").Should().Be("5");
        }

        [Test]
        public void DoConversion_Should_Return_English_Number_7_To_Roman_Input_VII_And_Dictionary_Is_Roman()
        {
            NumeralConverter?.DoConversion("VII").Should().Be("7");
        }
    }
}