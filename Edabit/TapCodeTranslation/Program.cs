using System;
using System.Text;

namespace TapCodeTranslation
{
	class Program
	{
		static void Main(string[] args)
		{
			//var spent = ".... ... ... ..... . ..... ... ... .... ....";
			//var @break = ". .. .... .. . ..... . . . ...";
			//var result = Encode(Decode(@break));
			//Console.WriteLine($"strings are equal => {@break == result}");

			var alphabet = "abcdefghijklmnopqrstuvwxyz";
			var result = Decode(Encode(alphabet));
			Console.WriteLine($"strings are equal => {alphabet == result}");
		}

		public static string Decode(string tapCode)
		{
			Console.WriteLine($"Decoding \"{tapCode}\"");
			var splits = tapCode.Split(' ');
			var sb = new StringBuilder();

			for (var i = 0; i < splits.Length / 2; i++)
			{
				// convert coordinates into ascii alphabet character number
				var row = splits[i * 2].Length;
				var column = splits[(i * 2) + 1].Length;
				var letter = ((row - 1) * 5) + (column - 1) + 'a';

				// special case for c/k
				if (letter >= 'k')
					letter++;

				Console.WriteLine($"[{row}-{column}] => {letter - 'a'} => {letter} => {(char)letter} (from \"{splits[i * 2]}\"-\"{splits[(i * 2) + 1]}\")");

				_ = sb.Append((char)letter);
			}
			var result = sb.ToString();
			Console.WriteLine($"Decoded message => \"{result}\"\n");
			return result;
		}

		public static string Encode(string plaintext)
		{
			Console.WriteLine($"Encoding \"{plaintext}\"");
			var sb = new StringBuilder();

			foreach (var c in plaintext)
			{
				// can't modify a loop variable
				var cc = c;

				// special case for c/k
				if (cc == 'k')
					cc = 'c';
				if (cc >= 'k')
					cc--;

				// convert ascii character into coordinates
				var num = cc - 'a';
				var row = (num / 5) + 1;
				var column = (num + 1) % 5;

				// mod 5 will set column 5 to 0, but it needs to be 5
				if (column == 0)
					column = 5;

				Console.WriteLine($"{(int)c - 'a'} => {num} => [{row}-{column}]");

				// expand the number of does into a sequence of dots
				_ = sb.Append('.', row);
				_ = sb.Append(' ');
				_ = sb.Append('.', column);
				_ = sb.Append(' ');
			}

			var result = sb.ToString().Trim();
			Console.WriteLine($"Encoded message => \"{result}\"\n");
			return result;
		}
	}
}
