using CodingKata.Service.Interfaces;

namespace CodingKata.Service;

public class KataService : IKataService
{
    public string CalculateFizzBuzzResult(int number)
    {
        // Divisible by both 3 and 5?
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "Fizzbuzz";
        }

        // Divisible by 3?
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        // Divisible by 5?
        if (number % 5 == 0)
        {
            return "Buzz";
        }

        // If neither - return just the number.
        return number.ToString();
    }
}
