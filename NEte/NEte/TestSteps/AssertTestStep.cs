namespace NEte.TestSteps
{
    using System;

    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using Polly;

    internal class AssertTestStep<T> : BasicTestStep<T>
    {
        public AssertOptions AssertOptions { get; }

        public AssertTestStep(object originalAction, Action<T> action, T context, string stepTextPrefix)
            : base(originalAction, action, context, stepTextPrefix)
        {
            this.AssertOptions = null;
        }

        public AssertTestStep(object originalAction, Action<T> action, T context, string stepTextPrefix, AssertOptions assertOptions)
            : base(originalAction, action, context, stepTextPrefix)
        {
            this.AssertOptions = assertOptions;
        }

        public override TestStepResult RunStep()
        {
            Console.WriteLine(this.GetFullStepText());

            using (new TestExecutionContext.IsolatedContext())
            {
                try
                {
                    RunMultipleTimes(this.action, this.AssertOptions?.AssertRetryAttempts ?? 0, this.AssertOptions?.StandOffPeriod ?? TimeSpan.Zero);
                    return TestStepResult.SuccessfulResult();
                }
                catch (AssertionException e)
                {
                    Console.WriteLine($"  Non-critical Assert failure: {e}\r\n");
                    return TestStepResult.NonCriticalFailureResult(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        protected static void RunMultipleTimes(Action action, int retryCount, TimeSpan standOff)
        {
            var isolatedContext = new TestExecutionContext.IsolatedContext();
            try
            {
                Policy.Handle<AssertionException>().WaitAndRetry(retryCount, i => standOff, (ex, ts, rc, c) =>
                {
                    isolatedContext.Dispose();
                    isolatedContext = new TestExecutionContext.IsolatedContext();
                    Console.WriteLine($"  Assert failed: {ex.Message}\r\n  Retrying assert...\r\n");
                    TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Clear();
                }).Execute(action);
            }
            finally
            {
                isolatedContext.Dispose();
            }
        }
    }
}