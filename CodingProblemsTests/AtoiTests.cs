using CodingProblems;
using NUnit.Framework;
using System;

namespace CodingProblemsTests
{
	public class AtoiTests
	{
		[TestCase("1", 1)]
		[TestCase("+1", 1)]
		[TestCase("-1", -1)]
		[TestCase("0", 0)]
		[TestCase("11a", 11)]
		[TestCase("-11a", -11)]
		[TestCase("-11a11", -11)]
		[TestCase("           -1111", -1111)]
		[TestCase("-1111             ", -1111)]
		[TestCase("            -1111             ", -1111)]
		[TestCase("-9999999999999999999999999999999999999999999999999999999999999999999999999999999", int.MinValue)]
		[TestCase("99999999999999999999999999999999999999999999999999999999999999999999999999999999", int.MaxValue)]
		[TestCase("-", 0)]
		[TestCase("+", 0)]
		[TestCase("-a", 0)]
		[TestCase("-b", 0)]
		[TestCase("-b123", 0)]
		[TestCase("    ", 0)]
		[TestCase("", 0)]
		[TestCase(null, 0)]
		public void ConvertValidStrings_CorrectNumberReturned(string s, int expected)
		{
			var result = Atoi.Convert(s);
			Assert.AreEqual(expected, result);
		}
	}
}
