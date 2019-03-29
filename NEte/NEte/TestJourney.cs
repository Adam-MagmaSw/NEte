namespace NEte
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.RegularExpressions;

    using NEte.TestSteps;

    internal class TestJourney<T> : IArrange<T>, IAct<T>, IAssert<T>
    {
        private readonly List<BasicTestStep<T>> testSteps = new List<BasicTestStep<T>>();
        private readonly T context;

        public TestJourney(T context)
        {
            this.context = context;
        }

        #region Arrange
        public IArrange<T> Given(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IArrange<T> Given<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> Given<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> Given<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> Given<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> Given<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IArrange<T> IArrange<T>.And(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        IArrange<T> IArrange<T>.And<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IArrange<T> IArrange<T>.And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IArrange<T> IArrange<T>.And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IArrange<T> IArrange<T>.And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IArrange<T> IArrange<T>.And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> SubsequentlyGiven(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IArrange<T> SubsequentlyGiven<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> SubsequentlyGiven<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> SubsequentlyGiven<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> SubsequentlyGiven<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IArrange<T> SubsequentlyGiven<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }
        #endregion

        #region Act
        public IAct<T> When(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAct<T> When<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> When<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> When<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> When<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> When<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IAct<T> IAct<T>.And(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        IAct<T> IAct<T>.And<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IAct<T> IAct<T>.And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IAct<T> IAct<T>.And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IAct<T> IAct<T>.And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        IAct<T> IAct<T>.And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> SubsequentlyWhen(Action<T> step)
        {
            this.testSteps.Add(new BasicTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAct<T> SubsequentlyWhen<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> SubsequentlyWhen<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> SubsequentlyWhen<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> SubsequentlyWhen<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAct<T> SubsequentlyWhen<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new BasicTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }
        #endregion

        #region Assert
        public IAssert<T> And(Action<T> step)
        {
            this.testSteps.Add(new AssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAssert<T> And<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> And(Action<T> step, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod()), assertOptions));
            return this;
        }

        public IAssert<T> And<T0>(Action<T, T0> step, T0 arg0, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> And<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> And<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> And<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> And<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> AndCritically(Action<T> step)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAssert<T> AndCritically<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> AndCritically(Action<T> step, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod()), criticalAssertOptions));
            return this;
        }

        public IAssert<T> AndCritically<T0>(Action<T, T0> step, T0 arg0, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> AndCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> Then(Action<T> step)
        {
            this.testSteps.Add(new AssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAssert<T> Then<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> Then<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> Then(Action<T> step, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod()), assertOptions));
            return this;
        }

        public IAssert<T> Then<T0>(Action<T, T0> step, T0 arg0, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> Then<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> Then<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AssertOptions assertOptions)
        {
            this.testSteps.Add(new AssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                assertOptions));

            return this;
        }

        public IAssert<T> ThenCritically(Action<T> step)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod())));
            return this;
        }

        public IAssert<T> ThenCritically<T0>(Action<T, T0> step, T0 arg0)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod())));

            return this;
        }

        public IAssert<T> ThenCritically(Action<T> step, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step, step, this.context, GetTextFromMethod(MethodBase.GetCurrentMethod()), criticalAssertOptions));
            return this;
        }

        public IAssert<T> ThenCritically<T0>(Action<T, T0> step, T0 arg0, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1>(Action<T, T0, T1> step, T0 arg0, T1 arg1, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2>(Action<T, T0, T1, T2> step, T0 arg0, T1 arg1, T2 arg2, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2, T3>(Action<T, T0, T1, T2, T3> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }

        public IAssert<T> ThenCritically<T0, T1, T2, T3, T4>(Action<T, T0, T1, T2, T3, T4> step, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CriticalAssertOptions<T> criticalAssertOptions)
        {
            this.testSteps.Add(new CriticalAssertTestStep<T>(step,
                c =>
                {
                    step.Invoke(c, arg0, arg1, arg2, arg3, arg4);
                },
                this.context,
                GetTextFromMethod(MethodBase.GetCurrentMethod()),
                criticalAssertOptions));

            return this;
        }
        #endregion

        public void RunTest()
        {
            TestRunner.RunTest(this.testSteps);
        }

        private string GetTextFromMethod(MethodBase method)
        {
            return Regex.Replace(GetAllAfterLastIndexOf(',', method.Name), "(\\B[A-Z])", " $1");
        }

        private string GetAllAfterLastIndexOf(char character, string text)
        {
            var pos = text.LastIndexOf(".") + 1;
            return text.Substring(pos, text.Length - pos);
        }
    }
}
