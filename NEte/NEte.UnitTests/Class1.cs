namespace NEte.UnitTests
{
    using System;
    using System.Diagnostics;

    using NEte;
    using NUnit.Framework;

    [TestFixture]
    public class Class1
    {
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

    public class TestContext
    {
        public string SomeString { get; set; }
    }
}