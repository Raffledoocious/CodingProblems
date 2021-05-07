using CodingProblems;
using NUnit.Framework;

namespace CodingProblemsTests
{
	public class Tests
	{
		[TestCase(0, true)]
		[TestCase(-10, false)]
		[TestCase(int.MaxValue, false)]
		[TestCase(int.MinValue, false)]
		[TestCase(101, true)]
		[TestCase(1230321, true)]
		[TestCase(1234, false)]
		[TestCase(-101, false)]
		public void BuiltInLibraries_ReturnsCorrectResult(int number, bool expectedResult)
		{
			bool isPalindrome = PalindromeNumber.IsPalindrome(number);
			Assert.AreEqual(expectedResult, isPalindrome);
		}
	}
}