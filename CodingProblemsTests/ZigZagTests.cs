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
		}
	}
}
