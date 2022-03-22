namespace Helpers.Parsers
{
	/// <summary>
	/// Static class with methods for parsing into float.
	/// </summary>
	public class FloatParser
	{
		/// <summary>
		/// Method that tries parsing input string value.
		/// </summary>
		/// <param name="value">String value to parse.</param>
		/// <returns>Float value if parsing successfull, null otherwise.</returns>
		public static float? Get(string value)
		{
			if (float.TryParse(value, out float result))
			{
				return result;
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing input char value.
		/// </summary>
		/// <param name="value">Char value to parse.</param>
		/// <returns>Float value if parsing successfull, null otherwise.</returns>
		public static float? Get(char value)
		{
			if (char.IsDigit(value))
			{
				return float.Parse(value.ToString());
			}

			return default;
		}

		/// <summary>
		/// Method that tries parsing nullable bool value.
		/// </summary>
		/// <param name="value">Nullable bool value to parse.</param>
		/// <returns>Null if input value is null, float value of 1 if input value is true, 0 otherwise.</returns>
		public static float? Get(bool? value)
		{
			if (!value.HasValue)
			{
				return default;
			}

			return value.Value ? 1F : 0F;
		}
	}
}
