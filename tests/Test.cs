using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests;

internal abstract class Test<T>
{
    public abstract TestResult<T> Run();
}

internal class TestResult<T>(T value)
{
    public T Value { get; } = value;
    public List<T> ExpectedValues { get; } = [];
    public List<Action<T>> PassActions { get; } = [];
    public List<Action<T>> FailActions { get; } = [];


    public TestResult<T> Expect(T value)
    {
        ExpectedValues.Add(value);
        return this;
    }

    public TestResult<T> OnPass(Action<T> action)
    {
        PassActions.Add(action);
        return this;
    }

    public TestResult<T> OnFail(Action<T> action)
    {
        FailActions.Add(action);
        return this;
    }

    public bool Check()
    {
        foreach (var expected in ExpectedValues)
        {
            if ((expected == null && Value == null) || (expected != null && expected.Equals(Value)))
            {
                PassActions.ForEach(action => action.Invoke(Value));
                return true;
            }
        }

        FailActions.ForEach(action => action.Invoke(Value));
        return false;
    }
}
