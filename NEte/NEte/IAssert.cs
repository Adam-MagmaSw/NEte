namespace NEte
{
    using System;

    public interface IAssert<T>
    {
        IAssert<T> And(Action<T> step);

        IAssert<T> And<T0>(Action<T, T0> step, T0 arg0);

        IAssert<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAssert<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAssert<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAssert<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAssert<T> And(Action<T> step, AssertOptions assertOptions);

        IAssert<T> And<T0>(Action<T, T0> step, T0 arg0, AssertOptions assertOptions);

        IAssert<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, AssertOptions assertOptions);

        IAssert<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, AssertOptions assertOptions);

        IAssert<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, AssertOptions assertOptions);

        IAssert<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AssertOptions assertOptions);

        IAssert<T> AndCritically(Action<T> step);

        IAssert<T> AndCritically<T0>(Action<T, T0> step, T0 arg0);

        IAssert<T> AndCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAssert<T> AndCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAssert<T> AndCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAssert<T> AndCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAssert<T> AndCritically(Action<T> step, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> AndCritically<T0>(Action<T, T0> step, T0 arg0, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> AndCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> AndCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> AndCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, CriticalAssertOptions<T> criticalAssertOptions);

        IAssert<T> AndCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CriticalAssertOptions<T> criticalAssertOptions);

        IArrange<T> SubsequentlyGiven(Action<T> step);

        IArrange<T> SubsequentlyGiven<T0>(Action<T, T0> step, T0 arg0);

        IArrange<T> SubsequentlyGiven<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IArrange<T> SubsequentlyGiven<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IArrange<T> SubsequentlyGiven<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IArrange<T> SubsequentlyGiven<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IAct<T> SubsequentlyWhen(Action<T> step);

        IAct<T> SubsequentlyWhen<T0>(Action<T, T0> step, T0 arg0);

        IAct<T> SubsequentlyWhen<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAct<T> SubsequentlyWhen<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAct<T> SubsequentlyWhen<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAct<T> SubsequentlyWhen<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        void RunTest();
    }
}