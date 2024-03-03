using System;
namespace CodingKata
{
	public static class KataFunctions
	{
		public static void FizzBuzz()
		{
			var numbers = Enumerable.Range(1, 100);

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}

