using System;
using System.Text.RegularExpressions;

namespace RegexAppExample
{
    class Program
    {
        static void ExampleStringSplit()
        {
            var str = "Wuck World,Hello world.My wonderful world:Hello world"; //,.:
    
            Console.WriteLine("Base String:");
            Console.WriteLine(str);
            Console.WriteLine();
            //===========================================================================
            //html
            //var pattern = @"(\< (/?[^\>] +)\>) ";

            //var pattern = @"\b[M]\w+";
            var pattern = @"[,.:]+";

            var arr_str = Regex.Split(str, pattern);
            var rg = new Regex(pattern);

            Console.WriteLine("String Array:");
            foreach (string value in arr_str)
            {
                Console.WriteLine("               " + value);
            }
            Console.WriteLine();
            
            //===========================================================================
            str = "Asd2323b0900c1234Def5678Ghi9012Jklm";
            Console.WriteLine(str);

            pattern = "[a-z]+";
            string[] result = Regex.Split(str, pattern,
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("'{0}'", result[i]);
                if (i < result.Length - 1)
                    Console.Write(", ");
            }

            //===========================================================================
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Regex Example");
            ExampleStringSplit();
            Console.ReadKey();
        }
    }
}
