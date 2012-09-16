namespace Storm
{
    public class Context
    {
        public Context(Scope scope)
        {
            Scope = scope;
        }

        public Scope Scope { get; private set; }
    }
}