using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Helpers.Parsers.Tests
{
	public class DecimalParserTests : IDisposable
	{
		private readonly string culture = "en-US";

		private readonly CultureInfo originalCulture;
		private readonly CultureInfo originalUICulture;

		public DecimalParserTests()
		{
			originalCulture = Thread.CurrentThread.CurrentCulture;
			originalUICulture = Thread.CurrentThread.CurrentUICulture;

			Thread.CurrentThread.CurrentCulture = new CultureInfo(culture, false);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, false);

			CultureInfo.CurrentCulture.ClearCachedData();
			CultureInfo.CurrentUICulture.ClearCachedData();
		}

		public static IEnumerable<object[]> TestData
		{
			get
			{
				return new List<object[]>
				{
					new object[]{ "79228162514264337593543950335", 79228162514264337593543950335m },
					new object[]{ "-79228162514264337593543950335", -79228162514264337593543950335m },
					new object[]{ "158.21477", 158.21477m }
				};
			}
		
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void GetFromString_Success(string inputValue, decimal expectedResult)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("79228162514264337593543950336")]
		[InlineData("-79228162514264337593543950336")]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, decimal expectedResult)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, decimal expectedResult)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			decimal? parsedValue = DecimalParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		public void Dispose()
		{
			Thread.CurrentThread.CurrentCulture = originalCulture;
			Thread.CurrentThread.CurrentUICulture = originalUICulture;

			CultureInfo.CurrentCulture.ClearCachedData();
			CultureInfo.CurrentUICulture.ClearCachedData();
		}
	}
}
