namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into byte.
	/// </summary>
	public static class ByteParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Byte value if parsing successfull, null otherwise.</returns>
		public static byte? Get(string value)
		{
			if (byte.TryParse(value, out byte result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Byte value if parsing successfull, null otherwise.</returns>
		public static byte? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return byte.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, byte value of 1 if input value is true, 0 otherwise.</returns>
		public static byte? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return (byte)(value.Value ? 1 : 0);
		}
	}
}
