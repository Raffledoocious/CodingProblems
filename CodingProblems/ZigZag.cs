using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
	public static class ZigZag
	{
		public static string Convert(string input, int numRows)
		{
			if (string.IsNullOrEmpty(input) || numRows == 1) 
			{
				return input;
			}

			int row = 0;
			bool isZaggingUp = false;

			var characters = new List<ZigZagCharacter>();

			for (int i = 0; i < input.Length; i++)
			{
				if (isZaggingUp)
				{
					row--;
					if (row == 1)
					{
						isZaggingUp = false;
					}
				}
				else
				{
					row++;
					if (row == numRows)
					{
						isZaggingUp = true;
					}
				}
				characters.Add(new ZigZagCharacter() { Character = input[i], Order = i, Row = row });
			}

			var result = new string(characters
				.OrderBy(x => x.Row)
				.ThenBy(x => x.Order)
				.Select(x => x.Character).ToArray()
				);

			return result;
		}

		/// <summary>
		/// A model of a character, what row is was placed in the ZigZag pattern, and what order it was placed in
		/// </summary>
		public class ZigZagCharacter
		{
			public char Character { get; set; }
			public int Order { get; set; }
			public int Row { get; set; }
		}
	}
}
