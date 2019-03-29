namespace NEte
{
    using System;

    public static class EndToEndTestJourney<T> where T : new()
    {
        public static IArrange<T> Given(Action<T> givenAction)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction);

            return journey;
        }

        public static IAct<T> When(Action<T> assertAction)
        {
            throw new NotImplementedException();
        }
    }
}