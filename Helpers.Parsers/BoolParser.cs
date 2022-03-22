namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with method(s) for parsing into bool.
	/// </summary>
	public static class BoolParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Bool value if parsing successfull, null otherwise.</returns>
		public static bool? Get(string value)
		{
			if (bool.TryParse(value, out bool result))
			{
				return result;
			}

			return default;
		}
	}
}
