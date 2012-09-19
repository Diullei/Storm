using System;
using System.Collections.Generic;
using System.Dynamic;
using Esprima.NET.Ex;

namespace Storm
{
    public abstract class JsObject : DynamicObject
    {
        protected JsObject(IDebugger debugger)
        {
            Debugger = debugger;
        }

        public static Null Null { get { return new Null(); } }

        public static Undefined Undefined { get { return new Undefined(); } }

        public static NaN NaN { get { return new NaN(); } }

        public static object PlusPlus(object value, bool prefix)
        {
            try
            {
                var number = Convert.ToInt32(value);
                if(prefix)
                    return ++number;
                return number++;
            }
            catch (Exception)
            {
                return NaN;
            }
        }

        public Undefined undefined { get { return new Undefined(); } }

        protected IDebugger Debugger { get; private set; }

        public Dictionary<string, dynamic> PrivateMember = new Dictionary<string, dynamic>();

        public abstract object Exec();

        public Dictionary<string, object> DynamicProperties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            DynamicProperties[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (!DynamicProperties.ContainsKey(binder.Name))
                throw new ReferenceError(binder.Name);
            result = DynamicProperties[binder.Name];
            return true;
        }
    }
}