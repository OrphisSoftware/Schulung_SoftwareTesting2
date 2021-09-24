using NUnit.Framework;
using System;

namespace StudentManager.Test
{
    //•(Ä1) Name nicht leer
    //•(Ä2) Name leer ungültig
    //•(Ä3) Geburtsjahr kleiner 1900 (ungültig)
    //•(Ä4) Geburtsjahr grösser gleich 1900 und kleiner gleich 2000 (gültig)
    //•(Ä5) Geburtsjahr grösser 2000 (ungültig)
    //•(Ä6) Fachbereich FBING (gültig)
    //•(Ä7) Fachbereich FBBWL (gültig)
    //•(Ä8) Fachbereich FBPOL (gültig)
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Testen von "gültigen" Äquivalenzklassen und Grenzwerte (Testfälle 1-3)
        //  <summary>
        [Test]
        [TestCase("Meier", 1900, SubjectArea.FBING, TestName = "Ä1Ä4UÄ6")]
        [TestCase("Schmidt", 2000, SubjectArea.FBBWL, TestName = "Ä1Ä4OÄ7")]
        [TestCase("Schulz", 1985, SubjectArea.FBPOL, TestName = "Ä1Ä4Ä8")]
        public void StudentSuccessTests(string name, int birthYear, SubjectArea area)
        {
            //arrange & act
            var student = new Student(name, birthYear, area);
            //Assert
            Assert.AreEqual(birthYear, student.BirthYear);
            Assert.AreEqual(name, student.Name);
        }

        /// <summary>
        /// Testen von "gültigen" Äquivalenzklassen und Grenzwerte (Testfälle 1-3)
        //  <summary>
        [Test]
        [TestCase("", 1988, SubjectArea.FBING, TestName = "Ä2")]
        [TestCase("Meier", 1899, SubjectArea.FBING, TestName = "Ä3O")]
        [TestCase("Meier", 2001, SubjectArea.FBPOL, TestName = "Ä5U")]
        public void StudentFailedTests(string name, int birthYear, SubjectArea area)
        {
            //arrange & act & assert
            Assert.Throws<ArgumentException>(() => new Student(name, birthYear, area));
        }

    }
}