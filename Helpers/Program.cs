// See https://aka.ms/new-console-template for more information
using Helpers.Parsers;
using System.Globalization;

string culture = "en-US";
Thread.CurrentThread.CurrentCulture = new CultureInfo(culture, false);
Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, false);

string testString1 = "-1472";
string testString2 = "12.32";
char testChar1 = '6';
char testChar2 = 'd';
bool testBool = true;

string rowFormat = " {0}		| {1}		| {2}		| {3}		| {4}		| {5}";

Console.WriteLine("Demo parsing various values:");
Console.WriteLine($" Parser			| \"{testString1}\"	| \"{testString2}\"	| '{testChar1}'		| '{testChar2}'		| {testBool}	");

WriteBoolValues(nameof(BoolParser), BoolParser.Get);
WriteValues(nameof(ByteParser), ByteParser.Get, ByteParser.Get, ByteParser.Get);
WriteValues(nameof(DecimalParser), DecimalParser.Get, DecimalParser.Get, DecimalParser.Get);
WriteValues(nameof(DoubleParser), DoubleParser.Get, DoubleParser.Get, DoubleParser.Get);
WriteValues(nameof(FloatParser), FloatParser.Get, FloatParser.Get, FloatParser.Get);
WriteValues(nameof(IntParser), IntParser.Get, IntParser.Get, IntParser.Get);
WriteValues(nameof(LongParser), LongParser.Get, LongParser.Get, LongParser.Get);
WriteValues(nameof(SbyteParser), SbyteParser.Get, SbyteParser.Get, SbyteParser.Get);
WriteValues(nameof(ShortParser), ShortParser.Get, ShortParser.Get, ShortParser.Get);
WriteValues(nameof(UintParser), UintParser.Get, UintParser.Get, UintParser.Get);
WriteValues(nameof(UlongParser), UlongParser.Get, UlongParser.Get, UlongParser.Get);
WriteValues(nameof(UshortParser), UshortParser.Get, UshortParser.Get, UshortParser.Get);

void WriteBoolValues(string parserName, Func<string, bool?> stringFunc)
{
	string value = string.Format(rowFormat, parserName, stringFunc(testString1), stringFunc(testString2), "N/A", "N/A", "N/A");

	Console.WriteLine(value);
}

void WriteValues<T>(string parserName, Func<string, T?> stringFunc, Func<char, T?> charFunc, Func<bool?, T?> boolFunc)
{
	string value = string.Format(rowFormat, parserName, stringFunc(testString1), stringFunc(testString2), charFunc(testChar1), charFunc(testChar2), boolFunc(testBool));

	Console.WriteLine(value);
}
