using System;

namespace Helpers.Results.Base
{
	/// <summary>
	/// Base abstract class for all types of Results.
	/// </summary>
	public abstract class ResultBase
	{
		/// <summary>
		/// Defines if result was successful or a failure.
		/// </summary>
		public bool IsSuccess { get; internal set; }
		/// <summary>
		/// If defined, it shows message of the failed result.
		/// </summary>
		public string? ErrorMessage { get; internal set; }
		/// <summary>
		/// If defined, it contains exception that occured.
		/// </summary>
		public Exception? Exception { get; internal set; }
	}
}
