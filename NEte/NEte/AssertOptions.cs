namespace NEte
{
    using System;

    public class AssertOptions
    {
        public int AssertRetryAttempts { get; }
        
        public TimeSpan StandOffPeriod { get; }

        internal AssertOptions(int assertRetryAttempts, TimeSpan standOffPeriod)
        {
            AssertRetryAttempts = assertRetryAttempts;
            StandOffPeriod = standOffPeriod;
        }
    }
}