using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fio;
            char sep = ' ';
            StreamReader sr = File.OpenText(@"D:\qqq\ConsoleApplication12\ConsoleApplication12\bin\Debug\Student.txt");
            string input = null;
            input = sr.ReadToEnd();
            Console.WriteLine(input);
            Regex reg = new Regex(@"[A-Z]");
            MatchCollection mat = reg.Matches(input);
            int i = 0;
            foreach (Match match in mat)
                Console.WriteLine("Найденное значение: " + match.Value);
            Console.WriteLine(mat.Count);
            sr.Close();
            Console.ReadKey();
        }
    }
}
