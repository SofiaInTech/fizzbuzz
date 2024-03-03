using CodingKata.Service;
using CodingKata.Service.Interfaces;

namespace CodingKata
{
	public static class KataFunctions
	{
		public static void FizzBuzz()
		{
			// Calling this via some kind of DI library would be ideal.
			IKataService kataService = new KataService();

			// Compile list of numbers
			var numbers = Enumerable.Range(1, 100);

			// Iterate over each number and get FizzBuzz result
			foreach (var number in numbers)
			{
				var fizzBuzzResult = kataService.CalculateFizzBuzzResult(number);
				Console.WriteLine(fizzBuzzResult);
			}
		}
	}
}

