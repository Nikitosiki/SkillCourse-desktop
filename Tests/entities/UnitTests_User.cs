using SkillCourse.DataBaseStructure.types;
using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.entities
{
    [TestClass]
    public class UnitTests_User
    {
        [TestMethod]
        public void TeatherConstructor_InvalidDateOfBirth_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoe@example.com";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1899, 12, 31);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }

        [TestMethod]
        public void TeatherConstructor_InvalidLastLoginDate_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoe@example.com";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1990, 1, 1);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }

    }
}
