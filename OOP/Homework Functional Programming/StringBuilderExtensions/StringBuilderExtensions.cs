namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder sb, int startIndex, int lenght)
        {
            if ((startIndex - 1 > sb.Length) || (startIndex - 1 + lenght > sb.Length))
            {
                throw new IndexOutOfRangeException("Out beyond the length of the StringBuilder length");
            }

            string result = string.Empty;
            for (int i = 0; i < sb.Length; i++)
            {
                if ((i >= startIndex - 1) && (lenght > 0))
                {
                    result += sb[i];
                    lenght--;
                }
            }

            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder sb, string text)
        {
            sb.Replace(text, string.Empty);
            return sb;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
        {
            return sb.Append(string.Join(string.Empty, items));
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Test StringBuilder");
            sb.Append("Append somehting");
            sb.Append("Test");
            Console.WriteLine("sb:" + sb);
            string result = sb.Substring(6, 6);
            Console.WriteLine("result:" + result);
            sb.RemoveText("Test");
            Console.WriteLine("sb:" + sb);
            sb.AppendAll("asd");
            IEnumerable<double> numbers = new List<double>() { 1.2, 3, 1.5 };
            sb.AppendAll(numbers);
            Console.WriteLine("sb:" + sb);
        }
    }
}
