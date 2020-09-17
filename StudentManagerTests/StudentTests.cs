using System;
using NUnit.Framework;
using StudentManager;

namespace StudentManagerTests
{
    public class Tests
    {
        [Test]
        [TestCase("Meier", "1900/01/01", SubjectArea.FBING, TestName = "�1�4U�6", ExpectedResult = true)]
        [TestCase("Schmidt", "2000/01/01", SubjectArea.FBBWL, TestName = "�1�4O�7", ExpectedResult = true)]
        [TestCase("Meier", "1899/01/01", SubjectArea.FBING, TestName = "�3O", ExpectedResult = false)]
        public bool Test(string name, DateTime date, SubjectArea area)
        {
            try
            {
                var student = new Student(name, date, area);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}