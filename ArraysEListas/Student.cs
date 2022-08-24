using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEListas
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string  Document { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;
            PhoneNumbers = new List<String> { "123456789", "564987514", "646546584" };
        }
    }
}
