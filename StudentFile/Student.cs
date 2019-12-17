
using System;
using System.Globalization;

namespace Studentz
{

    sealed class Student
    {
        public string name;
        public string surname; //surname - фамилия
        public DateTime birthDate;
        public DateTime date;

        int[][] marks = new int[3][];
 
        public string Name //свойство
        {
            get { return name; }
            set
            {
                if (value != null && value != name)//в принципе  проверка "value != name" лишняя
                    name = value;
            }
        }
        public string Surname //свойство
        {
            get { return surname; }
            set { surname = value; }
        }
         public DateTime BirthDate //свойство
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }


        public Student(string name, string surname, string birthDateS)
        {//surname - фамилия
            this.name = name;
            this.surname = surname;
            Boolean b = DateTime.TryParse(birthDateS, out birthDate);
            //Console.WriteLine(dateOfBirthday); //отладочная печать
            //CultureInfo cult = CultureInfo.CreateSpecificCulture("en-EN");
            //date = DateTime.Parse(dateOfBirthdayS, cult);
            //Console.WriteLine(dateOfBirthday); //отладочная печать
        }
        public Student(string name, string surname, DateTime birthDate)
        {//surname - фамилия
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        //public void ChangeName(Student student, string name)//пользуйтесь свойствами
        //{
        //    if (student != null && student.name != name)
        //    {
        //        student.name = name;
        //    }
        //}

        //public void ChangeSurname(Student student, string surname)
        //{
        //    if (student != null && student.surname != surname)
        //    {
        //        student.surname = surname;
        //    }
        //}

        public int CalculateAge(DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }
        public void ShowInfo()
        {
            Console.Write($"Student : {name} : {surname} : {birthDate}");
            Console.WriteLine(" : возраст " + CalculateAge(DateTime.Now));
        }


        public void SetMarksArray()
        {
            int n;
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Введите кол-во оценок по предмету {i}");
                n = Convert.ToInt32(Console.ReadLine());
                marks[i] = new int[n];
                SetMarksForDiscipline(i, n);
            }
        }
        void SetMarksForDiscipline(int i, int n)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"Введите оценки по предмету {i}");
                marks[i][k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
/*
 //Примеры вычисления возраста
      static public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }

        static public int CalculateAgeCorrect2(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            // for leap years we need this
            if (birthDate > now.AddYears(-age)) age--;
            // don't use:
            // if (birthDate.AddYears(age) > now) age--;

            return age;
        }
        //End Правильный фрагмент кода С# 
        //другое решение 
        public static int GetAge(DateTime birthDate)
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                age--;

            return age;
        }
*/