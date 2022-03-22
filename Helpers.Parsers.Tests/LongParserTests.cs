using Xunit;

namespace Helpers.Parsers.Tests
{
	public class LongParserTests
	{
		[Theory]
		[InlineData("9223372036854775807", 9223372036854775807)]
		[InlineData("-9223372036854775808", -9223372036854775808)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, long expectedResult)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("9223372036854775808")]
		[InlineData("-9223372036854775809")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, long expectedResult)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, long expectedResult)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			long? parsedValue = LongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
