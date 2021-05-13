using System;

namespace CodingProblems
{
	public static class Atoi
	{
		public static int Convert(string s)
		{
			int number = 0;

			try
			{
				s = TrimString(s);
			}
			catch (ArgumentException)
			{
				return 0;
			}

			int sign;
			bool isSigned = ToSign(s[0], out sign);

			if (isSigned) { s = s.Substring(1, s.Length - 1); };

			number = ConvertString(s, sign);
			return number;
		}

		private static string TrimString(string s) 
		{ 
			if (s == null)
			{
				throw new ArgumentException("Input string was null");
			}

			s = s.Trim();

			if (s == String.Empty)
			{
				throw new ArgumentException("Input string was empty");
			}

			return s;
		}

		private static int ConvertString(string s, int sign)
		{
			int number = 0;
			bool containsDigit = false;
			try
			{
				for (int i = 0; i < s.Length; i++) 
				{
					int digit;
					bool isDigitCharacter = ToDigit(s[i], out digit);
					if (!isDigitCharacter)
					{
						break;
					}
					else
					{
						checked
						{
							number = (number * 10) + digit;
						}
					}
				}
			}
			catch (OverflowException)
			{
				if (sign == -1)
				{
					return int.MinValue;
				}
				else
				{
					return int.MaxValue;
				}
			}

			return number * sign;
		}

		private static bool ToSign(char c, out int sign)
		{
			sign = c == '-' ? -1 : 1;
			return c == '-' || c == '+';
		}

		private static bool ToDigit(char c, out int digit)
		{
			switch (c)
			{
				case '0':
					digit = 0;
					return true;
				case '1':
					digit = 1;
					return true;
				case '2':
					digit = 2;
					return true;
				case '3':
					digit = 3;
					return true;
				case '4':
					digit = 4;
					return true;
				case '5':
					digit = 5;
					return true;
				case '6':
					digit = 6;
					return true;
				case '7':
					digit = 7;
					return true;
				case '8':
					digit = 8;
					return true;
				case '9':
					digit = 9;
					return true;
				default:
					digit = 0;
					return false;
			}
		}
	}
}
