namespace Storm
{
    public class Debugger : IDebugger
    {
        public string Source { get; set; }

        public void BreakPoint(int start, int end, int lineStart, int colStart, int lineEnd, int colEnd)
        {
        }

        public void BreakPoint(JsObject instance)
        {
        }

        public void SetSourceCode(string source)
        {
        }
    }
}