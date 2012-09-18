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

        public void SetFunction(string name, Delegate function) { Actions[name.Replace("$", "")] = function; }

        public void SetFunction<T>(string name, Action<T> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2>(string name, Action<T1, T2> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3>(string name, Action<T1, T2, T3> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4>(string name, Action<T1, T2, T3, T4> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5>(string name, Action<T1, T2, T3, T4, T5> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6>(string name, Action<T1, T2, T3, T4, T5, T6> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7>(string name, Action<T1, T2, T3, T4, T5, T6, T7> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) { Actions[name.Replace("$", "@")] = function; }
        public void SetFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string name, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) { Actions[name.Replace("$", "@")] = function; }
    }
}