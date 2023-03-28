using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillCourse.DataBaseStructure.serialize.interfaces;
using SkillCourse.DataBaseStructure.serialize;
using System.IO;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class CourseCollection : List<Course>, ISerializableJSON
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


        private bool CheckCorrectObject(Course course)
        {
            if (DataBase.Users.Teathers().Find(teather => teather.IdUser == course.IdTeacher) != null)
                return true;

            return false;
        }

        private bool CheckCorrectId(Course course)
        {
            int targetIndex = this.FindIndex(item => item.IdCourse == course.IdCourse);
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(Course course)
        {
            if (CheckCorrectObject(course) && CheckCorrectId(course))
            {
                base.Add(course);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
            }
            else
                throw new Exception("Course uncorrect id or object!");
        }

        public new void Remove(Course course)
        {
            this.RemoveNonSerialized(course);

            if (!DataBase.Tasks.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
            if (!DataBase.Certificates.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));
            if (!DataBase.Subscriptions.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Subscriptions));

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
        }

        public new void RemoveAll(Predicate<Course> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.Courses[index]);

        public void Update(Course course)
        {
            if (!CheckCorrectObject(course))
                throw new ArgumentOutOfRangeException(nameof(course));

            int objectIndex = DataBase.Courses.FindIndex(item => item.IdCourse == course.IdCourse);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Courses[objectIndex] == course)
                return;


            DataBase.Courses[objectIndex] = course;

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
        }

        public new void Clear()
        {
            foreach (Course course in DataBase.Courses)
            {
                this.RemoveNonSerialized(course);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
        }


        #region Serialize

        public void RemoveNonSerialized(Course course)
        {
            DataBase.Tasks.RemoveAllNonSerialized(task => task.IdCourse == course.IdCourse);
            DataBase.Certificates.RemoveAllNonSerialized(certificate => certificate.IdCourse == course.IdCourse);
            DataBase.Subscriptions.RemoveAllNonSerialized(subscription => subscription.IdCourse == course.IdCourse);

            base.Remove(course);
        }

        public void RemoveAllNonSerialized(Predicate<Course> match)
        {
            foreach (Course course in DataBase.Courses)
            {
                if (match(course))
                    this.RemoveNonSerialized(course);
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
            string path = SerializeSetting.Default.CourseCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            if (Serialize.SerializeObject(DataBase.Courses, path))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string path = SerializeSetting.Default.CourseCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(path))
                throw new ArgumentException("Uncorrect Path: " + nameof(path));

            List<Course> newListCourse = new List<Course>();
            if (Serialize.DeserializeObject(ref newListCourse, path))
            {
                base.Clear();
                base.AddRange(newListCourse);
                return true;
            }

            return false;
        }

        #endregion

        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }

    }
}
