using System;
using System.Linq;

namespace CodingProblems
{
	public class PalindromeNumber
	{
		public static bool IsPalindrome(int number)
		{
			var reverseChars = number.ToString().Reverse().ToArray();
			var reverse = new string(reverseChars);

			return reverse == number.ToString();
		}

		public static bool IsPalindromeWithoutConversion(int number)
		{
			if (number < 0) {
				return false;
			}

			return number == Reverse(number);
		}

		private static int Reverse(int number)
		{
			int reverse = 0;

			while (number > 0)
			{
				int digit = number % 10;
				reverse = (reverse * 10) + digit;
				number /= 10;
			}

			return reverse;
		}
	}
}
