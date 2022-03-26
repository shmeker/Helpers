using Helpers.Results.Base;

namespace Helpers.Results
{
	/// <summary>
	/// Wrapper class for storing value string result of some operation.
	/// </summary>
	public class StringResult : ResultBase
	{
		/// <summary>
		/// Result value of the operation. If not successfull, it will contain default value.
		/// </summary>
		public string Value { get; internal set; }

		internal StringResult()
		{
			Value = default!;
		}
	}
}
