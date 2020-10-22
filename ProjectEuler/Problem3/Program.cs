using System;

namespace Problem3
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 20; i++)
			{
				Console.WriteLine($"{i} => {CheckIfPrime(i)}");
			}
		}

		public static long FindLargestPrimeFactor(long inputNumber)
		{
			long candidatePrime = 0;
			var isPrime = false;

			for (var iter = 1; iter < inputNumber; iter++)
			{
				if (inputNumber % iter == 0)
				{
					candidatePrime = (inputNumber / iter);
					isPrime = CheckIfPrime(candidatePrime);
				}

				if (isPrime)
					return candidatePrime;
			}

			return default;
		}

		public static bool CheckIfPrime(long candidateNumber)
		{
			if (candidateNumber == 2)
				return true;
			if (candidateNumber <= 1 || candidateNumber % 2 == 0)
				return false;

			for (var iter = 3; iter <= candidateNumber / 2; iter += 2)
			{
				if (candidateNumber % iter == 0)
					return false;
			}
			return true;
		}
	}
}
