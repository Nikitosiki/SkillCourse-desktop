using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.serialize.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class TaskCollection : List<Task>, ISerializableJSON
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


        private bool CheckCorrectObject(Task task)
        {
            if (DataBase.Courses.Find(course => course.IdCourse == task.IdCourse) != null)
                return true;

            return false;
        }

        private bool CheckCorrectId(Task task)
        {
            int targetIndex = this.FindIndex(item => item.IdTask == task.IdTask);
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(Task task)
        {
            if (CheckCorrectObject(task) && CheckCorrectId(task))
            {
                base.Add(task);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
            }
            else
                throw new Exception("Task uncorrect id or object!");
        }

        public new void Remove(Task task)
        {
            this.RemoveNonSerialized(task);

            if (!DataBase.AnswerTasks.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
        }

        public new void RemoveAll(Predicate<Task> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.Tasks[index]);

        public void Update(Task task)
        {
            if (!CheckCorrectObject(task))
                throw new ArgumentOutOfRangeException(nameof(task));

            int objectIndex = DataBase.Tasks.FindIndex(item => item.IdTask == task.IdTask);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            DataBase.Tasks[objectIndex] = task;

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
        }

        public new void Clear()
        {
            foreach (Task task in DataBase.Tasks)
            {
                this.RemoveNonSerialized(task);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
        }


        #region Serialize

        public void RemoveNonSerialized(Task task)
        {
            DataBase.AnswerTasks.RemoveAllNonSerialized(answer => answer.IdTask == task.IdTask);

            base.Remove(task);
        }

        public void RemoveAllNonSerialized(Predicate<Task> match)
        {
            foreach (Task task in DataBase.Tasks)
            {
                if (match(task))
                    this.RemoveNonSerialized(task);
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
            string path = SerializeSetting.Default.TaskCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            if (Serialize.SerializeObject(DataBase.Tasks, path))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string path = SerializeSetting.Default.TaskCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            List<Task> newListTask = new List<Task>();
            if (Serialize.DeserializeObject(ref newListTask, path))
            {
                base.Clear();
                base.AddRange(newListTask);
                return true;
            }

            return false;
        }

        #endregion

        private new void AddRange(IEnumerable<Task> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Task item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Task> collection) { throw new NotImplementedException(); }
    }
}
