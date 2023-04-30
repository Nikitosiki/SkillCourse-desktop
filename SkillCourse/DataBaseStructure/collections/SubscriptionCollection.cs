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
    public class SubscriptionCollection : List<SubscriptionCourse>, ISerializableJSON
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


        private bool CheckCorrectObject(SubscriptionCourse subCourse)
        {
            if (DataBase.Courses.Find(course => course.IdCourse == subCourse.IdCourse) != null)
                if (DataBase.Users.Students().Find(student => student.IdUser == subCourse.IdStudent) != null)
                    return true;

            return false;
        }

        private bool CheckCorrectId(SubscriptionCourse subCourse)
        {
            int targetIndex = this.FindIndex(item => item.IdSubscriptionCourse == subCourse.IdSubscriptionCourse);
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(SubscriptionCourse subCourse)
        {
            if (CheckCorrectObject(subCourse) && CheckCorrectId(subCourse))
            {
                base.Add(subCourse);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));
            }
            else
                throw new Exception("Subscription Course, uncorrect id or object!");
        }

        public new void Remove(SubscriptionCourse subCourse)
        {
            this.RemoveNonSerialized(subCourse);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));
        }

        public new void RemoveAll(Predicate<SubscriptionCourse> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.Subscriptions[index]);

        public void Update(SubscriptionCourse subCourse)
        {
            if (!CheckCorrectObject(subCourse))
                throw new ArgumentOutOfRangeException(nameof(subCourse));

            int objectIndex = DataBase.Subscriptions.FindIndex(item => item.IdSubscriptionCourse == subCourse.IdSubscriptionCourse);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            DataBase.Subscriptions[objectIndex] = subCourse;


            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));
        }

        public new void Clear()
        {
            foreach (SubscriptionCourse subCourse in DataBase.Subscriptions)
            {
                this.RemoveNonSerialized(subCourse);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));
        }


        #region Serialize

        public void RemoveNonSerialized(SubscriptionCourse subCourse)
        {
            base.Remove(subCourse);
        }

        public void RemoveAllNonSerialized(Predicate<SubscriptionCourse> match)
        {
            foreach (SubscriptionCourse subCourse in DataBase.Subscriptions)
            {
                if (match(subCourse))
                    this.RemoveNonSerialized(subCourse);
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
            string path = SerializeSetting.Default.SubscriptionCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            if (Serialize.SerializeObject(DataBase.Subscriptions, path))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string path = SerializeSetting.Default.SubscriptionCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            List<SubscriptionCourse> newListSub = new List<SubscriptionCourse>();
            if (Serialize.DeserializeObject(ref newListSub, path))
            {
                base.Clear();
                base.AddRange(newListSub);
                return true;
            }

            return false;
        }

        #endregion

        private new void AddRange(IEnumerable<SubscriptionCourse> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, SubscriptionCourse item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<SubscriptionCourse> collection) { throw new NotImplementedException(); }
    }
}
