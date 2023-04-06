using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.entities
{
    [TestClass]
    public class UnitTests_SubscriptionCourse
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            // Arrange
            int idStudent = 1;
            int idCourse = 2;

            // Act
            SubscriptionCourse subscriptionCourse = new SubscriptionCourse(idStudent, idCourse);

            // Assert
            Assert.AreEqual(idStudent, subscriptionCourse.IdStudent);
            Assert.AreEqual(idCourse, subscriptionCourse.IdCourse);
            Assert.IsTrue(subscriptionCourse.DateSub > new DateTime(2000, 01, 01));
        }


        [TestMethod]
        public void IdSubscriptionCourse_IsGreaterThanZero()
        {
            // Arrange
            int idStudent = 1;
            int idCourse = 2;

            // Act
            SubscriptionCourse subscriptionCourse = new SubscriptionCourse(idStudent, idCourse);

            // Assert
            Assert.IsTrue(subscriptionCourse.IdSubscriptionCourse > 0);
        }


        [TestMethod]
        public void DateSub_IsWithinValidRange()
        {
            // Arrange
            int idStudent = 1;
            int idCourse = 2;

            // Act
            SubscriptionCourse subscriptionCourse = new SubscriptionCourse(idStudent, idCourse);

            // Assert
            Assert.IsTrue(subscriptionCourse.DateSub > new DateTime(2000, 01, 01));
            Assert.IsTrue(subscriptionCourse.DateSub < DateTime.Now.AddDays(1));
        }


        [TestMethod]
        public void Clone_ReturnsNewInstanceWithSameValues()
        {
            // Arrange
            int idStudent = 1;
            int idCourse = 2;
            SubscriptionCourse subscriptionCourse = new SubscriptionCourse(idStudent, idCourse);

            // Act
            SubscriptionCourse clonedSubscriptionCourse = (SubscriptionCourse)subscriptionCourse.Clone();

            // Assert
            Assert.AreEqual(subscriptionCourse.IdSubscriptionCourse, clonedSubscriptionCourse.IdSubscriptionCourse);
            Assert.AreEqual(subscriptionCourse.DateSub, clonedSubscriptionCourse.DateSub);
            Assert.AreEqual(subscriptionCourse.IdCourse, clonedSubscriptionCourse.IdCourse);
            Assert.AreEqual(subscriptionCourse.IdStudent, clonedSubscriptionCourse.IdStudent);
        }


        [TestMethod]
        public void IdCourseLessThanZero_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int idStudent = 1;
            int idCourse = -1;

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SubscriptionCourse(idStudent, idCourse));
        }


        [TestMethod]
        public void IdStudentLessThanZero_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int idStudent = -1;
            int idCourse = 1;

            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SubscriptionCourse(idStudent, idCourse));
        }


        [TestMethod]
        public void Clone_ReturnsClone()
        {
            // Arrange
            SubscriptionCourse original = new SubscriptionCourse(1, 2);

            // Act
            SubscriptionCourse clone = (SubscriptionCourse)original.Clone();

            // Assert
            Assert.IsNotNull(clone);
            Assert.AreEqual(original.IdSubscriptionCourse, clone.IdSubscriptionCourse);
            Assert.AreEqual(original.DateSub, clone.DateSub);
            Assert.AreEqual(original.IdCourse, clone.IdCourse);
            Assert.AreEqual(original.IdStudent, clone.IdStudent);
        }
    }
}
