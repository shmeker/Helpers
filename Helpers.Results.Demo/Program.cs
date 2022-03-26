// See https://aka.ms/new-console-template for more information

using Helpers.Results.Demo;
using System.Text.Json;

Console.WriteLine("Results data per methods:");
Console.WriteLine();
Console.WriteLine("Result");
Console.WriteLine($" -> {nameof(ResultDemo.GetResultSuccess)}: {JsonSerializer.Serialize(ResultDemo.GetResultSuccess())}");
Console.WriteLine($" -> {nameof(ResultDemo.GetResultFailure)}: {JsonSerializer.Serialize(ResultDemo.GetResultFailure())}");
Console.WriteLine($" -> {nameof(ResultDemo.GetResultFailureWithErrorMessage)}: {JsonSerializer.Serialize(ResultDemo.GetResultFailureWithErrorMessage())}");
Console.WriteLine($" -> {nameof(ResultDemo.GetResultFailureWithException)}: {JsonSerializer.Serialize(ResultDemo.GetResultFailureWithException())}");
Console.WriteLine($" -> {nameof(ResultDemo.GetResultFailureWithErrorMessageAndException)}: {JsonSerializer.Serialize(ResultDemo.GetResultFailureWithErrorMessageAndException())}");
Console.WriteLine();
Console.WriteLine("ValueResult");
Console.WriteLine($" -> {nameof(ValueResultDemo.GetResultSuccess)}: {JsonSerializer.Serialize(ValueResultDemo.GetResultSuccess())}");
Console.WriteLine($" -> {nameof(ValueResultDemo.GetResultFailure)}: {JsonSerializer.Serialize(ValueResultDemo.GetResultFailure())}");
Console.WriteLine($" -> {nameof(ValueResultDemo.GetResultFailureWithErrorMessage)}: {JsonSerializer.Serialize(ValueResultDemo.GetResultFailureWithErrorMessage())}");
Console.WriteLine($" -> {nameof(ValueResultDemo.GetResultFailureWithException)}: {JsonSerializer.Serialize(ValueResultDemo.GetResultFailureWithException())}");
Console.WriteLine($" -> {nameof(ValueResultDemo.GetResultFailureWithErrorMessageAndException)}: {JsonSerializer.Serialize(ValueResultDemo.GetResultFailureWithErrorMessageAndException())}");
Console.WriteLine();
Console.WriteLine("StringResult");
Console.WriteLine($" -> {nameof(StringResultDemo.GetResultSuccess)}: {JsonSerializer.Serialize(StringResultDemo.GetResultSuccess())}");
Console.WriteLine($" -> {nameof(StringResultDemo.GetResultFailure)}: {JsonSerializer.Serialize(StringResultDemo.GetResultFailure())}");
Console.WriteLine($" -> {nameof(StringResultDemo.GetResultFailureWithErrorMessage)}: {JsonSerializer.Serialize(StringResultDemo.GetResultFailureWithErrorMessage())}");
Console.WriteLine($" -> {nameof(StringResultDemo.GetResultFailureWithException)}: {JsonSerializer.Serialize(StringResultDemo.GetResultFailureWithException())}");
Console.WriteLine($" -> {nameof(StringResultDemo.GetResultFailureWithErrorMessageAndException)}: {JsonSerializer.Serialize(StringResultDemo.GetResultFailureWithErrorMessageAndException())}");