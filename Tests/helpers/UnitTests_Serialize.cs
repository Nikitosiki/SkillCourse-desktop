using SkillCourse;
using SkillCourse.DataBaseStructure.serialize;

namespace Tests.helpers
{
    [TestClass]
    public class UnitTests_Serialize
    {
        [TestMethod]
        public void SerializeObject_Success()
        {
            // Arrange
            object obj = new { Name = "John", Age = 30 };
            string fileName = "test";

            // Act
            bool result = Serialize.SerializeObject<object>(obj, fileName);

            // Assert
            Assert.IsTrue(result);

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void DeserializeObject_Success()
        {
            // Arrange
            object? obj = null;
            string fileName = "test";
            Serialize.SerializeObject<object>(new { Name = "John", Age = 30 }, fileName);

            // Act
            bool result = Serialize.DeserializeObject<object>(ref obj, fileName);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(obj);

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void DeserializeObject_FileNotExists()
        {
            // Arrange
            object? obj = null;
            string fileName = "test";

            // Act
            bool result = Serialize.DeserializeObject<object>(ref obj, fileName);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(obj);
        }


        [TestMethod]
        public void DeserializeObject_Null()
        {
            // Arrange
            object obj = null;
            string fileName = "test";
            Serialize.SerializeObject<object>(null, fileName);

            // Act
            bool result = Serialize.DeserializeObject<object>(ref obj, fileName);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(obj);

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void DeserializeObject_Error()
        {
            // Arrange
            object obj = null;
            string fileName = "test";
            File.WriteAllText(fileName + ".json", "invalid json");

            // Act
            bool result = Serialize.DeserializeObject<object>(ref obj, fileName);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(obj);
        }


        [TestMethod]
        public void SerializeObject_List_Success()
        {
            // Arrange
            List<object> list = new List<object>();
            list.Add(new { Name = "John", Age = 30 });
            list.Add(new { Name = "Mary", Age = 25 });
            string fileName = "test";

            // Act
            bool result = Serialize.SerializeObject<List<object>>(list, fileName);

            // Assert
            Assert.IsTrue(result);

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void SerializeObject_ValidObject_ReturnsTrue()
        {
            // Arrange
            var obj = new { Name = "John", Age = 30 };
            string fileName = "test";

            // Act
            bool result = Serialize.SerializeObject(obj, fileName);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(fileName + ".json"));

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void DeserializeObject_FileNotFound_ReturnsFalse()
        {
            // Arrange
            object? obj = null;
            string fileName = "test";

            // Act
            bool result = Serialize.DeserializeObject(ref obj, fileName);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(obj);
        }


        [TestMethod]
        public void TestDeserializeObject_InvalidJson_ReturnsFalse()
        {
            // Arrange
            object? obj = null;
            string fileName = "test";
            File.WriteAllText(fileName + ".json", "invalid json");

            // Act
            bool result = Serialize.DeserializeObject(ref obj, fileName);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(obj);

            // Cleanup
            File.Delete(fileName + ".json");
        }


        [TestMethod]
        public void DeserializeObject_ValidJson_ReturnsTrue()
        {
            // Arrange
            var obj = new { Name = "John", Age = 30 };
            string fileName = "test";
            Serialize.SerializeObject(obj, fileName);

            // Act
            var deserializedObj = new { Name = "", Age = 0 };
            bool result = Serialize.DeserializeObject(ref deserializedObj, fileName);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(deserializedObj);
            Assert.AreEqual(obj.Name, deserializedObj.Name);
            Assert.AreEqual(obj.Age, deserializedObj.Age);

            // Cleanup
            File.Delete(fileName + ".json");
        }
    }
}