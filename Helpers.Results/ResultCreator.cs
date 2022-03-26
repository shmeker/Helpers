using System;

namespace Helpers.Results
{
	/// <summary>
	/// Static class that creates new instaces of <see cref="Result{T}">Result</see> class.
	/// </summary>
	public static class ResultCreator
	{
		/// <summary>
		/// Method that creates success <see cref="Result{T}">Result</see> object.
		/// </summary>
		/// <param name="value">Value of successful operation.</param>
		/// <returns>New instance of success <see cref="Result{T}">Result</see> object.</returns>
		public static Result<T> CreateSuccess<T>(T value) where T : class
		{
			Result<T> result = new Result<T>
			{
				Value = value,
				IsSuccess = true
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="Result{T}">Result</see> object.
		/// </summary>
		/// <returns>New instance of failed <see cref="Result{T}">Result</see> object.</returns>
		public static Result<T> CreateFailure<T>() where T : class
		{
			Result<T> result = new Result<T>
			{
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="Result{T}">Result</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <returns>New instance of failed <see cref="Result{T}">Result</see> object.</returns>
		public static Result<T> CreateFailure<T>(string errorMessage) where T : class
		{
			Result<T> result = new Result<T>
			{
				ErrorMessage = errorMessage,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="Result{T}">Result</see> object.
		/// </summary>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="Result{T}">Result</see> object.</returns>
		public static Result<T> CreateFailure<T>(Exception exception) where T : class
		{
			Result<T> result = new Result<T>
			{
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="Result{T}">Result</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="Result{T}">Result</see> object.</returns>
		public static Result<T> CreateFailure<T>(string errorMessage, Exception exception) where T : class
		{
			Result<T> result = new Result<T>
			{
				ErrorMessage = errorMessage,
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}
	}
}
