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
    public class UnitTests_AnswerTask
    {
        [TestMethod]
        public void State_CanBeSetAndGet()
        {
            // Arrange
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            StateTask newState = StateTask.Done;

            // Act
            answerTask.State = newState;

            // Assert
            Assert.AreEqual(newState, answerTask.State);
        }


        [TestMethod]
        public void Grade_IsNullOrInRange()
        {
            // Arrange
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            int validValue = 75;
            int invalidValue = 150;

            // Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => answerTask.Grade = invalidValue);
            answerTask.Grade = null;
            Assert.IsNull(answerTask.Grade);
            answerTask.Grade = validValue;
            Assert.AreEqual(validValue, answerTask.Grade);
        }


        [TestMethod]
        public void IdTask_IsNonNegative()
        {
            // Arrange
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            int negativeValue = -1;

            // Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => answerTask.IdTask = negativeValue);
        }


        [TestMethod]
        public void IdUser_IsNonNegative()
        {
            // Arrange
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            int negativeValue = -1;

            // Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => answerTask.IdUser = negativeValue);
        }


        [TestMethod]
        public void Clone_ReturnsNewInstance()
        {
            // Arrange
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);

            // Act
            var clonedInstance = answerTask.Clone();

            // Assert
            Assert.IsNotNull(clonedInstance);
            Assert.IsInstanceOfType(clonedInstance, typeof(AnswerTask));
            Assert.AreNotEqual(answerTask, clonedInstance);
        }


        [TestMethod]
        public void ConstructorWithValidValues()
        {
            StateTask expectedState = StateTask.NotDone;
            int? expectedGrade = null;
            int expectedIdTask = 1;
            int expectedIdUser = 2;

            AnswerTask answerTask = new AnswerTask(expectedState, expectedGrade, "", expectedIdTask, expectedIdUser);
            
            Assert.AreEqual(expectedState, answerTask.State);
            Assert.AreEqual(expectedGrade, answerTask.Grade);
            Assert.AreEqual(expectedIdTask, answerTask.IdTask);
            Assert.AreEqual(expectedIdUser, answerTask.IdUser);
        }


        [TestMethod]
        public void TestIdAnswerToTaskGetter()
        {
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            int expectedValue = answerTask.IdAnswerToTask;
            int actualValue = answerTask.IdAnswerToTask;

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void TestStateGetter()
        {
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            StateTask expectedValue = StateTask.NotDone;
            StateTask actualValue = answerTask.State;

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void TestStateSetter()
        {
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, null, "", 1, 2);
            StateTask expectedValue = StateTask.Done;
            answerTask.State = expectedValue;
            StateTask actualValue = answerTask.State;

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void TestGradeGetter()
        {
            AnswerTask answerTask = new AnswerTask(StateTask.NotDone, 85, "", 1, 2);
            int? expectedValue = 85;
            int? actualValue = answerTask.Grade;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
