using SkillCourse;

namespace Tests.helpers
{
    [TestClass]
    public class UnitTests_PasswordEncryptor
    {
        [TestMethod]
        public void Encrypt_Password_Success()
        {
            // Arrange
            string password = "password123";

            // Act
            string hash = PasswordEncryptor.Encrypt(password);

            // Assert
            Assert.IsNotNull(hash);
        }


        [TestMethod]
        public void CheckPassword_CorrectPassword_Success()
        {
            // Arrange
            string password = "password123";
            string hash = PasswordEncryptor.Encrypt(password);

            // Act
            bool result = PasswordEncryptor.CheckPassword(password, hash);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CheckPassword_IncorrectPassword_Failure()
        {
            // Arrange
            string password = "password123";
            string incorrectPassword = "password456";
            string hash = PasswordEncryptor.Encrypt(password);

            // Act
            bool result = PasswordEncryptor.CheckPassword(incorrectPassword, hash);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Encrypt_MultiplePasswords_Success()
        {
            // Arrange
            string[] passwords = { "password123", "qwertyuiop", "asdfghjkl" };
            List<string> hashes = new List<string>();

            // Act
            foreach (string password in passwords)
            {
                hashes.Add(PasswordEncryptor.Encrypt(password));
            }

            // Assert
            Assert.AreEqual(passwords.Length, hashes.Count);
            foreach (string hash in hashes)
            {
                Assert.IsNotNull(hash);
            }
        }


        [TestMethod]
        public void CheckPassword_MultipleHashes_Success()
        {
            // Arrange
            string password = "password123";
            List<string> hashes = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                hashes.Add(PasswordEncryptor.Encrypt(password));
            }

            // Act
            bool result = PasswordEncryptor.CheckPassword(password, hashes[2]);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CheckPassword_MultipleHashes_Failure()
        {
            // Arrange
            string password = "password123";
            string incorrectPassword = "password456";
            List<string> hashes = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                hashes.Add(PasswordEncryptor.Encrypt(password));
            }

            // Act
            bool result = PasswordEncryptor.CheckPassword(incorrectPassword, hashes[2]);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Encrypt_EmptyPassword_Success()
        {
            // Arrange
            string password = "";

            // Act
            string hash = PasswordEncryptor.Encrypt(password);

            // Assert
            Assert.IsNotNull(hash);
        }


        [TestMethod]
        public void Encrypt_PasswordWithSpaces_Success()
        {
            // Arrange
            string password = " password123 ";

            // Act
            string hash = PasswordEncryptor.Encrypt(password);

            // Assert
            Assert.IsNotNull(hash);
        }


        [TestMethod]
        public void Encrypt_PasswordWithPunctuation_Success()
        {
            // Arrange
            string password = "!password123!";

            // Act
            string hash = PasswordEncryptor.Encrypt(password);

            // Assert
            Assert.IsNotNull(hash);
        }


        [TestMethod]
        public void Encrypt_LongPassword_Success()
        {
            // Arrange
            string password = new string('a', 101);

            // Act
            string hash = PasswordEncryptor.Encrypt(password);

            // Assert
            Assert.IsNotNull(hash);
        }
    }
}