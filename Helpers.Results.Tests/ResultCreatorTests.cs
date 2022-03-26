using System;
using Xunit;

namespace Helpers.Results.Tests
{
	public class ResultCreatorTests
	{
		[Fact]
		public void CreateSuccess_Success()
		{
			TestData testData = new()
			{
				Id = 1,
				Name = "Test"
			};

			Result<TestData> result = ResultCreator.CreateSuccess(testData);

			Assert.NotNull(result);
			Assert.NotNull(result.Value);
			Assert.True(result.IsSuccess);
			Assert.Null(result.ErrorMessage);
			Assert.Null(result.Exception);
			Assert.Equal(1, result.Value!.Id);
			Assert.Equal("Test", result.Value!.Name);
		}

		[Fact]
		public void CreateFailure_Success()
		{
			Result<TestData> result = ResultCreator.CreateFailure<TestData>();

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Null(result.Value);
			Assert.Null(result.ErrorMessage);
			Assert.Null(result.Exception);
		}

		[Fact]
		public void CreateFailureWithErrorMessage_Success()
		{
			string errorMessage = "Failure occured.";

			Result<TestData> result = ResultCreator.CreateFailure<TestData>(errorMessage);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Null(result.Value);
			Assert.NotNull(result.ErrorMessage);
			Assert.Equal("Failure occured.", result.ErrorMessage);
			Assert.Null(result.Exception);
		}

		[Fact]
		public void CreateFailureWithException_Success()
		{
			Exception exception = new("Failure occured.");

			Result<TestData> result = ResultCreator.CreateFailure<TestData>(exception);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Null(result.Value);
			Assert.Null(result.ErrorMessage);
			Assert.NotNull(result.Exception);
			Assert.Equal("Failure occured.", result.Exception!.Message);
		}

		[Fact]
		public void CreateFailureWithErrorMessageAndException_Success()
		{
			string errorMessage = "Failer occured with error message.";
			Exception exception = new("Failure occured with Exception.");

			Result<TestData> result = ResultCreator.CreateFailure<TestData>(errorMessage, exception);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Null(result.Value);
			Assert.NotNull(result.ErrorMessage);
			Assert.Equal("Failer occured with error message.", result.ErrorMessage);
			Assert.NotNull(result.Exception);
			Assert.Equal("Failure occured with Exception.", result.Exception!.Message);
		}

		private class TestData
		{
			public int Id { get; set; }
			public string Name { get; set; } = string.Empty;
		}
	}
}