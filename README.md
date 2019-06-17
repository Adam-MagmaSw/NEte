# Introduction
NEte is an NUnit based BDD framework specifically aimed at end-to-end test scenarios (that's not to say it can't be used for other testing scenarios just that it contains features specifically aimed at end-to-end testing).

Typically end-to-end tests are expensive and unreliable, NEte aims to tackle these issues by:
* Allowing asserts to be retried for a specified number of times (with a specified delay between retries) - this feature allows for scenarios where there is likely to be a delay before an assert becomes true and the test can move on to a subsequent section/assert
* Allowing tests to specify asserts as either non-critical or critical, where if a critical assert fails the test will stop immediately but if a non-critical assert fails the test will continue but report failure at the end - because end-to-end tests are expensive and slow this feature allows for a single test to verify as many criteria as possible
* Allowing whole sections of tests to be re-executed a set number of times if a critical assert fails - because end-to-end test environments can be unreliable this feature allows for a test to detect an issue and retry one or more steps rather than simply fail

# Enough talk, show me some examples!
## Simple Example
In this example we specify a simple test with two steps, the first places an order, the second checks for a dispatch note:
```cs
using NEte;
using NUnit.Framework;

namespace NEteExamples
{
    [TestFixture]
    public class PlaceOrderTests
    {
        [Test]
        public void When_An_Order_Is_Placed_Then_The_Order_Should_Be_Processed_And_Dispatched()
        {
            EndToEndTestJourney<OrderTestContext>
                .When(IPlaceAnOrder)
                .ThenCritically(ADispatchNoteIsCreatedForTheOrder)
                .RunTest();
        }

        private void IPlaceAnOrder(OrderTestContext context)
        {
            context.OrderReference = OrderPlacementFacade.PlaceOrder();
        }

        private void ADispatchNoteIsCreatedForTheOrder(OrderTestContext context)
        {
            var dispatchNote = DispatchNoteRepository.GetDispatchNoteForOrder(context.OrderReference);

            Assert.That(dispatchNote, Is.Not.Null);
            Assert.That(dispatchNote, Has.Property("OrderReference").EqualTo(context.OrderReference));
        }
    }

    public class OrderTestContext
    {
        public string OrderReference { get; set; }
    }
}
```
NEte will construct a new context at the beginning of each test, in order for that to work NEte requires the test context to have a default constructor.
## Retry Example
This example builds on the previous example. The previous example assumes the dispatch note will be present immediately but it's highly likely one or more processes will need to take place between the order being placed and a dispatch note being created so let's introduce the ability to retry that assert by specifying some CriticalAssertOptions:
```cs
using System;
using NEte;
using NUnit.Framework;

namespace NEteExamples
{
    [TestFixture]
    public class PlaceOrderTestsWithRetry
    {
        [Test]
        public void When_An_Order_Is_Placed_Then_The_Order_Should_Be_Processed_And_Dispatched()
        {
            EndToEndTestJourney<OrderTestContext>
                .When(IPlaceAnOrder)
                .ThenCritically(ADispatchNoteIsCreatedForTheOrder, new CriticalAssertOptionsBuilder<OrderTestContext>().RetryAssert(5, TimeSpan.FromSeconds(5))
                .RunTest();
        }

        private void IPlaceAnOrder(OrderTestContext context)
        {
            context.OrderReference = OrderPlacementFacade.PlaceOrder();
        }

        private void ADispatchNoteIsCreatedForTheOrder(OrderTestContext context)
        {
            var dispatchNote = DispatchNoteRepository.GetDispatchNoteForOrder(context.OrderReference);

            Assert.That(dispatchNote, Is.Not.Null);
            Assert.That(dispatchNote, Has.Property("OrderReference").EqualTo(context.OrderReference));
        }
    }

    public class OrderTestContext
    {
        public string OrderReference { get; set; }
    }
}

```
The following line of code is the relevant bit in the above example:
```cs
.ThenCritically(ADispatchNoteIsCreatedForTheOrder, new CriticalAssertOptionsBuilder<OrderTestContext>().RetryAssert(5, TimeSpan.FromSeconds(5))
```
It's essentially saying that if an assert fails within the ADispatchNoteIsCreatedForTheOrder method then NEte should retry that method up to 5 times (so a total of 6 attempts) with a delay of 5 seconds between each attempt.