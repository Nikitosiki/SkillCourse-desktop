using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = SkillCourse.DataBaseStructure.Task;

namespace Tests.entities
{
    [TestClass]
    public class UnitTests_Task
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            // Arrange
            string textTask = "Example task";
            int idCourse = 1;

            // Act
            Task task = new Task(textTask, idCourse);

            // Assert
            Assert.IsTrue(task.IdTask > 0);
            Assert.AreEqual(textTask, task.TextTask);
            Assert.AreEqual(idCourse, task.IdCourse);
        }


        [TestMethod]
        public void Constructor_ThrowsArgumentNullExceptionWhenTextTaskIsNull()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Task(null, 1));
        }


        [TestMethod]
        public void TextTask_Setter_ThrowsArgumentNullExceptionWhenValueIsNull()
        {
            // Arrange
            Task task = new Task("test", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => task.TextTask = null);
        }


        [TestMethod]
        public void IdCourse_Setter_ThrowsArgumentOutOfRangeExceptionWhenValueIsNegative()
        {
            // Arrange
            Task task = new Task("test", 1);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => task.IdCourse = -1);
        }


        [TestMethod]
        public void Clone_ReturnsNewTaskWithSameProperties()
        {
            // Arrange
            Task originalTask = new Task("test", 1);

            // Act
            Task clonedTask = (Task)originalTask.Clone();

            // Assert
            Assert.AreEqual(originalTask.IdTask, clonedTask.IdTask);
            Assert.AreEqual(originalTask.TextTask, clonedTask.TextTask);
            Assert.AreEqual(originalTask.IdCourse, clonedTask.IdCourse);
        }


        [TestMethod]
        public void Clone_ReturnsNewTaskInstance()
        {
            // Arrange
            Task originalTask = new Task("Example task", 1);

            // Act
            Task clonedTask = (Task)originalTask.Clone();

            // Assert
            Assert.AreNotSame(originalTask, clonedTask);
        }


        [TestMethod]
        public void TextTask_Setter_DoesNotThrowWhenValueIsEmptyString()
        {
            // Arrange
            Task task = new Task("Example task", 1);

            // Act
            task.TextTask = string.Empty;

            // Assert
            Assert.AreEqual(string.Empty, task.TextTask);
        }


        [TestMethod]
        public void IdCourse_Setter_DoesNotThrowWhenValueIsZero()
        {
            // Arrange
            Task task = new Task("Example task", 1);

            // Act
            task.IdCourse = 0;

            // Assert
            Assert.AreEqual(0, task.IdCourse);
        }
    }
}
