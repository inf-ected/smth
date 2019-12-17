using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StudentSpace;

namespace Studentz
{

	class StudentGroup
	{
		private List<Student> students = new List<Student>();

		public void AddStudent(Student stud)
		{
			//Student student = new Student(name, surename, dateOfBirth);
			students.Add(stud);
		}
		public void AddStudent(string name, string surename, string dateOfBirth)
		{
			Student student = new Student(name, surename, dateOfBirth);
			students.Add(student);
		}
		public void RemoveStudent(Student student)
		{
			try
			{
				students.Remove(student);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				//throw;
			}
		}
		public Student GetStudent(int id)
		{
			try
			{
				return students[id];

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return null;
			}

		}
		public void ShowAllStudents()
		{
			Console.WriteLine("Все студенты:");
			foreach (var stud in students)
				Console.WriteLine(stud.name + "\t" + stud.surname + "\t" + stud.birthDate);
		}
		public int GetAmount() => students.Count;
		//public string FindByName() { }


	}

}
