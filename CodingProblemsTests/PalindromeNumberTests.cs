using CodingProblems;
using NUnit.Framework;

namespace CodingProblemsTests
{
	public class PalindromeNumberTests
	{
		[TestCase(0, true)]
		[TestCase(-10, false)]
		[TestCase(int.MaxValue, false)]
		[TestCase(int.MinValue, false)]
		[TestCase(101, true)]
		[TestCase(1230321, true)]
		[TestCase(1234, false)]
		[TestCase(-101, false)]
		public void BuiltInLibraries_ReturnsCorrectResult(int number, bool expected)
		{
			bool isPalindrome = PalindromeNumber.IsPalindrome(number);
			Assert.AreEqual(expected, isPalindrome);
		}

		[TestCase(0, true)]
		[TestCase(-10, false)]
		[TestCase(int.MaxValue, false)]
		[TestCase(int.MinValue, false)]
		[TestCase(101, true)]
		[TestCase(1230321, true)]
		[TestCase(1234, false)]
		[TestCase(-101, false)]
		public void NoBuiltInLibraries_ReturnsCorrectResult(int number, bool expected)
		{
			bool isPalindrome = PalindromeNumber.IsPalindromeWithoutConversion(number);
			Assert.AreEqual(expected, isPalindrome);
		}
	}
}