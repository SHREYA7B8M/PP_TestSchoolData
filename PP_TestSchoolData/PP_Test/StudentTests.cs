using NUnit.Framework;
using PP_TestSchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Test
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Benji Dunn";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Benji Dunn", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "ABC Street";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("ABC Street", studentAddress);
        }
    }
}
