

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

  

   
}
