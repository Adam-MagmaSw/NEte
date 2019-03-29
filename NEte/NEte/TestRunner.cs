namespace NEte
{
    using System.Collections.Generic;
    using System.Linq;

    using NEte.TestSteps;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    internal static class TestRunner
    {
        public static void RunTest<T>(List<BasicTestStep<T>> testSteps)
        {
            var assertionExceptions = new List<AssertionException>();
            var retryCounts = new Dictionary<int, int>();

            // TODO: Validate all 'go-tos'

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
                    TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Clear();
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
                }
            }

            if (assertionExceptions.Any())
            {
                throw new AssertionException(null, assertionExceptions.Last());
            }
        }
    }
}