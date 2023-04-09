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
    public class UnitTests_Teather
    {
        private Teather teather;

        [TestInitialize]
        public void TestInitialize()
        {
            teather = new Teather("John", "Doe", "johndoe@example.com", "password123", new DateTime(1990, 1, 1), GenderType.Male);
        }


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
            DateTime dateOfBirth = new DateTime(1890, 1, 1);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }


        [TestMethod]
        public void TeatherConstructorSetsPropertiesCorrectly()
        {
            Assert.AreEqual(UserType.Teacher, teather.UserType);
            Assert.AreEqual("John", teather.FirstName);
            Assert.AreEqual("Doe", teather.LastName);
            Assert.AreEqual("johndoe@example.com", teather.Email);
            Assert.AreEqual("password123", teather.Password);
            Assert.AreEqual(null, teather.PhoneNumber);
            Assert.AreEqual(new DateTime(1990, 1, 1), teather.DateOfBirth);
            Assert.AreEqual(GenderType.Male, teather.Gender);
            Assert.AreEqual(DateTime.Now.Date, teather.LastLoginDate.Date);
        }

        [TestMethod]
        public void CloneReturnsNewInstanceOfTeatherWithSameProperties()
        {
            var clonedTeather = (Teather)teather.Clone();

            Assert.AreNotEqual(teather, clonedTeather);
            Assert.AreEqual(teather.IdUser, clonedTeather.IdUser);
            Assert.AreEqual(teather.UserType, clonedTeather.UserType);
            Assert.AreEqual(teather.FirstName, clonedTeather.FirstName);
            Assert.AreEqual(teather.LastName, clonedTeather.LastName);
            Assert.AreEqual(teather.Email, clonedTeather.Email);
            Assert.AreEqual(teather.Password, clonedTeather.Password);
            Assert.AreEqual(teather.PhoneNumber, clonedTeather.PhoneNumber);
            Assert.AreEqual(teather.DateOfBirth, clonedTeather.DateOfBirth);
            Assert.AreEqual(teather.Gender, clonedTeather.Gender);
            Assert.AreEqual(teather.LastLoginDate, clonedTeather.LastLoginDate);
        }


        [TestMethod]
        public void IdUser_IsUniqueForEachNewInstance()
        {
            // Arrange
            var teacher1 = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);
            var teacher2 = new Teather("Jane", "Doe", "janedoe@example.com", "password", new DateTime(1985, 1, 1), GenderType.Female);

            // Assert
            Assert.AreNotEqual(teacher1.IdUser, teacher2.IdUser);
        }


        [TestMethod]
        public void UserType_CanBeSetAndGet()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act
            teacher.UserType = UserType.Student;

            // Assert
            Assert.AreEqual(UserType.Student, teacher.UserType);
        }


        [TestMethod]
        public void FirstName_CannotBeNull()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => teacher.FirstName = null);
        }


        [TestMethod]
        public void LastName_CannotBeNull()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => teacher.LastName = null);
        }


        [TestMethod]
        public void Email_MustHaveCorrectFormat()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => teacher.Email = "invalid-email-format");
        }


        [TestMethod]
        public void Constructor_ValidArguments_ObjectCreated()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoe@example.com";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1980, 1, 1);
            GenderType gender = GenderType.Male;

            // Act
            Teather teacher = new Teather(firstName, lastName, email, password, dateOfBirth, gender);

            // Assert
            Assert.IsNotNull(teacher);
            Assert.AreEqual(firstName, teacher.FirstName);
            Assert.AreEqual(lastName, teacher.LastName);
            Assert.AreEqual(email, teacher.Email);
            Assert.AreEqual(password, teacher.Password);
            Assert.AreEqual(dateOfBirth, teacher.DateOfBirth);
            Assert.AreEqual(gender, teacher.Gender);
            Assert.AreEqual(UserType.Teacher, teacher.UserType);
            Assert.IsTrue(teacher.IdUser > 0);
            Assert.IsTrue(teacher.LastLoginDate < DateTime.Now.AddSeconds(1));
        }


        [TestMethod]
        public void Constructor_InvalidFirstName_ArgumentNullException()
        {
            // Arrange
            string firstName = null;
            string lastName = "Doe";
            string email = "johndoe@example.com";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1980, 1, 1);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }


        [TestMethod]
        public void Constructor_InvalidLastName_ArgumentNullException()
        {
            // Arrange
            string firstName = "John";
            string lastName = null;
            string email = "johndoe@example.com";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1980, 1, 1);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }


        [TestMethod]
        public void Constructor_InvalidEmail_FormatException()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "invalid_email";
            string password = "password123";
            DateTime dateOfBirth = new DateTime(1980, 1, 1);
            GenderType gender = GenderType.Male;

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => new Teather(firstName, lastName, email, password, dateOfBirth, gender));
        }


        [TestMethod]
        public void Constructor_InvalidDateOfBirth_ArgumentOutOfRangeException()
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
        public void FirstNameSetterThrowsArgumentNullExceptionWhenValueIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => teather.FirstName = null);
        }


        [TestMethod]
        public void LastNameSetterThrowsArgumentNullExceptionWhenValueIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => teather.LastName = null);
        }


        [TestMethod]
        public void EmailSetterThrowsFormatExceptionWhenValueIsNotInCorrectFormat()
        {
            Assert.ThrowsException<FormatException>(() => teather.Email = "invalid-email");
        }


        [TestMethod]
        public void PhoneNumberSetterThrowsFormatExceptionWhenValueIsNotInCorrectFormat()
        {
            Assert.ThrowsException<FormatException>(() => teather.PhoneNumber = "+123-456-789");
        }


        [TestMethod]
        public void PasswordSetterThrowsFormatExceptionWhenValueIsNull()
        {
            Assert.ThrowsException<FormatException>(() => teather.Password = null);
        }


        [TestMethod]
        public void DateOfBirthSetterThrowsArgumentOutOfRangeExceptionWhenValueIsLessThan1900()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teather.DateOfBirth = new DateTime(1800, 1, 1));
        }


        [TestMethod]
        public void DateOfBirthSetterThrowsArgumentOutOfRangeExceptionWhenValueIsGreaterThanCurrentDatePlusOneDay()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teather.DateOfBirth = DateTime.Now.AddDays(2));
        }


        [TestMethod]
        public void Clone_ReturnsNewTeacherInstanceWithSameProperties()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1), GenderType.Male);

            // Act
            var clonedTeacher = teacher.Clone() as Teather;

            // Assert
            Assert.IsNotNull(clonedTeacher);
            Assert.AreNotSame(teacher, clonedTeacher);
            Assert.AreEqual(teacher.IdUser, clonedTeacher.IdUser);
            Assert.AreEqual(teacher.UserType, clonedTeacher.UserType);
            Assert.AreEqual(teacher.FirstName, clonedTeacher.FirstName);
            Assert.AreEqual(teacher.LastName, clonedTeacher.LastName);
            Assert.AreEqual(teacher.Email, clonedTeacher.Email);
            Assert.AreEqual(teacher.Password, clonedTeacher.Password);
            Assert.AreEqual(teacher.PhoneNumber, clonedTeacher.PhoneNumber);
            Assert.AreEqual(teacher.DateOfBirth, clonedTeacher.DateOfBirth);
            Assert.AreEqual(teacher.Gender, clonedTeacher.Gender);
            Assert.AreEqual(teacher.LastLoginDate, clonedTeacher.LastLoginDate);
        }


        [TestMethod]
        public void SetInvalidDateOfBirth_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var teacher = new Teather("John", "Doe", "john.doe@example.com", "password123", new DateTime(1990, 1, 1), GenderType.Male);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.DateOfBirth = new DateTime(1899, 12, 31));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.DateOfBirth = DateTime.Now.AddDays(2));
        }


        [TestMethod]
        public void Teather_SetValidPhoneNumber_PropertyIsSet()
        {
            // Arrange
            var teather = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act
            teather.PhoneNumber = "+1-123-456-7890";

            // Assert
            Assert.AreEqual("+1-123-456-7890", teather.PhoneNumber);
        }


        [TestMethod]
        public void Teather_SetInvalidPhoneNumber_FormatExceptionIsThrown()
        {
            // Arrange
            var teather = new Teather("John", "Doe", "johndoe@example.com", "password", new DateTime(1980, 1, 1), GenderType.Male);

            // Act and Assert
            Assert.ThrowsException<FormatException>(() => teather.PhoneNumber = "+123-456-7890");
        }
    }
}
