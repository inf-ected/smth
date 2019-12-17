using System;
using System.IO;

namespace FileTextRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // А теперь выводим информацию из файла на консоль при помощи 
            // StreamReader 
            Console.WriteLine("Here are your students:\n");
            StreamReader sr = File.OpenText("Students.txt");
            //string input = null;
            //while ((input = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(input);
            //    //Console.ReadKey();
            //}
            //sr.Close();
            //string s1 = ",ONE,,TWO,,,THREE,,";
            //char[] charSeparators = new char[] { ',' };
            //string []result;
            //result = s1.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string input = null;
            string[] fio;
            input = sr.ReadLine();
            Console.WriteLine(input);
            char[] charSeparators = new char[] { ' ' };
            fio = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ss in fio)
                Console.WriteLine(ss);
            Console.WriteLine("--------------------------------------1");
            sr.Close();

            //-2-------------------------------------------------------------------------
            StreamReader sr1 = File.OpenText("Students.txt");
            input = sr1.ReadLine();
            while (input  != null)
            {
                Console.WriteLine(input);
                if (input != null)
                {
                    fio = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string ss in fio)
                        Console.WriteLine(ss);
                    input = sr1.ReadLine();
                }
               
                //Console.ReadKey();
            }
            sr.Close();
            //-3-------------------------------------------------
            // string alldata = sr.ReadToEnd();
            // sr.Close();
            Console.WriteLine("Чтение по 8 байт");
            sr = File.OpenText("Students.txt");
            //This is an arbitrary size for this example.
            char[] c = null;

            while (sr.Peek() >= 0)
            {
                c = new char[8];//Fam
                sr.Read(c, 0, c.Length);
                Console.WriteLine(c);
                c = new char[8];//Im
                sr.Read(c, 0, c.Length);
                Console.WriteLine(c);
                c = new char[10];//Data
                sr.Read(c, 0, c.Length);
                //The output will look odd, because
                //only five characters are read at a time.
                Console.WriteLine(c);
                Console.ReadKey();
            }
            sr.Close();

        }
    }
}
