using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var s = "hello ";
			s = string.Concat("world");

			var maxLengthOfProductsForInt = ((int)Math.Sqrt(int.MaxValue)).ToString().Length - 1;


			var maxPalindrome = int.MinValue;
			var digits = 2;

			var upper = (int)Math.Pow(10, digits) - 1;
			var lower = (int)Math.Pow(10, digits - 1);

			for (int i = upper; i >= lower; i--)
			{
				for (int j = i; j >= lower; j--)
				{
					var product = i * j;
					if (IsPalindrome(product) && product > maxPalindrome)
					{
						maxPalindrome = product;
					}
				}
			}

			if (maxPalindrome == int.MinValue)
			{

			}

			Console.WriteLine(maxPalindrome);
		}

		static bool IsPalindrome(int i)
		{
			var s = i.ToString();
			return s.SequenceEqual(s.Reverse());
		}

		//public static bool CheckIfPalindrome(int possiblePalindrome)
		//{
		//	var possPalindrome = possiblePalindrome.ToString();
		//	var length = possPalindrome.Length;

		//	for (var i = 0; i < length / 2; i++)
		//	{
		//		if (possPalindrome[i] != possPalindrome[length - 1 - i])
		//		{
		//			return false;
		//		}
		//	}

		//	return true;
		//}
	}
}
