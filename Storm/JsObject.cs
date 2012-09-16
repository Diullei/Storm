using System.Collections.Generic;

namespace Storm
{
    public abstract class JsObject
    {
        protected JsObject(IDebugger debugger)
        {
            Debugger = debugger;
        }

        public static Null Null { get { return new Null(); } }
        public static Undefined Undefined { get { return new Undefined(); } }

        protected IDebugger Debugger { get; private set; }

        public Dictionary<string, dynamic> PrivateMember = new Dictionary<string, dynamic>();
        public abstract object Exec();
    }
}