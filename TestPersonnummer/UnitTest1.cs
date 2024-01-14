

using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

[TestFixture]
public class TestPersonnummer
{ 


    [TestCase("920101-1234")]
    [TestCase("850214-5678")]
    [TestCase("990630-9876")]
    public void IsValidPersonnummer_ValidFormat_ShouldReturnTrue(string personnummer)
    {
        // Arrange
        bool expectedResult = true;

        // Act
        bool actualResult = PersonnummerValidator.IsValidPersonnummer(personnummer);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestCase("920101-12")]
    [TestCase("8502145678")]
    [TestCase("abcde")]
    public void IsValidPersonnummer_InvalidFormat_ShouldReturnFalse(string personnummer)
    {
        // Arrange
        bool expectedResult = false;

        // Act
        bool actualResult = PersonnummerValidator.IsValidPersonnummer(personnummer);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestCase("920101-123A")]
    [TestCase("850214-56AB")]
    public void IsValidPersonnummer_InvalidCharacter_ShouldReturnFalse(string personnummer)
    {
        // Arrange
        bool expectedResult = false;

        // Act
        bool actualResult = PersonnummerValidator.IsValidPersonnummer(personnummer);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
    [TestCase("920101-12")]
    [TestCase("8502145678")]
    [TestCase("abcde")]
    public void Main_InvalidPersonnummer_ShouldPrintCorrectMessage(string personnummer)
    {
        // Arrange
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);
        Console.SetIn(new System.IO.StringReader(personnummer));

        // Act
        PersonnummerValidator.Main();

        // Assert
        Assert.AreEqual($"Personnumret är ogiltigt.{Environment.NewLine}", consoleOutput.ToString());
    }
    [TestCase("920101-1234")]
    [TestCase("850214-5678")]
    [TestCase("990630-9876")]
    public void Main_ValidPersonnummer_ShouldPrintCorrectMessage(string personnummer)
    {
        // Arrange
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);
        Console.SetIn(new System.IO.StringReader(personnummer));

        // Act
        PersonnummerValidator.Main();

        // Assert
        Assert.AreEqual($"Personnumret är korrekt.{Environment.NewLine}", consoleOutput.ToString());
    }


}
