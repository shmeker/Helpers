namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into ushort.
	/// </summary>
	public static class UshortParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Ushort value if parsing successfull, null otherwise.</returns>
		public static ushort? Get(string value)
		{
			if (ushort.TryParse(value, out ushort result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Ushort value if parsing successfull, null otherwise.</returns>
		public static ushort? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return ushort.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, ushort value of 1 if input value is true, 0 otherwise.</returns>
		public static ushort? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return (ushort)(value.Value ? 1 : 0);
		}
	}
}
