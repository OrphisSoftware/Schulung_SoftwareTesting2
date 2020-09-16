using System;

namespace StudentManager
{
    public class Student
    {
        public const string BirthdayShouldBeBetweenExceptionMessage = "Birthday should be between 1900 and 2000";
        public string Name { get; }
        public DateTime Birthday { get; }
        public SubjectArea SubjectArea { get; }

        public Student(string name, DateTime birthday, SubjectArea subjectArea)
        {
            if (Birthday.Year < 1900 && Birthday.Year > 2000)
            {
                throw new ArgumentOutOfRangeException(BirthdayShouldBeBetweenExceptionMessage);
            }

            Name = name;
            Birthday = birthday;
            SubjectArea = subjectArea;
        }
    }
}
