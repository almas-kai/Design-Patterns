public static class ResultExtensions
{
    public static Result<TOut> Map<TIn, TOut>(this Result<TIn> result, Func<TIn, TOut> func)
    {
		if (result.IsFailure)
		{
            return Result<TOut>.Failure(result.Error!);
		}

        return Result<TOut>.Success(func(result.Value!));
    }

    public static Result<TOut> Bind<TIn, TOut>(this Result<TIn> result, Func<TIn, Result<TOut>> func)
    {
		if (result.IsFailure)
		{
            return Result<TOut>.Failure(result.Error!);
		}

        return func(result.Value!);
    }

    public static void Match<T>(this Result<T> result, Action<T> onSuccess, Action<string> onFailure)
    {
		if (result.IsSuccess)
		{
			onSuccess(result.Value!);
			return;
		}

		onFailure(result.Error!);
    }
}
