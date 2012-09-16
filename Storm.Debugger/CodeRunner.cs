using System;

namespace Storm.Debugger
{
    public class CodeRunner
    {
        private readonly IDebugger _debugger;
        private readonly string _source;

        private Context Context { get; set; }
        private Code CodeGenerator { get; set; }

        public CodeRunner(IDebugger debugger, string source)
        {
            _debugger = debugger;
            _source = source;

            Context = new Context(new Scope());
            CodeGenerator = new Code();
        }

        public void Run()
        {
            var script = Script.Compile(CodeGenerator, Context, _source, _debugger);
            script.OnFinish += script_OnFinish;
            script.Run();
        }

        void script_OnFinish(object sender, EventArgs e)
        {
            OnFinish(null, null);
        }

        public event EventHandler<EventArgs> OnFinish;
    }
}