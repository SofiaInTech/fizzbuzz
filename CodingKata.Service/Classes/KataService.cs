using CodingKata.Service.Interfaces;

namespace CodingKata.Service;

public class KataService : IKataService
{
    public string CalculateFizzBuzzResult(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return number.ToString();
    }
}
