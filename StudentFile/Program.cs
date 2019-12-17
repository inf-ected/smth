using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studentz;
using System.IO;

namespace StudentFile
{
    class Program
    {
        static void Main(string[] args)
        {

           // #region
           // Student s1 = new Student("Ivanov", "Ivan", "30/07/1986");
           // Student s11 = new Student("Petrov", "Petr", DateTime.Now);
           // Student s12 = new Student("Petrescu", "Petru", new DateTime(2001, 9, 29));//год, месяц, день

           // Student[] s = new Student[] {
           //     new Student("Ivanov", "Ivan",      new DateTime(2001, 07, 30)),
           //     new Student("Masha", "Ivanova",    new DateTime(1986, 07, 30)),
           //     new Student("Petya", "Petrov",     new DateTime(1985, 06, 28)),
           //     new Student("Sidor", "Sidorov",    new DateTime(1919, 05, 09)),
           //     new Student("Миша", "Медведев",    new DateTime(1988, 05, 10)),
           //     s1,
           //     new Student("Дима", "Дмитриев",    new DateTime(1998, 05, 10)),
           //     new Student("Сергей", "Сергеев",   new DateTime(2000, 05, 10)),
           //     new Student("George", "Georgescu", new DateTime(1958, 10, 05))
           //};
           // Student[] st1 = new Student[] {
           //     new Student("Ivanov", "Ivan",      new DateTime(2001, 07, 30)),
           //     new Student("Masha", "Ivanova",    new DateTime(1986, 07, 30)),
           //     new Student("Petya", "Petrov",     new DateTime(2001, 06, 22)),
           //     new Student("Sidor", "Sidorov",    new DateTime(1919, 05, 09)),
           //     new Student("Миша", "Медведев",    new DateTime(1988, 11, 10)),
           //     s11,s12,
           //     new Student("Дима", "Дмитриев",    new DateTime(2011, 11, 07)),
           //     new Student("Сергей", "Сергеев",   new DateTime(1999, 02, 28)),
           //     new Student("George", "Georgescu", new DateTime(2018, 01, 10))
           //};
                       
           // Console.WriteLine("Список студентов");
           // foreach (var st in s)
           // {
           //     st.ShowInfo();
           // }
           // #endregion

            StudentGroup StGroupe = new StudentGroup();


            //FileInfo f2 = new FileInfo(@"..\..\..\Students.txt");
            //FileStream fs = f2.Open(FileMode.Open,FileAccess.Read,FileShare.None);

            


            StreamReader sr = File.OpenText(@"..\..\Students.txt");

            string input = null;
            string[] fio;
            input = sr.ReadLine();
            //Console.WriteLine(input);
            char[] charSeparators = new char[] { ' ' };

            while (input != null)
            {
               // Console.WriteLine(input);
                if (input != null)
                {
                    fio = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                    StGroupe.AddStudent(new Student(fio[0], fio[1], fio[2]));
                    input = sr.ReadLine();
                }

                //Console.ReadKey();
            }


            

            StGroupe.ShowAllStudents();
            Console.ReadKey();
        }
    }
}
