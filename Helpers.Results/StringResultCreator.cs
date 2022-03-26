using System;

namespace Helpers.Results
{
	/// <summary>
	/// Static class that creates new instaces of <see cref="StringResult">StringResult</see> class.
	/// </summary>
	public static class StringResultCreator
	{
		/// <summary>
		/// Method that creates success <see cref="StringResult">StringResult</see> object.
		/// </summary>
		/// <param name="value">Value of successful operation.</param>
		/// <returns>New instance of success <see cref="StringResult">StringResult</see> object.</returns>
		public static StringResult CreateSuccess(string value)
		{
			StringResult result = new StringResult
			{
				Value = value,
				IsSuccess = true
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="StringResult">StringResult</see> object.
		/// </summary>
		/// <returns>New instance of failed <see cref="StringResult">StringResult</see> object.</returns>
		public static StringResult CreateFailure()
		{
			StringResult result = new StringResult
			{
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="StringResult">StringResult</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <returns>New instance of failed <see cref="StringResult">StringResult</see> object.</returns>
		public static StringResult CreateFailure(string errorMessage)
		{
			StringResult result = new StringResult
			{
				ErrorMessage = errorMessage,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="StringResult">StringResult</see> object.
		/// </summary>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="StringResult">StringResult</see> object.</returns>
		public static StringResult CreateFailure(Exception exception)
		{
			StringResult result = new StringResult
			{
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="StringResult">StringResult</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="StringResult">StringResult</see> object.</returns>
		public static StringResult CreateFailure(string errorMessage, Exception exception)
		{
			StringResult result = new StringResult
			{
				ErrorMessage = errorMessage,
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}
	}
}
