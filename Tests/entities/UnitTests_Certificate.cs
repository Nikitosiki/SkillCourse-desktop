using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.entities
{
    [TestClass]
    public class UnitTests_Certificate
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedIdCertificate = 1;
            string expectedDescription = "Test Description";
            DateTime expectedPresentationTime = DateTime.Now;
            int expectedIdPresenterTeacher = 2;
            int expectedIdOwner = 3;
            int expectedIdCourse = 4;

            // Act
            Certificate certificate = new Certificate(expectedDescription, expectedPresentationTime, expectedIdPresenterTeacher, expectedIdOwner, expectedIdCourse);

            // Assert
            Assert.AreEqual(expectedIdCertificate, certificate.IdCertificate);
            Assert.AreEqual(expectedDescription, certificate.Description);
            Assert.AreEqual(expectedPresentationTime, certificate.PresentationTime);
            Assert.AreEqual(expectedIdPresenterTeacher, certificate.IdPresenterTeacher);
            Assert.AreEqual(expectedIdOwner, certificate.IdOwner);
            Assert.AreEqual(expectedIdCourse, certificate.IdCourse);
        }


        [TestMethod]
        public void Constructor_SetsIdCertificateCorrectly()
        {
            // Arrange
            int expectedIdCertificate = 1;
            string expectedDescription = "Test Description";
            DateTime expectedPresentationTime = DateTime.Now;
            int expectedIdPresenterTeacher = 2;
            int expectedIdOwner = 3;
            int expectedIdCourse = 4;

            // Act
            Certificate certificate = new Certificate(expectedDescription, expectedPresentationTime, expectedIdPresenterTeacher, expectedIdOwner, expectedIdCourse);

            // Assert
            Assert.AreEqual(expectedIdCertificate, certificate.IdCertificate);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ThrowsArgumentNullExceptionIfDescriptionIsNull()
        {
            // Arrange
            string expectedDescription = null;
            DateTime expectedPresentationTime = DateTime.Now;
            int expectedIdPresenterTeacher = 2;
            int expectedIdOwner = 3;
            int expectedIdCourse = 4;

            // Act
            Certificate certificate = new Certificate(expectedDescription, expectedPresentationTime, expectedIdPresenterTeacher, expectedIdOwner, expectedIdCourse);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ThrowsArgumentOutOfRangeExceptionIfIdPresenterTeacherIsNegative()
        {
            // Arrange
            string expectedDescription = "Test Description";
            DateTime expectedPresentationTime = DateTime.Now;
            int expectedIdPresenterTeacher = -1;
            int expectedIdOwner = 3;
            int expectedIdCourse = 4;

            // Act
            Certificate certificate = new Certificate(expectedDescription, expectedPresentationTime, expectedIdPresenterTeacher, expectedIdOwner, expectedIdCourse);
        }


        [TestMethod]
        public void Clone_ReturnsClonedObject()
        {
            // Arrange
            int expectedIdCertificate = 1;
            string expectedDescription = "Test Description";
            DateTime expectedPresentationTime = DateTime.Now;
            int expectedIdPresenterTeacher = 2;
            int expectedIdOwner = 3;
            int expectedIdCourse = 4;
            Certificate certificate = new Certificate(expectedDescription, expectedPresentationTime, expectedIdPresenterTeacher, expectedIdOwner, expectedIdCourse);

            // Act
            Certificate clonedCertificate = (Certificate)certificate.Clone();

            // Assert
            Assert.AreEqual(expectedIdCertificate, clonedCertificate.IdCertificate);
            Assert.AreEqual(expectedDescription, clonedCertificate.Description);
            Assert.AreEqual(expectedPresentationTime, clonedCertificate.PresentationTime);
            Assert.AreEqual(expectedIdPresenterTeacher, clonedCertificate.IdPresenterTeacher);
            Assert.AreEqual(expectedIdOwner, clonedCertificate.IdOwner);
            Assert.AreEqual(expectedIdCourse, clonedCertificate.IdCourse);
        }


        [TestMethod]
        public void Description_Null()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => certificate.Description = null);
        }


        [TestMethod]
        public void PresentationTime_OutOfRange()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => certificate.PresentationTime = new DateTime(1999, 12, 31));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => certificate.PresentationTime = DateTime.Now.AddDays(2));
        }


        [TestMethod]
        public void IdPresenterTeacher_Negative()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => certificate.IdPresenterTeacher = -1);
        }


        [TestMethod]
        public void IdOwner_Negative()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => certificate.IdOwner = -1);
        }


        [TestMethod]
        public void IdCourse_Negative()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => certificate.IdCourse = -1);
        }


        [TestMethod]
        public void Clone_New()
        {
            //Arrange
            var certificate = new Certificate("Test", DateTime.Now, 1, 2, 3);

            //Act
            var clonedCertificate = certificate.Clone() as Certificate;

            //Assert
            Assert.IsNotNull(clonedCertificate);
            Assert.AreEqual(certificate.IdCertificate, clonedCertificate.IdCertificate);
            Assert.AreEqual(certificate.Description, clonedCertificate.Description);
            Assert.AreEqual(certificate.PresentationTime, clonedCertificate.PresentationTime);
            Assert.AreEqual(certificate.IdPresenterTeacher, clonedCertificate.IdPresenterTeacher);
            Assert.AreEqual(certificate.IdOwner, clonedCertificate.IdOwner);
            Assert.AreEqual(certificate.IdCourse, clonedCertificate.IdCourse);
        }
    }
}
