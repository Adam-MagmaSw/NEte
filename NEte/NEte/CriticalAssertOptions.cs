namespace NEte
{
    using System;
    public class CriticalAssertOptions<T>
    {
        public int? AssertRetryAttempts { get; }

        public TimeSpan? AssertRetryAttemptStandOffPeriod { get; }

        public int? TestRetryAttempts { get; }

        public TimeSpan? TestRetryStandOffPeriod { get; }

        public object ActionToReturnToOnTestFailure { get; }

        internal CriticalAssertOptions(int? assertRetryAttempts, TimeSpan? assertRetryAttemptStandOffPeriod, int? testRetryAttempts, TimeSpan? testRetryStandOffPeriod, object actionToReturnToOnTestFailure)
        {
            AssertRetryAttempts = assertRetryAttempts;
            AssertRetryAttemptStandOffPeriod = assertRetryAttemptStandOffPeriod;
            TestRetryAttempts = testRetryAttempts;
            TestRetryStandOffPeriod = testRetryStandOffPeriod;
            ActionToReturnToOnTestFailure = actionToReturnToOnTestFailure;
        }
    }
}