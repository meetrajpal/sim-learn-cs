namespace ConsoleApp1
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Length;
            }
            else
            {
                return 0;
            }
        }
    }

    public static class ArrayExtension
    {
        public static int MyGetLength(this Array arr)
        {
            return arr.Length;
        }
    }
}