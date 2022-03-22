using Xunit;

namespace Helpers.Parsers.Tests
{
	public class UintParserTests
	{
		[Theory]
		[InlineData("4294967295", 4294967295)]
		[InlineData("15", 15)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, uint expectedResult)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("4294967296")]
		[InlineData("-1")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, uint expectedResult)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, uint expectedResult)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			uint? parsedValue = UintParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
