namespace NEte.TestSteps
{
    using System;

    using NUnit.Framework;
    public class TestStepResult
    {
        public TestStepOutcome Outcome { get; }

        public AssertionException AssertionException { get; }

        public object RetryAction { get; }

        public int? RetryAttemptCount { get; }

        public TimeSpan? RetryStandOffPeriod { get; }

        private TestStepResult(TestStepOutcome outcome, AssertionException assertionException, object retryAction, int? retryAttemptCount, TimeSpan? retryStandOffPeriod)
        {
            this.Outcome = outcome;
            this.AssertionException = assertionException;
            this.RetryAction = retryAction;
            this.RetryAttemptCount = retryAttemptCount;
            this.RetryStandOffPeriod = retryStandOffPeriod;
        }

        public static TestStepResult SuccessfulResult()
        {
            return new TestStepResult(TestStepOutcome.Success, null, null, null, null);
        }

        public static TestStepResult NonCriticalFailureResult(AssertionException assertionException)
        {
            return new TestStepResult(TestStepOutcome.NonCrucialFailure, assertionException, null, null, null);
        }

        public static TestStepResult FailureResult(AssertionException assertionException)
        {
            return new TestStepResult(TestStepOutcome.Failed, assertionException, null, null, null);
        }

        public static TestStepResult FailureResultWithTestRetry(AssertionException assertionException, int testRetryAttempts, TimeSpan testRetryStandOffPeriod, object actionToReturnToOnTestFailure)
        {
            return new TestStepResult(TestStepOutcome.Failed, assertionException, actionToReturnToOnTestFailure, testRetryAttempts, testRetryStandOffPeriod);
        }
    }
}