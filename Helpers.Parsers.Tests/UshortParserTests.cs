using Xunit;

namespace Helpers.Parsers.Tests
{
	public class UshortParserTests
	{
		[Theory]
		[InlineData("65535", 65535)]
		[InlineData("2584", 2584)]
		[InlineData("0", 0)]
		public void GetFromString_Success(string inputValue, ushort expectedResult)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("65536")]
		[InlineData("-1")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, ushort expectedResult)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, ushort expectedResult)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			ushort? parsedValue = UshortParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
