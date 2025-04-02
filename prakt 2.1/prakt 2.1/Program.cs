using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class Program
    {

        public class Student
        {
            
            public string LustName { get; set; } 
            public string FirstName { get; set; } 
            public string MiddleName { get; set; } 
            public DateTime DateOfBirth { get; set; } 
            public string Address { get; set; } 
            public string Phone { get; set; } 
            public string Email { get; set; } 
            public int Course { get; set; } 
            public string Group { get; set; } 
            public string RecordBookNumber { get; set; } 


            public Student()
            {
                LustName = string.Empty;
                FirstName = string.Empty;
                MiddleName = string.Empty;
                DateOfBirth = DateTime.MinValue;
                Address = string.Empty;
                Phone = string.Empty;
                Email = string.Empty;
                Course = 0;
                Group = string.Empty;
                RecordBookNumber = string.Empty;
            }


            public Student(string lustName, string firstName, string middleName, DateTime dateOfBirth,
                           string address, string phone, string email, int course, string group, string recordBookNumber)
            {
                LustName = lustName;
                FirstName = firstName;
                MiddleName = middleName;
                DateOfBirth = dateOfBirth;
                Address = address;
                Phone = phone;
                Email = email;
                Course = course;
                Group = group;
                RecordBookNumber = recordBookNumber;
            }


            public override string ToString()
            {
                return $"Студент: {LustName} {FirstName} {MiddleName}\n" +
                       $"Дата рождения: {DateOfBirth.ToShortDateString()}\n" +
                       $"Курс: {Course}\nГруппа: {Group}\nНомер зачетной книжки: {RecordBookNumber}";
            }


            public static bool CompareByCourse(Student s1, Student s2)
            {
                return s1.Course == s2.Course;
            }


            public static bool CompareByLustName(Student s1, Student s2)
            {
                return string.Equals(s1.LustName, s2.LustName, StringComparison.OrdinalIgnoreCase);
            }


            class Program
            {

                static void Main()
                {

                    Student s1 = new Student("Иванова", "Диана", "Владиславовна", new DateTime(2008, 01, 22),
                                             "Россия, г. Кострома, Речной пер., д. 5 кв. 68", "+7(3583)930-96-27",
                                             "jaha-sorogo95@mail.ru", 2, "Группа-11", "241929");
                    Student s2 = new Student("Быкова", "Виктория", "Георгиевна", new DateTime(2007, 10, 14),
                                            "Россия, г. Курск, Первомайская ул., д. 25 кв. 98", "7(373)351-93-91",
                                            "bezi-pubaye51@list.ru", 2, "Группа-5", "332799");

                    Console.WriteLine(s1);
                    Console.WriteLine(s2);


                    Console.WriteLine(Student.CompareByCourse(s1, s2));


                    Console.WriteLine(Student.CompareByLustName(s1, s2));
                }
            }
        }
    }
}
