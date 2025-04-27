namespace GameStoreWebApp.ExternalServiceBroker.Helpers;

public static class RetryHelper
{
    public static async Task<T> RetryOnFailureAsync<T>(
        Func<Task<T>> action,
        int maxRetries,
        TimeSpan delay,
        Func<Exception, bool>? shouldRetry = null)
    {
        for (int retry = 0; retry < maxRetries; retry++)
        {
            try
            {
                return await action();
            }
            catch (Exception ex) when (retry < maxRetries - 1 && (shouldRetry?.Invoke(ex) ?? true))
            {
                await Task.Delay(delay);
            }
        }
        throw new Exception("The operation failed after the maximum number of retries.");
    }

    public static async Task RetryOnFailureAsync(
        Func<Task> action,
        int maxRetries,
        TimeSpan delay,
        Func<Exception, bool>? shouldRetry = null)
    {
        for (int retry = 0; retry < maxRetries; retry++)
        {
            try
            {
                await action();
                return;
            }
            catch (Exception ex) when (retry < maxRetries - 1 && (shouldRetry?.Invoke(ex) ?? true))
            {
                await Task.Delay(delay);
            }
        }
        throw new Exception("The operation failed after the maximum number of retries.");
    }
}


