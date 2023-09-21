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
    public class SubjectTests
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Name = "Psychology";

            // Act
            string subjectName = subject.Name;

            // Assert
            Assert.AreEqual("Psychology", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Id = 1100;

            // Act
            int subjectId = subject.Id;

            // Assert
            Assert.AreEqual(1100, subjectId);
        }
    }
}
