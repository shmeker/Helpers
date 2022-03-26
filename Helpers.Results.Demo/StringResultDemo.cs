namespace Helpers.Results.Demo
{
	internal static class StringResultDemo
	{
		internal static StringResult GetResultSuccess()
		{
			return StringResultCreator.CreateSuccess("Success message.");
		}

		internal static StringResult GetResultFailure()
		{
			return StringResultCreator.CreateFailure();
		}

		internal static StringResult GetResultFailureWithErrorMessage()
		{
			return StringResultCreator.CreateFailure("Error occured.");
		}

		internal static StringResult GetResultFailureWithException()
		{
			return StringResultCreator.CreateFailure(new Exception("Exception occured."));
		}

		internal static StringResult GetResultFailureWithErrorMessageAndException()
		{
			return StringResultCreator.CreateFailure("Error occured.", new Exception("Exception occured."));
		}
	}
}
