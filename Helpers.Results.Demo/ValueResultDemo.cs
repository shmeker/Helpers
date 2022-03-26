namespace Helpers.Results.Demo
{
	internal static class ValueResultDemo
	{
		internal static ValueResult<int> GetResultSuccess()
		{
			return ValueResultCreator.CreateSuccess(101);
		}

		internal static ValueResult<int> GetResultFailure()
		{
			return ValueResultCreator.CreateFailure<int>();
		}

		internal static ValueResult<int> GetResultFailureWithErrorMessage()
		{
			return ValueResultCreator.CreateFailure<int>("Error occured.");
		}

		internal static ValueResult<int> GetResultFailureWithException()
		{
			return ValueResultCreator.CreateFailure<int>(new Exception("Exception occured."));
		}

		internal static ValueResult<int> GetResultFailureWithErrorMessageAndException()
		{
			return ValueResultCreator.CreateFailure<int>("Error occured.", new Exception("Exception occured."));
		}
	}
}
