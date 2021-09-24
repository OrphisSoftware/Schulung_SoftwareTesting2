using System;

namespace StudentManager
{
    public class Student
    {
         public string Name { get; set; }
        public int BirthYear { get; set; }
        public SubjectArea Area { get; set; }

        public Student(string name, int birthYear, SubjectArea area)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }

            if(birthYear<1900 || birthYear > 2000)
            {
                throw new ArgumentException();
            }

            Name = name;
            BirthYear = birthYear;
            Area = area;
        }
    }
}
