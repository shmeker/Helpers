namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into sbyte.
	/// </summary>
	public static class SbyteParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Sbyte value if parsing successfull, null otherwise.</returns>
		public static sbyte? Get(string value)
		{
			if (sbyte.TryParse(value, out sbyte result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Sbyte value if parsing successfull, null otherwise.</returns>
		public static sbyte? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return sbyte.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, sbyte value of 1 if input value is true, 0 otherwise.</returns>
		public static sbyte? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return (sbyte)(value.Value ? 1 : 0);
		}
	}
}
