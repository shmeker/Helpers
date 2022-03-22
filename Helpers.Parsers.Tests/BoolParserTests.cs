using Xunit;

namespace Helpers.Parsers.Tests
{
	public class BoolParserTests
	{
		[Theory]
		[InlineData("True", true)]
		[InlineData("False", false)]
		public void GetFromString_Success(string inputValue, bool expectedResult)
		{
			bool? parsedValue = BoolParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("15")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			bool? parsedValue = BoolParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}