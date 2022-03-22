using Xunit;

namespace Helpers.Parsers.Tests
{
	public class UlongParserTests
	{
		[Theory]
		[InlineData("18446744073709551615", 18446744073709551615)]
		[InlineData("9856888421", 9856888421)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, ulong expectedResult)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("18446744073709551616")]
		[InlineData("-1")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, ulong expectedResult)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, ulong expectedResult)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			ulong? parsedValue = UlongParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
