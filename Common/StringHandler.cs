namespace Common
{
    public static class StringHandler
    {
        public static string InserSpaces(this string source)
        {
            string result = string.Empty;
            if(!String.IsNullOrWhiteSpace(source))
            {
                foreach(char ch in source)
                {
                    if(char.IsUpper(ch))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                result+= ch;
                }
            }
            result = result.Trim();
        return result;
        }
    }
}