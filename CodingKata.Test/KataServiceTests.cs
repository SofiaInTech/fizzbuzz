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

    [TestCase(5, "Buzz")]
    [TestCase(6, "Fizz")]
    [TestCase(15, "Fizzbuzz")]
    public void CalculateFizzBuzzResult(int number, string expectedResult)
    {
        // Act
        var actualResult = _kataService.CalculateFizzBuzzResult(number);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
