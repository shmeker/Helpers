namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into uint.
	/// </summary>
	public static class UintParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Uint value if parsing successfull, null otherwise.</returns>
		public static uint? Get(string value)
		{
			if (uint.TryParse(value, out uint result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Uint value if parsing successfull, null otherwise.</returns>
		public static uint? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return uint.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, uint value of 1 if input value is true, 0 otherwise.</returns>
		public static uint? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1U : 0U;
		}
	}
}
