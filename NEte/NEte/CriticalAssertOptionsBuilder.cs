namespace NEte
{
    using System;
    public class CriticalAssertOptionsBuilder<T>
    {
        private int? assertRetryAttempts;
        private TimeSpan? assertRetryStandOffPeriod;
        private int? testRetryAttempts;
        private TimeSpan? testRetryStandOffPeriod;
        private object actionToReturnToOnTestFailure;

        public CriticalAssertOptionsBuilder<T> RetryAssert(int assertRetryAttempts, TimeSpan assertRetryStandOffPeriod)
        {
            if (assertRetryAttempts < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(assertRetryAttempts), "assertRetryAttempts must be a positive number.");
            }

            this.assertRetryAttempts = assertRetryAttempts;
            this.assertRetryStandOffPeriod = assertRetryStandOffPeriod;

            return this;
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure<T0>(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T, T0> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure<T0, T1>(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T, T0, T1> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure<T0, T1, T2>(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T, T0, T1, T2> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure<T0, T1, T2, T3>(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T, T0, T1, T2, T3> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        public CriticalAssertOptionsBuilder<T> RetryTestUponFailure<T0, T1, T2, T3, T4>(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, Action<T, T0, T1, T2, T3, T4> actionToReturnToOnTestFailure)
        {
            return InternalRetryTestUponFailure(testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
        }

        private CriticalAssertOptionsBuilder<T> InternalRetryTestUponFailure(int testRetryAttempts, TimeSpan testRetryStandOffPeriod, object actionToReturnToOnTestFailure)
        {
            if (testRetryAttempts < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(testRetryAttempts),
                    "testRetryAttempts must be a positive number.");
            }

            this.testRetryAttempts = testRetryAttempts;
            this.testRetryStandOffPeriod = testRetryStandOffPeriod;
            this.actionToReturnToOnTestFailure = actionToReturnToOnTestFailure ?? throw new ArgumentNullException(nameof(actionToReturnToOnTestFailure));

            return this;
        }

        public CriticalAssertOptions<T> Build()
        {
            var result = new CriticalAssertOptions<T>(assertRetryAttempts, assertRetryStandOffPeriod, testRetryAttempts, testRetryStandOffPeriod, actionToReturnToOnTestFailure);
            return result;
        }
    }
}