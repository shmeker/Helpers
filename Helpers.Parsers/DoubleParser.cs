namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into double.
	/// </summary>
	public class DoubleParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Double value if parsing successfull, null otherwise.</returns>
		public static double? Get(string value)
		{
			if (double.TryParse(value, out double result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Double value if parsing successfull, null otherwise.</returns>
		public static double? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return double.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, double value of 1 if input value is true, 0 otherwise.</returns>
		public static double? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1D : 0D;
		}
	}
}
