namespace NEte
{
    using System;

    public interface IArrange<T>
    {
        IAct<T> When(Action<T> step);

        IAct<T> When<T0>(Action<T, T0> step, T0 arg0);

        IAct<T> When<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IAct<T> When<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IAct<T> When<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IAct<T> When<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

        IArrange<T> And(Action<T> step);

        IArrange<T> And<T0>(Action<T, T0> step, T0 arg0);

        IArrange<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1);

        IArrange<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2);

        IArrange<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3);

        IArrange<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    }
}