namespace NEte
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NEte.TestSteps;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;

    internal static class TestRunner
    {
        public static void RunTest<T>(List<BasicTestStep<T>> testSteps)
        {
            var assertionExceptions = new List<AssertionException>();
            var retryCounts = new Dictionary<int, int>();

            ValidateTestRetryPoints(testSteps);

            for (int stepIndex = 0; stepIndex < testSteps.Count; stepIndex++)
            {
                var step = testSteps[stepIndex];

                var result = step.RunStep();

                if (result.Outcome == TestStepOutcome.Success)
                {
                    continue;
                }

                if (result.Outcome == TestStepOutcome.NonCrucialFailure)
                {
                    assertionExceptions.Add(result.AssertionException);
                    continue;
                }

                if (result.Outcome == TestStepOutcome.Failed && result.RetryAction == null)
                {
                    assertionExceptions.Add(result.AssertionException);
                    break;
                }
                else
                {
                    if (!retryCounts.ContainsKey(stepIndex))
                    {
                        retryCounts.Add(stepIndex, 0);
                    }

                    if (retryCounts[stepIndex] >= (result.RetryAttemptCount ?? 0))
                    {
                        assertionExceptions.Add(result.AssertionException);
                        break;
                    }

                    var actionToReturnTo = testSteps.Single(s => s.OriginalAction.Equals(result.RetryAction));
                    retryCounts[stepIndex]++;
                    stepIndex = testSteps.IndexOf(actionToReturnTo) - 1;
                    Console.WriteLine($"  Critical Assert failure, re-running test from step \"{actionToReturnTo.GetFullStepText()}\"\r\n");
                    if (result.RetryStandOffPeriod.HasValue)
                    {
                        Task.Delay(result.RetryStandOffPeriod.Value);
                    }
                }
            }

            if (assertionExceptions.Any())
            {
                TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Add(new AssertionResult(AssertionStatus.Failed, assertionExceptions.Last().Message, assertionExceptions.Last().StackTrace));
                TestExecutionContext.CurrentContext.CurrentResult.RecordException(assertionExceptions.Last());
                TestExecutionContext.CurrentContext.CurrentResult.SetResult(ResultState.Failure);
            }
        }

        private static void ValidateTestRetryPoints<T>(List<BasicTestStep<T>> testSteps)
        {
            var invalidActions = testSteps.OfType<CriticalAssertTestStep<T>>().Where(ts =>
                ts.CriticalAssertOptions?.ActionToReturnToOnTestFailure != null
                && testSteps.Count(s =>
                    s.OriginalAction.Equals(ts.CriticalAssertOptions.ActionToReturnToOnTestFailure)) != 1).ToList();

            if (invalidActions.Any())
            {
                var invalidActionString = string.Join(",", invalidActions.Select(a => "\"" + a.GetFullStepText() + "\""));

                throw new InvalidOperationException(
                    new StringBuilder(invalidActions.Count == 1 ? $"The following test step is " : "The following test steps are ")
                        .Append("configured to retry the test but either the action they are set to retry from isn't part of the test or is used multiple times in the test: ")
                        .Append(invalidActionString).ToString());
            }
        }
    }
}