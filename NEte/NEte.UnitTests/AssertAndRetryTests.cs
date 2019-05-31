namespace NEte.UnitTests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;

    public class AssertAndRetryTests
    {
        private int someStepIsExecutedExecutionTimes = 0;

        [SetUp]
        public void SetUp()
        {
            someStepIsExecutedExecutionTimes = 0;
        }

        [Test]
        public void Given_A_Test_With_A_Non_Critical_Assert_Step_With_Assert_Options_Defined_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Assert_Is_Retried_The_Correct_Number_Of_Times()
        {
            int calls = 0;

            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => { })
                    .Then(_ =>
                    {
                        calls++;
                        Assert.That(1, Is.EqualTo(2));
                    }, AssertOptionsBuilder.RetryAssert(14, TimeSpan.Zero))
                    .RunTest();
            }

            Assert.That(calls, Is.EqualTo(15));
        }

        [Test]
        public void Given_A_Test_With_A_Non_Critical_Assert_Step_With_Assert_Options_Defined_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Test_Fails()
        {
            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => { })
                    .Then(_ => Assert.That(1, Is.EqualTo(2)), AssertOptionsBuilder.RetryAssert(5, TimeSpan.Zero))
                    .RunTest();

                Assert.That(TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Count, Is.EqualTo(1));
                Assert.That(TestExecutionContext.CurrentContext.CurrentResult.AssertionResults.Single().Status, Is.EqualTo(AssertionStatus.Failed));
                Assert.That(TestExecutionContext.CurrentContext.CurrentResult.FailCount, Is.EqualTo(1));
                Assert.That(TestExecutionContext.CurrentContext.CurrentResult.ResultState, Is.EqualTo(ResultState.Failure));
            }
        }

        [Test]
        public void Given_A_Test_With_A_Non_Critical_Assert_Step_And_A_Subsequent_Step_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Subsequent_Step_Is_Executed()
        {
            int calls = 0;

            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => { })
                    .Then(_ => Assert.That(1, Is.EqualTo(2)))
                    .And(_ => calls++)
                    .RunTest();
            }

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Assert_Options_Defined_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Assert_Is_Retried_The_Correct_Number_Of_Times()
        {
            int calls = 0;

            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => { })
                    .ThenCritically(_ =>
                    {
                        calls++;
                        Assert.That(1, Is.EqualTo(2));
                    }, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(14, TimeSpan.Zero).Build())
                    .RunTest();
            }

            Assert.That(calls, Is.EqualTo(15));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_And_A_Subsequent_Step_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Subsequent_Step_Is_Not_Executed()
        {
            int calls = 0;

            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => { })
                    .ThenCritically(_ => Assert.That(1, Is.EqualTo(2)))
                    .And(_ => calls++)
                    .RunTest();
            }

            Assert.That(calls, Is.Zero);
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Assert_Options_Defined_When_The_Test_Is_Executed_And_The_Assert_Fails_Then_The_Test_Is_Retried_From_The_Correct_Place()
        {
            int whenCalls = 0;
            int andCalls = 0;

            using (new TestExecutionContext.IsolatedContext())
            {
                EndToEndTestJourney<TestContext>
                    .When(_ => whenCalls++)
                    .And(SomeStepIsExecuted)
                    .And(_ => andCalls++)
                    .ThenCritically(_ => Assert.That(1, Is.EqualTo(2)), new CriticalAssertOptionsBuilder<TestContext>().RetryTestUponFailure(3, TimeSpan.FromSeconds(1), SomeStepIsExecuted).Build())
                    .RunTest();
            }

            Assert.That(whenCalls, Is.EqualTo(1));
            Assert.That(someStepIsExecutedExecutionTimes, Is.EqualTo(4));
            Assert.That(andCalls, Is.EqualTo(4));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Asserts_That_All_Pass_When_The_Test_Is_Executed_Then_The_Test_Passes()
        {
            EndToEndTestJourney<TestContext>
                .When(_ => { })
                .Then(_ => Assert.That(1, Is.EqualTo(1)))
                .AndCritically(_ => Assert.That(1, Is.EqualTo(1)))
                .RunTest();
        }

        [Test]
        public void Given_A_Test_With_The_Same_Action_Executed_Multiple_Times_And_A_Critical_Assert_Step_With_Assert_Options_Defined_Which_Retries_The_Test_At_That_Action_When_The_Test_Is_Executed_Then_The_Test_Fails_Due_To_Incorrect_Configuration()
        {
            Assert.That(() =>
                EndToEndTestJourney<TestContext>
                    .Given(_ => { })
                    .When(SomeStepIsExecuted)
                    .And(SomeStepIsExecuted)
                    .ThenCritically(_ => Assert.That(0, Is.EqualTo(1)), new CriticalAssertOptionsBuilder<TestContext>().RetryTestUponFailure(3, TimeSpan.FromSeconds(1), SomeStepIsExecuted).Build())
                    .RunTest(),
                Throws.InvalidOperationException);
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Assert_Options_Defined_Which_Retries_The_Test_At_An_Action_Which_Is_Not_Part_Of_The_Test_When_The_Test_Is_Executed_Then_The_Test_Fails_Due_To_Incorrect_Configuration()
        {
            Assert.That(() =>
                EndToEndTestJourney<TestContext>
                    .Given(_ => { })
                    .When(_ => { })
                    .ThenCritically(_ => Assert.That(0, Is.EqualTo(1)), new CriticalAssertOptionsBuilder<TestContext>().RetryTestUponFailure(3, TimeSpan.FromSeconds(1), SomeStepIsExecuted).Build())
                    .RunTest(),
                Throws.InvalidOperationException);
        }

        [Test]
        public void Given_A_Test_With_Multiple_Steps_When_The_Test_Is_Executed_Then_A_New_Context_Is_Created_And_Passed_To_Every_Step()
        {
            TestContext context = null;

            EndToEndTestJourney<TestContext>
                .Given(c => { Assert.That(c, Is.Not.Null); context = c; })
                .When(c => Assert.That(c, Is.EqualTo(context)))
                .Then(c => Assert.That(c, Is.EqualTo(context)))
                .AndCritically(c => Assert.That(c, Is.EqualTo(context)))
                .RunTest();
        }

        private void SomeStepIsExecuted(TestContext c)
        {
            someStepIsExecutedExecutionTimes++;
        }
    }
}