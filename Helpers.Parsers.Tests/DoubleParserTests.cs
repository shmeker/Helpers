using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Helpers.Parsers.Tests
{
	public class DoubleParserTests : IDisposable
	{
		private readonly string culture = "en-US";

		private readonly CultureInfo originalCulture;
		private readonly CultureInfo originalUICulture;

		public DoubleParserTests()
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
					new object[]{ "1.79769313486232E+308", double.PositiveInfinity },
					new object[]{ "-1.79769313486232E+308", double.NegativeInfinity },
					new object[]{ "1.79769313486231E+308", 1.79769313486231E+308 },
					new object[]{ "-1.79769313486231E+308", -1.79769313486231E+308 },
					new object[]{ "158.21477", 158.21477 }
				};
			}
		
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void GetFromString_Success(string inputValue, double expectedResult)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData("Random")]
		[InlineData("")]
		[InlineData(null)]
		public void GetFromString_Failure(string inputValue)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData('1', 1)]
		[InlineData('9', 9)]
		[InlineData('0', 0)]
		public void GetFromChar_Success(char inputValue, double expectedResult)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData('d')]
		[InlineData('F')]
		[InlineData(' ')]
		[InlineData(null)]
		public void GetFromChar_Failure(char inputValue)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

			Assert.Null(parsedValue);
		}

		[Theory]
		[InlineData(true, 1)]
		[InlineData(false, 0)]
		public void GetFromBool_Success(bool? inputValue, double expectedResult)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

			Assert.Equal(expectedResult, parsedValue);
		}

		[Theory]
		[InlineData(null)]
		public void GetFromBool_Failure(bool? inputValue)
		{
			double? parsedValue = DoubleParser.Get(inputValue);

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
