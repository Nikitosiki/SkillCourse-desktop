using SkillCourse;
using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.entities
{
    [TestClass]
    public class UnitTests_Course
    {
        [TestMethod]
        public void ConstructorWithValidArguments_SetsProperties()
        {
            // Arrange
            int idTeacher = 1;
            string name = "Test Course";
            string description = "This is a test course.";
            string imagePath = "/images/test.png";

            // Act
            Course course = new Course(name, description, imagePath, idTeacher);

            // Assert
            Assert.AreEqual(name, course.Name);
            Assert.AreEqual(description, course.Description);
            Assert.AreEqual(imagePath, course.ImagePath);
            Assert.AreEqual(idTeacher, course.IdTeacher);
            Assert.IsTrue(course.IdCourse > 0);
        }


        [TestMethod]
        public void SetNameWithNull_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "This is a test course.", "/images/test.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.Name = null);
        }


        [TestMethod]
        public void SetDescriptionWithNull_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "This is a test course.", "/images/test.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.Description = null);
        }


        [TestMethod]
        public void SetImagePathWithNull_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "This is a test course.", "/images/test.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.ImagePath = null);
        }


        [TestMethod]
        public void SetIdTeacherWithNegativeValue_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            Course course = new Course("Test Course", "This is a test course.", "/images/test.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.IdTeacher = -1);
        }


        [TestMethod]
        public void Clone_ReturnsClonedObject()
        {
            // Arrange
            Course course = new Course("Test Course", "This is a test course.", "/images/test.png", 1);

            // Act
            Course clone = (Course)course.Clone();

            // Assert
            Assert.AreEqual(course.IdCourse, clone.IdCourse);
            Assert.AreEqual(course.Name, clone.Name);
            Assert.AreEqual(course.Description, clone.Description);
            Assert.AreEqual(course.ImagePath, clone.ImagePath);
            Assert.AreEqual(course.IdTeacher, clone.IdTeacher);
            Assert.AreNotSame(course, clone);
        }


        [TestMethod]
        public void Constructor_WithId_WhenCalled_ShouldSetProperties()
        {
            // Arrange
            int idTeacher = 1;
            string name = "Test Course";
            string description = "Test Course Description";
            string imagePath = "test_image.png";

            // Act
            Course course = new Course(name, description, imagePath, idTeacher);

            // Assert
            Assert.AreEqual(name, course.Name);
            Assert.AreEqual(description, course.Description);
            Assert.AreEqual(imagePath, course.ImagePath);
            Assert.AreEqual(idTeacher, course.IdTeacher);
        }


        [TestMethod]
        public void NameSetter_WithNullValue_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "Test Course Description", "test_image.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.Name = null);
        }


        [TestMethod]
        public void DescriptionSetter_WithNullValue_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "Test Course Description", "test_image.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.Description = null);
        }


        [TestMethod]
        public void ImagePathSetter_WithNullValue_ThrowsArgumentNullException()
        {
            // Arrange
            Course course = new Course("Test Course", "Test Course Description", "test_image.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.ImagePath = null);
        }


        [TestMethod]
        public void IdTeacherSetter_WithNegativeValue_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            Course course = new Course("Test Course", "Test Course Description", "test_image.png", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.IdTeacher = -1);
        }
    }
}
