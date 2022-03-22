using Xunit;

namespace Helpers.Parsers.Tests
{
	public class SbyteParserTests
	{
		[Theory]
		[InlineData("100", 100)]
		[InlineData("127", 127)]
		[InlineData("-128", -128)]
		public void GetFromString_Success(string inputValue, sbyte expectedResult)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("128")]
		[InlineData("-129")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, sbyte expectedResult)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, sbyte expectedResult)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			sbyte? parsedValue = SbyteParser.Get(inputValue);

			Assert.Null(parsedValue);
		}
	}
}
