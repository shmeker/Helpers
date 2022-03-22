namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into ulong.
	/// </summary>
	public static class UlongParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Ulong value if parsing successfull, null otherwise.</returns>
		public static ulong? Get(string value)
		{
			if (ulong.TryParse(value, out ulong result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Ulong value if parsing successfull, null otherwise.</returns>
		public static ulong? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return ulong.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, ulong value of 1 if input value is true, 0 otherwise.</returns>
		public static ulong? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1UL : 0UL;
		}
	}
}
