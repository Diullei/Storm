namespace Storm
{
    public class NaN
    {
        public override bool Equals(object obj)
        {
            return (obj is NaN);
        }

        public bool Equals(NaN other)
        {
            return !ReferenceEquals(null, other);
        }

        public static bool operator !=(object a, NaN b)
        {
            return !(a is NaN);
        }

        public static bool operator ==(object a, NaN b)
        {
            return !(a != b);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "NaN";
        }
    }
}