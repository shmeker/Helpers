namespace Helpers.Results.Demo
{
	internal static class ResultDemo
	{
		internal static Result<DemoData> GetResultSuccess()
		{
			DemoData demoData = new()
			{
				Id = 1,
				Name = "Data 1"
			};

			return ResultCreator.CreateSuccess(demoData);
		}

		internal static Result<DemoData> GetResultFailure()
		{
			return ResultCreator.CreateFailure<DemoData>();
		}

		internal static Result<DemoData> GetResultFailureWithErrorMessage()
		{
			return ResultCreator.CreateFailure<DemoData>("Error occured.");
		}

		internal static Result<DemoData> GetResultFailureWithException()
		{
			return ResultCreator.CreateFailure<DemoData>(new Exception("Exception occured."));
		}

		internal static Result<DemoData> GetResultFailureWithErrorMessageAndException()
		{
			return ResultCreator.CreateFailure<DemoData>("Error occured.", new Exception("Exception occured."));
		}

		internal class DemoData
		{
			public int Id { get; set; }
			public string Name { get; set; } = string.Empty;
		}
	}
}
