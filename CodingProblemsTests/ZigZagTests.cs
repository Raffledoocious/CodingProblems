using CodingProblems;
using NUnit.Framework;

namespace CodingProblemsTests
{
	public class ZigZagTests
	{
		[Test]
		public void SeveralRowInput_ReturnsCorrectString()
		{
			var result = ZigZag.Convert("PAYPALISHIRING", 3);
			Assert.AreEqual("PAHNAPLSIIGYIR", result);
		}

		[Test]
		public void SingleRow_InputReturnsInOrder()
		{
			var input = "PAYPALISHIRING";
			var result = ZigZag.Convert(input, 1);
			Assert.AreEqual(input, result);
		}

		[Test]
		public void MoreRowsThanCharacters_InputReturnsInOrder()
		{
			var input = "HITHERE";
			var result = ZigZag.Convert(input, 10);
			Assert.AreEqual(input, result);
		}

		[Test]
		public void TwoRows_ReturnsCorrectString()
		{
			var result = ZigZag.Convert("PAYPALISHIRING", 2);
			Assert.AreEqual("PYAIHRNAPLSIIG", result);
		}
	}
}
