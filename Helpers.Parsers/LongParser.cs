namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into long.
	/// </summary>
	public static class LongParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Long value if parsing successfull, null otherwise.</returns>
		public static long? Get(string value)
		{
			if (long.TryParse(value, out long result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Long value if parsing successfull, null otherwise.</returns>
		public static long? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return long.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, long value of 1 if input value is true, 0 otherwise.</returns>
		public static long? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1 : 0;
		}
	}
}
