namespace Storm
{
    public class Null
    {
        public override bool Equals(object obj)
        {
            return (obj is Null);
        }

        public bool Equals(Null other)
        {
            return !ReferenceEquals(null, other);
        }

        public static bool operator !=(object a, Null b)
        {
            return !(a is Null);
        }

        public static bool operator ==(object a, Null b)
        {
            return !(a != b);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "null";
        }
    }
}