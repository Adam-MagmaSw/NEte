namespace NEte.UnitTests
{
    using System;

    using NUnit.Framework;

    public class AssertAndRetryTests
    {
        // ensure assert retries do actually retry the correct amount of times

        // ensure tests keep running after a non-critical assert failure

        // ensure critical assert retries do actually retry the correct amount of times

        // ensure tests don't keep running after critical asserts fail

        // ensure test re-runs do actually re-run from the correct place

        // ensure when an assert fails the test fails

        // ensure when an assert passes the test passes

        // ensure test retry actions fail validation when action appears multiple times

        // ensure test retry actions fail validation when action doesn't appear in test

        [Test]
        public void RunSomeTest()
        {
            EndToEndTestJourney<TestContext>
                .Given(SomeArrangeStepIsPerformed)
                .When(SomeActionIsPerformed)
                .Then(SomethingIsAsserted)
                .RunTest();
        }

        [Test]
        public void RunSomeTestWhichFails()
        {
            EndToEndTestJourney<TestContext>
                .Given(SomeArrangeStepIsPerformed)
                .When(SomeActionIsPerformed)
                .Then(SomethingIsAssertedFalse)
                .RunTest();
        }

        [Test]
        public void RunSomeTestWhichFailsAndRetries()
        {
            EndToEndTestJourney<TestContext>
                .Given(SomeArrangeStepIsPerformed)
                .When(SomeActionIsPerformed)
                .Then(SomethingIsAssertedFalse, AssertOptionsBuilder.RetryAssert(3, TimeSpan.FromSeconds(1)))
                .RunTest();
        }

        [Test]
        public void RunSomeTestWhichFailsAndRetriesTheTest()
        {
            EndToEndTestJourney<TestContext>
                .Given(SomeArrangeStepIsPerformed)
                .When(SomeActionIsPerformed)
                .ThenCritically(SomethingIsAssertedFalse, new CriticalAssertOptionsBuilder<TestContext>().RetryTestUponFailure(3, TimeSpan.FromSeconds(1), SomeActionIsPerformed).Build())
                .RunTest();
        }

        [Test]
        public void RunSomeTestWithInvalidRetryConfig()
        {
            EndToEndTestJourney<TestContext>
                .Given(SomeArrangeStepIsPerformed)
                .When(SomeActionIsPerformed)
                .And(SomeActionIsPerformed)
                .ThenCritically(SomethingIsAssertedFalse, new CriticalAssertOptionsBuilder<TestContext>().RetryTestUponFailure(3, TimeSpan.FromSeconds(1), SomeActionIsPerformed).Build())
                .RunTest();
        }

        public void SomeArrangeStepIsPerformed(TestContext c)
        {
            c.SomeString = "String!!!";
        }

        public void SomeActionIsPerformed(TestContext c)
        {
            c.SomeString = "New String...";
        }

        public void SomethingIsAsserted(TestContext c)
        {
            Assert.That(c.SomeString, Is.EqualTo("New String..."));
        }

        public void SomethingIsAssertedFalse(TestContext c)
        {
            Assert.That(c.SomeString, Is.EqualTo(string.Empty));
        }
    }
}