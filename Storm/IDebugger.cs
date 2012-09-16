namespace Storm
{
    public interface IDebugger
    {
        void BreakPoint(int start, int end, int lineStart, int colStart, int lineEnd, int colEnd);
        void BreakPoint(JsObject instance);
    }
}