namespace NEte
{
    using System;

    public static class AssertOptionsBuilder
    {
        public static AssertOptions RetryAssert(int assertRetryAttempts, TimeSpan standOffPeriod)
        {
            if (assertRetryAttempts < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(assertRetryAttempts), "assertRetryAttempts must be a positive number.");
            }

            return new AssertOptions(assertRetryAttempts, standOffPeriod);
        }
    }
}