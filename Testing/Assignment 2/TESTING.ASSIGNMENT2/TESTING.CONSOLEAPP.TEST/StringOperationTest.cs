using System;
using System.Collections.Generic;
using System.Text;
using TESTING.CONSOLEAPP.ExtenstionClasses;
using Xunit;

namespace TESTING.CONSOLEAPP.TEST
{
    public class StringOperationTest
    {
        //Returning input string with uppercase characters converted to lowercase and vice versa.

        [Fact]
        public void Test_ChangeCase1()
        {
            // Arrange
            var inputString = "Saloni";
            var outputString = "saloni";
            // Act
            var newString = inputString.ChangeCase();
            // Assert
            Assert.Equal(newString, outputString);
        }

        [Fact]
        public void Test_ChangeCase2()
        {
            // Arrange
            var inputString = "Megha";
            var outputString = "megha";
            // Act
            var newString = inputString.ChangeCase();
            // Assert
            Assert.Equal(newString, outputString);
        }

        [Fact]
        public void Test_ChangeCase3()
        {
            // Arrange
            var inputString = "Kajal";
            var outputString = "kajal";
            // Act
            var newString = inputString.ChangeCase();
            // Assert
            Assert.Equal(newString, outputString);
        }

        //Converts the specified string to title case.
        [Theory]
        [InlineData("saloni CSE KAJAL Bca BbA", "Saloni CSE KAJAL Bca Bba")]
        [InlineData("Raj RAj MCA", "Raj Raj MCA")]
        [InlineData("abc bCA bcOm MVc MVC", "Abc Bca Bcom Mvc MVC")]
        public void Test_TitleCase(string inputString, string result)
        {

            // Act
            var newString = inputString.TitleCase();

            // Assert
            Assert.Equal(newString, result);

        }

        //Check characters are in lower case or not
        [Fact]
        public void Test_IsLowerCase1()
        {
            // Arrange
            var inputString = "john";
            // Act
            var newString = inputString.IsLowerCase();
            // Assert
            Assert.True(newString);
        }

        [Fact]
        public void Test_IsLowerCase2()
        {
            // Arrange
            var inputString = "deshna";
            // Act
            var newString = inputString.IsLowerCase();
            // Assert
            Assert.True(newString);
        }

        //Check characters are in upper case or not
        [Fact]
        public void Test_IsUpperCase1()
        {
            // Arrange
            var inputString = "JONY";
            // Act
            var newString = inputString.IsUpperCase();
            // Assert
            Assert.True(newString);
        }

        [Fact]
        public void Test_IsUpperCase2()
        {
            // Arrange
            var inputString = "SHUBHAM";
            // Act
            var newString = inputString.IsUpperCase();
            // Assert
            Assert.True(newString);
        }

        //Checking first character have upper case and the rest lower case
        [Fact]
        public void Test_Capitalize1()
        {
            // Arrange
            var inputString = "saloni";
            var outputString = "Saloni";
            // Act
            var newString = inputString.Capitalize();
            // Assert
            Assert.Equal(newString,outputString);
        }

        [Fact]
        public void Test_Capitalize2()
        {
            // Arrange
            var inputString = "nayan";
            var outputString = "Nayan";
            // Act
            var newString = inputString.Capitalize();
            // Assert
            Assert.Equal(newString, outputString);
        }

        [Fact]
        public void Test_Capitalize3()
        {
            // Arrange
            var inputString = "pihu";
            var outputString = "Pihu";
            // Act
            var newString = inputString.Capitalize();
            // Assert
            Assert.Equal(newString, outputString);
        }

        //Check input string can be converted to a valid numeric value or not.

        [Theory]
        [InlineData("123", true)]
        [InlineData("123c", false)]
        public void Test_IsValidNumericValue(string inputString,bool result)
        {
            // Arrange
            
            // Act
            var newString = inputString.IsValidNumericValue();
            // Assert
            Assert.Equal(newString, result);
        }

        //Remove last character of string
        [Fact]
        public void Test_RemoveLastCharacter1()
        {
            // Arrange
            var inputString = "Saloni Jain";
            var outputString = "Saloni Jai";
            // Act
            var newString = inputString.RemoveLastCharacter();
            // Assert
            Assert.Equal(newString, outputString);
        }

        [Fact]
        public void Test_RemoveLastCharacter2()
        {
            // Arrange
            var inputString = "Kajal Singhvi";
            var outputString = "Kajal Singhv";
            // Act
            var newString = inputString.RemoveLastCharacter();
            // Assert
            Assert.Equal(newString, outputString);
        }

        //Count word from an input string

        [Fact]
        public void Test_WordCount1()
        {
            // Arrange
            var inputString = "Saloni Jain";
            var count = 2;
            // Act
            var newString = inputString.WordCount();
            // Assert
            Assert.Equal(newString, count);
        }

        [Fact]
        public void Test_WordCount2()
        {
            // Arrange
            var inputString = "Nayan Mogra Jain";
            var count = 3;
            // Act
            var newString = inputString.WordCount();
            // Assert
            Assert.Equal(newString, count);
        }

        //Converting input string into integer
        [Fact]
        public void Test_StringToInteger1()
        {
            // Arrange
            var inputString = "123";
            var output = 123;
            // Act
            var newString = inputString.StringToInteger();
            // Assert
            Assert.Equal(newString, output);
        }

        [Fact]
        public void Test_StringToIntege2r()
        {
            // Arrange
            var inputString = "458";
            var output = 458;
            // Act
            var newString = inputString.StringToInteger();
            // Assert
            Assert.Equal(newString, output);
        }
    }
}
