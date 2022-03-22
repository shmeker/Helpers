namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into short.
	/// </summary>
	public static class ShortParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Short value if parsing successfull, null otherwise.</returns>
		public static short? Get(string value)
		{
			if (short.TryParse(value, out short result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Short value if parsing successfull, null otherwise.</returns>
		public static short? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return short.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, short value of 1 if input value is true, 0 otherwise.</returns>
		public static short? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return (short)(value.Value ? 1 : 0);
		}
	}
}
