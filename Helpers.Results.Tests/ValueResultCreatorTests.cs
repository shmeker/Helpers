using System;
using Xunit;

namespace Helpers.Results.Tests
{
	public class ValueResultCreatorTests
	{
		[Fact]
		public void CreateSuccess_Success()
		{
			int value = 11;

			ValueResult<int> result = ValueResultCreator.CreateSuccess(value);

			Assert.NotNull(result);
			Assert.True(result.IsSuccess);
			Assert.Null(result.ErrorMessage);
			Assert.Null(result.Exception);
			Assert.Equal(11, result.Value);
		}

		[Fact]
		public void CreateFailure_Success()
		{
			ValueResult<int> result = ValueResultCreator.CreateFailure<int>();

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

			ValueResult<int> result = ValueResultCreator.CreateFailure<int>(errorMessage);

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

			ValueResult<int> result = ValueResultCreator.CreateFailure<int>(exception);

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

			ValueResult<int> result = ValueResultCreator.CreateFailure<int>(errorMessage, exception);

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