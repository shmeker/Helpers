using Helpers.Results.Base;

namespace Helpers.Results
{
	/// <summary>
	/// Wrapper class for storing class typed result of some operation.
	/// </summary>
	/// <typeparam name="T">Type of result value.</typeparam>
	public class Result<T> : ResultBase where T : class
	{
		/// <summary>
		/// Result value of the operation. If not successfull, it will contain default value.
		/// </summary>
		public T? Value { get; internal set; }		

		internal Result() { }
	}
}
