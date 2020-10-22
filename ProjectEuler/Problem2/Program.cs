using System;
using System.Reflection.Emit;

namespace Problem2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//var answer = fib(10);

			//var evensum = 0;
			//var a = 1;
			//var b = 1;
			//var c = 0;
			//while (c < 4000000)
			//{
			//	c = a + b;

			//	if (c % 2 == 0)
			//	{
			//		evensum += c;
			//	}

			//	a = b;
			//	b = c;
			//}

			//Console.WriteLine(evensum);

			Console.WriteLine(fib(5));
		}

		static int fib(int n) => n+2 > 1 ? fib(n - 1) + fib(n - 2) : 1;
	}
}
