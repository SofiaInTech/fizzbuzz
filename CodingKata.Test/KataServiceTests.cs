using CodingKata.Service;
using CodingKata.Service.Interfaces;

namespace CodingKata.Test;

public class KataServiceTests
{
    private IKataService _kataService;

    [SetUp]
    public void Setup()
    {
        _kataService = new KataService();
    }

    [Test]
    public void CalculateFizzBuzzResult()
    {
        // Arrange
        var number = 5;
        var expectedResult = "Buzz";

        // Act
        var actualResult = _kataService.CalculateFizzBuzzResult(number);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
