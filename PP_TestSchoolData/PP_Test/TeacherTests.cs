using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using PP_TestSchoolData;

namespace PP_Test
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void TestClassName()
        {
            // Arrange
            Teacher teacher = new Teacher();
            teacher.Name = "Ethan Hunt";

            // Act
            string teacherName = teacher.Name;

            // Assert
            Assert.AreEqual("Ethan Hunt", teacherName);
        }

        [Test]
        public void TestClassId()
        {
            // Arrange
            Teacher teacher = new Teacher();
            teacher.Id = 101;

            // Act
            int teacherid = teacher.Id;

            // Assert
            Assert.AreEqual(101, teacherid);
        }
    }
}

