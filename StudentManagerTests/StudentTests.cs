using NUnit.Framework;
using System;

namespace StudentManager.Test
{
    //�(�1) Name nicht leer
    //�(�2) Name leer ung�ltig
    //�(�3) Geburtsjahr kleiner 1900 (ung�ltig)
    //�(�4) Geburtsjahr gr�sser gleich 1900 und kleiner gleich 2000 (g�ltig)
    //�(�5) Geburtsjahr gr�sser 2000 (ung�ltig)
    //�(�6) Fachbereich FBING (g�ltig)
    //�(�7) Fachbereich FBBWL (g�ltig)
    //�(�8) Fachbereich FBPOL (g�ltig)
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Testen von "g�ltigen" �quivalenzklassen und Grenzwerte (Testf�lle 1-3)
        //  <summary>
        [Test]
        [TestCase("Meier", 1900, SubjectArea.FBING, TestName = "�1�4U�6")]
        [TestCase("Schmidt", 2000, SubjectArea.FBBWL, TestName = "�1�4O�7")]
        [TestCase("Schulz", 1985, SubjectArea.FBPOL, TestName = "�1�4�8")]
        public void StudentSuccessTests(string name, int birthYear, SubjectArea area)
        {
            //arrange & act
            var student = new Student(name, birthYear, area);
            //Assert
            Assert.AreEqual(birthYear, student.BirthYear);
            Assert.AreEqual(name, student.Name);
        }

        /// <summary>
        /// Testen von "g�ltigen" �quivalenzklassen und Grenzwerte (Testf�lle 1-3)
        //  <summary>
        [Test]
        [TestCase("", 1988, SubjectArea.FBING, TestName = "�2")]
        [TestCase("Meier", 1899, SubjectArea.FBING, TestName = "�3O")]
        [TestCase("Meier", 2001, SubjectArea.FBPOL, TestName = "�5U")]
        public void StudentFailedTests(string name, int birthYear, SubjectArea area)
        {
            //arrange & act & assert
            Assert.Throws<ArgumentException>(() => new Student(name, birthYear, area));
        }

    }
}