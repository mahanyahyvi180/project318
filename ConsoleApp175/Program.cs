using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp175
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "This sentence ends in 5 stars *****";
            string testString2 = "1,2,3,4,5,6,7,8";
            Regex testRegex1 = new Regex(@"\d");
            string output = string.Empty;

            Console.WriteLine("First test string:{0}", testString1);

            testString1 = Regex.Replace(testString1, @"\*", "^");
            Console.WriteLine("^ substited for * :{0}", testString1);

            testString1 = Regex.Replace(testString1, "stars", "carets");
            Console.WriteLine("\"carets\"substituted for \"stars\":{0}", testString1);

            Console.WriteLine("Every word replaced by\"word\":{0}", Regex.Replace(testString1, @"\w+", "word"));

            Console.WriteLine("Second test string:{0}", testString2);

            Console.Write("String split at commas [");

            string[] result = Regex.Split(testString2, @",\s");

            foreach (var resultString in result)
                output += "\"" + resultString + "\",";

            Console.WriteLine(output.Substring(0, output.Length - 2) + "]");

            Console.ReadLine();
        }
    }
}
