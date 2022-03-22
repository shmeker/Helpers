using Xunit;

namespace Helpers.Parsers.Tests
{
	public class IntParserTests
	{
		[Theory]
		[InlineData("2147483647", 2147483647)]
		[InlineData("-2147483648", -2147483648)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, int expectedResult)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("2147483648")]
		[InlineData("-2147483649")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, int expectedResult)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, int expectedResult)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			int? parsedValue = IntParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
