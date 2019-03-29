namespace NEte
{
    using System;

    public interface IAct<T>
    {
        IAct<T> And(Action<T> step);

        IAct<T> And<T0>(Action<T, T0> step, T0 arg0);

        IAct<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAct<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAct<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAct<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAssert<T> Then(Action<T> step);

        IAssert<T> Then<T0>(Action<T, T0> step, T0 arg0);

        IAssert<T> Then<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAssert<T> Then<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAssert<T> Then<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAssert<T> Then<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAssert<T> Then(Action<T> step, AssertOptions assertOptions);

        IAssert<T> Then<T0>(Action<T, T0> step, T0 arg0, AssertOptions assertOptions);

        IAssert<T> Then<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, AssertOptions assertOptions);

        IAssert<T> Then<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, AssertOptions assertOptions);

        IAssert<T> Then<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, AssertOptions assertOptions);

        IAssert<T> Then<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AssertOptions assertOptions);

        IAssert<T> ThenCritically(Action<T> step);

        IAssert<T> ThenCritically<T0>(Action<T, T0> step, T0 arg0);

        IAssert<T> ThenCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAssert<T> ThenCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAssert<T> ThenCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAssert<T> ThenCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAssert<T> ThenCritically(Action<T> step, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> ThenCritically<T0>(Action<T, T0> step, T0 arg0, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> ThenCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> ThenCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> ThenCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> ThenCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CriticalAssertOptions<T> criticalAssertOptions);
    }
}