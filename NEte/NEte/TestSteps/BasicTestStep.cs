namespace NEte.TestSteps
{
    using System;
    using System.Text.RegularExpressions;

    internal class BasicTestStep<T>
    {
        public object OriginalAction { get; }
        protected readonly Action action;
        protected readonly string stepTextPrefix;
        protected string stepText;

        public BasicTestStep(object originalAction, Action<T> action, T context, string stepTextPrefix)
        {
            this.OriginalAction = originalAction;
            this.action = () => action(context);
            this.stepTextPrefix = stepTextPrefix;
            this.stepText = Regex.Replace(action.Method.Name, "(\\B[A-Z])", " $1");
        }

        public virtual TestStepResult RunStep()
        {
            Console.WriteLine(GetFullStepText());
            try
            {
                this.action.Invoke();
                return TestStepResult.SuccessfulResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string GetFullStepText()
        {
            return $"{this.stepTextPrefix} {this.stepText}";
        }
    }
}