namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into decimal.
	/// </summary>
	public class DecimalParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Decimal value if parsing successfull, null otherwise.</returns>
		public static decimal? Get(string value)
		{
			if (decimal.TryParse(value, out decimal result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Decimal value if parsing successfull, null otherwise.</returns>
		public static decimal? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return decimal.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, decimal value of 1 if input value is true, 0 otherwise.</returns>
		public static decimal? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1m : 0m;
		}
	}
}
