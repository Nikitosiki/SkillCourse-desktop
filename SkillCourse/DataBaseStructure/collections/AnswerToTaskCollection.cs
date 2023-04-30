using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.serialize.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class AnswerToTaskCollection : List<AnswerTask>, ISerializableJSON
    {
        private static SkillCourseDB? instanceDB = null;
        private static SkillCourseDB DataBase
        {
            get
            {
                if (instanceDB == null)
                {
                    instanceDB = SkillCourseDB.Instance;
                }
                return instanceDB;
            }
        }


        private bool CheckCorrectObject(AnswerTask answer)
        {
            if (DataBase.Tasks.Find(task => task.IdTask == answer.IdTask) != null)
                if (DataBase.Users.Students().Find(student => student.IdUser == answer.IdUser) != null)
                    return true;

            return false;
        }

        private bool CheckCorrectId(AnswerTask answer)
        {
            int targetIndex = this.FindIndex(item => item.IdAnswerToTask == answer.IdAnswerToTask);
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(AnswerTask answer)
        {
            if (CheckCorrectObject(answer) && CheckCorrectId(answer))
            {
                base.Add(answer);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
            }
            else
                throw new Exception("Answer Task, uncorrect id or object!");
        }

        public new void Remove(AnswerTask answer)
        {
            this.RemoveNonSerialized(answer);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
        }

        public new void RemoveAll(Predicate<AnswerTask> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.AnswerTasks[index]);

        public void Update(AnswerTask answer)
        {
            if (!CheckCorrectObject(answer))
                throw new ArgumentOutOfRangeException(nameof(answer));

            int objectIndex = DataBase.AnswerTasks.FindIndex(item => item.IdAnswerToTask == answer.IdAnswerToTask);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            DataBase.AnswerTasks[objectIndex] = answer;

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
        }

        public new void Clear()
        {
            foreach (AnswerTask answer in DataBase.AnswerTasks)
            {
                this.RemoveNonSerialized(answer);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
        }


        #region Serialize

        public void RemoveNonSerialized(AnswerTask answer)
        {
            base.Remove(answer);
        }

        public void RemoveAllNonSerialized(Predicate<AnswerTask> match)
        {
            foreach (AnswerTask answer in DataBase.AnswerTasks)
            {
                if (match(answer))
                    this.RemoveNonSerialized(answer);
            }
        }

        private bool CheckCorrectPathToDeserialize(string pathFile)
        {
            if (string.IsNullOrEmpty(pathFile))
                return false;

            string serializePathFolder = SerializeSetting.Default.SerializationPath;
            if (!Directory.Exists(serializePathFolder))
                Directory.CreateDirectory(serializePathFolder);

            if (!File.Exists($"{pathFile}.json"))
                return false;

            return true;
        }

        private bool CheckCorrectPathToSerialize(string pathFile)
        {
            if (string.IsNullOrEmpty(pathFile))
                return false;

            string serializePathFolder = SerializeSetting.Default.SerializationPath;
            if (!Directory.Exists(serializePathFolder))
                Directory.CreateDirectory(serializePathFolder);

            return true;
        }


        public bool SerializeObject()
        {
            string path = SerializeSetting.Default.AnswerToTaskCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            if (Serialize.SerializeObject(DataBase.AnswerTasks, path))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string path = SerializeSetting.Default.AnswerToTaskCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            List<AnswerTask> newListAnswer = new List<AnswerTask>();
            if (Serialize.DeserializeObject(ref newListAnswer, path))
            {
                base.Clear();
                base.AddRange(newListAnswer);
                return true;
            }

            return false;
        }

        #endregion

        private new void AddRange(IEnumerable<AnswerTask> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, AnswerTask item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<AnswerTask> collection) { throw new NotImplementedException(); }
    }
}
