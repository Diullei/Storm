namespace Storm
{
    public class Code
    {
        public string CsCode { get; set; }

        public string GetCsCode(dynamic tree)
        {
            return CsCode = tree.ToString();
        }
    }
}