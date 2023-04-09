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
    public class UnitTests_Student
    {
        private static Student student;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            student = new Student("John", "Doe", "johndoe@example.com", "password123", new DateTime(1990, 1, 1), GenderType.Male);
        }


        [TestMethod]
        public void StudentIdIsPositive()
        {
            Assert.IsTrue(student.IdUser > 0);
        }


        [TestMethod]
        public void SetUserType()
        {
            student.UserType = UserType.Student;
            Assert.AreEqual(UserType.Student, student.UserType);
        }


        [TestMethod]
        public void SetAndGetFirstName()
        {
            student.FirstName = "Jane";
            Assert.AreEqual("Jane", student.FirstName);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetNullFirstNameThrowsException()
        {
            student.FirstName = null;
        }


        [TestMethod]
        public void SetAndGetLastName()
        {
            student.LastName = "Smith";
            Assert.AreEqual("Smith", student.LastName);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetNullLastNameThrowsException()
        {
            student.LastName = null;
        }


        [TestMethod]
        public void SetAndGetEmail()
        {
            student.Email = "janesmith@example.com";
            Assert.AreEqual("janesmith@example.com", student.Email);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void SetInvalidEmailThrowsException()
        {
            student.Email = "invalidemail";
        }


        [TestMethod]
        public void SetAndGetPhoneNumber()
        {
            student.PhoneNumber = "+1-123-456-7890";
            Assert.AreEqual("+1-123-456-7890", student.PhoneNumber);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void SetInvalidPhoneNumberThrowsException()
        {
            student.PhoneNumber = "invalidphone";
        }


        [TestMethod]
        public void SetAndGetPassword()
        {
            student.Password = "newpassword";
            Assert.AreEqual("newpassword", student.Password);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void SetNullPasswordThrowsException()
        {
            student.Password = null;
        }


        [TestMethod]
        public void SetAndGetDateOfBirth()
        {
            student.DateOfBirth = new DateTime(1995, 1, 1);
            Assert.AreEqual(new DateTime(1995, 1, 1), student.DateOfBirth);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetInvalidDateOfBirthThrowsException()
        {
            student.DateOfBirth = new DateTime(1899, 12, 31);
        }


        [TestMethod]
        public void SetAndGetGender()
        {
            student.Gender = GenderType.Female;
            Assert.AreEqual(GenderType.Female, student.Gender);
        }


        [TestMethod]
        public void SetAndGetLastLoginDate()
        {
            student.LastLoginDate = new DateTime(2022, 1, 1);
            Assert.AreEqual(new DateTime(2022, 1, 1), student.LastLoginDate);
        }
    }
}
