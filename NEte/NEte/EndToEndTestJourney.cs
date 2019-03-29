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

        public static IArrange<T> Given<T0>(Action<T, T0> givenAction, T0 arg0)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction, arg0);

            return journey;
        }

        public static IArrange<T> Given<T0, T1>(Action<T, T0, T1> givenAction, T0 arg0, T1 arg1)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction, arg0, arg1);

            return journey;
        }

        public static IArrange<T> Given<T0, T1, T2>(Action<T, T0, T1, T2> givenAction, T0 arg0, T1 arg1, T2 arg2)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction, arg0, arg1, arg2);

            return journey;
        }

        public static IArrange<T> Given<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> givenAction, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction, arg0, arg1, arg2, arg3);

            return journey;
        }

        public static IArrange<T> Given<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> givenAction, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var journey = new TestJourney<T>(new T());
            journey.Given(givenAction, arg0, arg1, arg2, arg3, arg4);

            return journey;
        }

        public static IAct<T> When(Action<T> whenAction)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction);

            return journey;
        }

        public static IAct<T> When<T0>(Action<T, T0> whenAction, T0 arg0)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction, arg0);

            return journey;
        }

        public static IAct<T> When<T0, T1>(Action<T, T0, T1> whenAction, T0 arg0, T1 arg1)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction, arg0, arg1);

            return journey;
        }

        public static IAct<T> When<T0, T1, T2>(Action<T, T0, T1, T2> whenAction, T0 arg0, T1 arg1, T2 arg2)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction, arg0, arg1, arg2);

            return journey;
        }

        public static IAct<T> When<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> whenAction, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction, arg0, arg1, arg2, arg3);

            return journey;
        }

        public static IAct<T> When<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> whenAction, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var journey = new TestJourney<T>(new T());
            journey.When(whenAction, arg0, arg1, arg2, arg3, arg4);

            return journey;
        }
    }
}