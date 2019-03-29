namespace NEte.UnitTests
{
    using System;

    using NEte;
    using NUnit.Framework;

    [TestFixture]
    public class TestStepExecutionTests
    {
        [Test]
        public void Given_A_Test_With_An_Arrange_Step_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .Given(c => calls++)
                .When(c => {})
                .Then(c => {})
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0) 
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_Defined_When_The_Test_Is_Executed_Then_The_Second_Arrange_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And(c => calls++)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Arrange_Steps_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .And((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => calls++)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Arrange_And_An_Act_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => calls++)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Act_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_Defined_When_The_Test_Is_Executed_Then_The_Second_Act_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => calls++)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => { })
                .And((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => { })
                .And((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => { })
                .And((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => { })
                .And((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Act_Steps_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .Given(c => { })
                .When(c => { })
                .And((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => calls++)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically(c => calls++)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => calls++, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_An_Assert_Step_With_Assert_Options_Defined_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically(c => calls++, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Critical_Assert_Step_With_Critical_Assert_Options_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .ThenCritically((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => calls++)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => calls++, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_1_Arg_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_2_Args_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_3_Args_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_4_Args_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_5_Args_With_Assert_Options_Defined_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .And((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4, AssertOptionsBuilder.RetryAssert(1, TimeSpan.Zero))
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .AndCritically(c => calls++)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_1_Arg_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_2_Args_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_3_Args_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_4_Args_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_5_Args_Defined_Where_The_Second_Is_Critical_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically(c => calls++, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_1_Arg_Defined_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_2_Args_Defined_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_3_Args_Defined_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_4_Args_Defined_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_Multiple_Assert_Steps_With_5_Args_Defined_Where_The_Second_Is_Critical_And_Has_Critical_Assert_Options_When_The_Test_Is_Executed_Then_The_Second_Assert_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .Then(c => { })
                .AndCritically((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4, new CriticalAssertOptionsBuilder<TestContext>().RetryAssert(1, TimeSpan.Zero).Build())
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven(c => calls++)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Arrange_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Arrange_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyGiven((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .When(c => { })
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen(c => calls++)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_With_1_Arg_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen((c, a0) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                }, arg0)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_With_2_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen((c, a0, a1) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                }, arg0, arg1)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_With_3_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen((c, a0, a1, a2) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                }, arg0, arg1, arg2)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_With_4_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen((c, a0, a1, a2, a3) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                }, arg0, arg1, arg2, arg3)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }

        [Test]
        public void Given_A_Test_With_A_Subsequent_Act_Step_With_5_Args_Defined_When_The_Test_Is_Executed_Then_The_Subsequent_Act_Step_Is_Executed()
        {
            int calls = 0;
            var arg0 = Guid.NewGuid().ToString();
            var arg1 = Guid.NewGuid().ToString();
            var arg2 = Guid.NewGuid().ToString();
            var arg3 = Guid.NewGuid().ToString();
            var arg4 = Guid.NewGuid().ToString();

            EndToEndTestJourney<TestContext>
                .When(c => { })
                .And(c => { })
                .Then(c => { })
                .And(c => { })
                .SubsequentlyWhen((c, a0, a1, a2, a3, a4) =>
                {
                    calls++;
                    Assert.That(a0, Is.EqualTo(arg0));
                    Assert.That(a1, Is.EqualTo(arg1));
                    Assert.That(a2, Is.EqualTo(arg2));
                    Assert.That(a3, Is.EqualTo(arg3));
                    Assert.That(a4, Is.EqualTo(arg4));
                }, arg0, arg1, arg2, arg3, arg4)
                .Then(c => { })
                .RunTest();

            Assert.That(calls, Is.EqualTo(1));
        }
    }
}