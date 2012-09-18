using System;
using System.Collections.Generic;

namespace Storm
{
    public class Context
    {
        public Context(Scope scope)
        {
            Scope = scope;
            DeclaredVarNames = new List<string>();
        }

        public Scope Scope { get; set; }

        public List<string> DeclaredVarNames { get; set; }

        public Dictionary<string, object> Actions = new Dictionary<string, object>();

        private void AddFn(string name, Delegate function)
        {
            Actions[name.Replace("$", "@")] = function;
        }

        public void SetFunction(string name, Delegate function) { AddFn(name, function); }

        public void SetFunction<T1, TR>(string name, Func<T1, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, TR>(string name, Func<T1, T2, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, TR>(string name, Func<T1, T2, T3, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, TR>(string name, Func<T1, T2, T3, T4, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, TR>(string name, Func<T1, T2, T3, T4, T5, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, TR>(string name, Func<T1, T2, T3, T4, T5, T6, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TR> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR>(string name, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TR> function) { AddFn(name, function); }

        public void SetFunction<T>(string name, Action<T> function) { AddFn(name, function); }
        public void SetFunction<T1, T2>(string name, Action<T1, T2> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3>(string name, Action<T1, T2, T3> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4>(string name, Action<T1, T2, T3, T4> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5>(string name, Action<T1, T2, T3, T4, T5> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6>(string name, Action<T1, T2, T3, T4, T5, T6> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7>(string name, Action<T1, T2, T3, T4, T5, T6, T7> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) { AddFn(name, function); }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) { AddFn(name, function); }
    }
}