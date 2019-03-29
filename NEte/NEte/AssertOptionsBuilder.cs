namespace NEte
{
    using System;

    public static class AssertOptionsBuilder
    {
        public static AssertOptions RetryAssert(int assertRetryAttempts, TimeSpan standOffPeriod)
        {
            return new AssertOptions(assertRetryAttempts, standOffPeriod);
        }
    }
}