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

    [TestCase(1, "1")]
    [TestCase(5, "Buzz")]
    [TestCase(6, "Fizz")]
    [TestCase(15, "Fizzbuzz")]
    [TestCase(46, "46")]
    [TestCase(60, "Fizzbuzz")]
    [TestCase(66, "Fizz")]
    [TestCase(88, "88")]
    [TestCase(99, "Fizz")]
    [TestCase(1031, "1031")]
    [TestCase(-10, "Buzz")]
    public void CalculateFizzBuzzResult(int number, string expectedResult)
    {
        // Act
        var actualResult = _kataService.CalculateFizzBuzzResult(number);

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
