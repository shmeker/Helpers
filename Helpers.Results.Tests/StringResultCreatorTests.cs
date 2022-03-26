using System;
using Xunit;

namespace Helpers.Results.Tests
{
	public class StringResultCreatorTests
	{
		[Fact]
		public void CreateSuccess_Success()
		{
			string value = "Successful operation!";

			StringResult result = StringResultCreator.CreateSuccess(value);

			Assert.NotNull(result);
			Assert.True(result.IsSuccess);
			Assert.Null(result.ErrorMessage);
			Assert.Null(result.Exception);
			Assert.Equal("Successful operation!", result.Value);
		}

		[Fact]
		public void CreateFailure_Success()
		{
			StringResult result = StringResultCreator.CreateFailure();

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Equal(default, result.Value);
			Assert.Null(result.ErrorMessage);
			Assert.Null(result.Exception);
		}

		[Fact]
		public void CreateFailureWithErrorMessage_Success()
		{
			string errorMessage = "Failure occured.";

			StringResult result = StringResultCreator.CreateFailure(errorMessage);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Equal(default, result.Value);
			Assert.NotNull(result.ErrorMessage);
			Assert.Equal("Failure occured.", result.ErrorMessage);
			Assert.Null(result.Exception);
		}

		[Fact]
		public void CreateFailureWithException_Success()
		{
			Exception exception = new("Failure occured.");

			StringResult result = StringResultCreator.CreateFailure(exception);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Equal(default, result.Value);
			Assert.Null(result.ErrorMessage);
			Assert.NotNull(result.Exception);
			Assert.Equal("Failure occured.", result.Exception!.Message);
		}

		[Fact]
		public void CreateFailureWithErrorMessageAndException_Success()
		{
			string errorMessage = "Failer occured with error message.";
			Exception exception = new("Failure occured with Exception.");

			StringResult result = StringResultCreator.CreateFailure(errorMessage, exception);

			Assert.NotNull(result);
			Assert.False(result.IsSuccess);
			Assert.Equal(default, result.Value);
			Assert.NotNull(result.ErrorMessage);
			Assert.Equal("Failer occured with error message.", result.ErrorMessage);
			Assert.NotNull(result.Exception);
			Assert.Equal("Failure occured with Exception.", result.Exception!.Message);
		}
	}
}