namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into int.
	/// </summary>
	public static class IntParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Int value if parsing successfull, null otherwise.</returns>
		public static int? Get(string value)
		{
			if (int.TryParse(value, out int result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Int value if parsing successfull, null otherwise.</returns>
		public static int? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return int.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, int value of 1 if input value is true, 0 otherwise.</returns>
		public static int? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1 : 0;
		}
	}
}
