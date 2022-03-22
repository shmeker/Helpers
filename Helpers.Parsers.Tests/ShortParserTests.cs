using Xunit;

namespace Helpers.Parsers.Tests
{
	public class ShortParserTests
	{
		[Theory]
		[InlineData("32767", 32767)]
		[InlineData("-32768", -32768)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, short expectedResult)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("32768")]
		[InlineData("-32769")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, short expectedResult)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, short expectedResult)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			short? parsedValue = ShortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
