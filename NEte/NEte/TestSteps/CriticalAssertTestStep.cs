namespace NEte.TestSteps
{
    using System;

    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using Polly;

    internal class CriticalAssertTestStep<T> : BasicTestStep<T>
    {
        public CriticalAssertOptions<T> CriticalAssertOptions { get; }

        public CriticalAssertTestStep(object originalAction, Action<T> action, T context, string stepTextPrefix)
            : base(originalAction, action, context, stepTextPrefix)
        {
            this.CriticalAssertOptions = null;
        }

        public CriticalAssertTestStep(object originalAction, Action<T> action, T context, string stepTextPrefix, CriticalAssertOptions<T> criticalAssertOptions)
            : base(originalAction, action, context, stepTextPrefix)
        {
            this.CriticalAssertOptions = criticalAssertOptions;
        }
        public override TestStepResult RunStep()
        {
            Console.WriteLine(this.GetStepText());

            try
            {
                RunMultipleTimes(this.action, this.CriticalAssertOptions?.AssertRetryAttempts ?? 0, this.CriticalAssertOptions?.AssertRetryAttemptStandOffPeriod ?? TimeSpan.Zero);
                return TestStepResult.SuccessfulResult();
            }
            catch (AssertionException e)
            {
                TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Clear();

                Console.WriteLine(e);

                if (this.CriticalAssertOptions != null 
                    && this.CriticalAssertOptions.TestRetryAttempts.HasValue 
                    && this.CriticalAssertOptions.TestRetryStandOffPeriod.HasValue
                    && this.CriticalAssertOptions.ActionToReturnToOnTestFailure != null)
                {
                    return TestStepResult.FailureResultWithTestRetry(e, this.CriticalAssertOptions.TestRetryAttempts.Value, this.CriticalAssertOptions.TestRetryStandOffPeriod.Value, this.CriticalAssertOptions.ActionToReturnToOnTestFailure);
                }

                return TestStepResult.FailureResult(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        protected static void RunMultipleTimes(Action action, int retryCount, TimeSpan standOff)
        {
            Policy.Handle<AssertionException>().WaitAndRetry(retryCount, i => standOff, (ex, ts, rc, c) =>
            {
                Console.WriteLine($"\tAssert failed, retrying...");
                TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Clear();
            }).Execute(action);
        }
    }
}