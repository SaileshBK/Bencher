using Bencher.Interfaces;
using ErrorOr;

namespace Bencher.Functions;

public class Error_Or : IError_Or
{
	public string UsingError_Or()
	{
		var result = MethodUsingError_OrThrowingUnexpected(1);

		if (result.IsError)
		{
			return result.FirstError.Description; 
		}
		return string.Empty;

	}
	public string NotUsingError_Or()
	{
		try
		{
			return MethodThrowingException(1);

		}
		catch (Exception ex)
		{
			return ex.Message; 
		}
	}

	public string MethodThrowingException(int value)
	{
		if (value == 1)
		{
			throw new Exception("Oh no!");
		}
		return string.Empty;
	}

	private ErrorOr<string> MethodUsingError_OrThrowingUnexpected(int value)
	{
		if (value == 1)
		{
			return Error.Unexpected(description: "Oh no!");
		}
		return string.Empty;
	}
}
