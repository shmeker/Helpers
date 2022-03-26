using Helpers.Results.Base;

namespace Helpers.Results
{
	/// <summary>
	/// Wrapper class for storing value typed result of some operation.
	/// </summary>
	/// <typeparam name="T">Type of result value.</typeparam>
	public class ValueResult<T> : ResultBase where T : unmanaged
	{
		/// <summary>
		/// Result value of the operation. If not successfull, it will contain default value.
		/// </summary>
		public T Value { get; internal set; }

		internal ValueResult() { }
	}
}
