using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiongenerics
{
    class Student
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }
        public Student(string name, int id, int age)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
    class BusinessLayer
    {
        public void Displaycity(string c)
        {
            Console.WriteLine("city :{0}", c);

        }
        public void DisplayStudentDetails(List<Student> stu)
        {
            if (stu.Count != 0)
            {
                foreach (Student s in stu)
                {
                    if (s.name != null && s.age != 0 && s.id != 0)
                        Console.WriteLine("id :{0} || name :{1}|| age :{2}", s.id, s.name, s.age);
                    else
                        Console.WriteLine("some values are null or 0 in the input");
                }
            }
            else
            {
                Console.WriteLine("student details are empty");
            }

        }
    }
       
    class Scenarioeg
    {
        static void Main()
        {
            string city = "chennai";
            List<Student> students = new List<Student>();
            students.Add(new Student(null, 1001, 30));
            students.Add(new Student("abhi", 1002, 24));
            BusinessLayer businessLayer = new BusinessLayer();
            businessLayer.Displaycity(city);
            businessLayer.DisplayStudentDetails(students);
            Console.Read();

        }
    }
}
