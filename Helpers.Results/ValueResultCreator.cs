using System;

namespace Helpers.Results
{
	/// <summary>
	/// Static class that creates new instaces of <see cref="ValueResult{T}">ValueResult</see> class.
	/// </summary>
	public static class ValueResultCreator
	{
		/// <summary>
		/// Method that creates success <see cref="ValueResult{T}">ValueResult</see> object.
		/// </summary>
		/// <param name="value">Value of successful operation.</param>
		/// <returns>New instance of success <see cref="ValueResult{T}">ValueResult</see> object.</returns>
		public static ValueResult<T> CreateSuccess<T>(T value) where T : unmanaged
		{
			ValueResult<T> result = new ValueResult<T>
			{
				Value = value,
				IsSuccess = true
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="ValueResult{T}">ValueResult</see> object.
		/// </summary>
		/// <returns>New instance of failed <see cref="ValueResult{T}">ValueResult</see> object.</returns>
		public static ValueResult<T> CreateFailure<T>() where T : unmanaged
		{
			ValueResult<T> result = new ValueResult<T>
			{
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="ValueResult{T}">ValueResult</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <returns>New instance of failed <see cref="ValueResult{T}">ValueResult</see> object.</returns>
		public static ValueResult<T> CreateFailure<T>(string errorMessage) where T : unmanaged
		{
			ValueResult<T> result = new ValueResult<T>
			{
				ErrorMessage = errorMessage,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="ValueResult{T}">ValueResult</see> object.
		/// </summary>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="ValueResult{T}">ValueResult</see> object.</returns>
		public static ValueResult<T> CreateFailure<T>(Exception exception) where T : unmanaged
		{
			ValueResult<T> result = new ValueResult<T>
			{
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}

		/// <summary>
		/// Method that creates failed <see cref="ValueResult{T}">ValueResult</see> object.
		/// </summary>
		/// <param name="errorMessage">Message that describes the failed state.</param>
		/// <param name="exception">Exception that occured during the operation.</param>
		/// <returns>New instance of failed <see cref="ValueResult{T}">ValueResult</see> object.</returns>
		public static ValueResult<T> CreateFailure<T>(string errorMessage, Exception exception) where T : unmanaged
		{
			ValueResult<T> result = new ValueResult<T>
			{
				ErrorMessage = errorMessage,
				Exception = exception,
				IsSuccess = false
			};

			return result;
		}
	}
}
