using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.serialize.interfaces;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class UserCollection : List<User>, ISerializableJSON
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



        public List<Teather> Teathers()
        {
            List<User> userTeacher = DataBase.Users.FindAll(user => (user.UserType == types.UserType.Teacher));
            return userTeacher.Cast<Teather>().ToList();
        }

        public List<Student> Students()
        {
            List<User> userTeacher = DataBase.Users.FindAll(user => (user.UserType == types.UserType.Student));
            return userTeacher.Cast<Student>().ToList();
        }



        private bool CheckCorrectId(User user)
        {
            int targetIndex = this.FindIndex(item => item.IdUser == user.IdUser);
            if (targetIndex == -1)
                return true;

            return false;
        }


        public new void Add(User user)
        {
            if (CheckCorrectId(user))
            {
                base.Add(user);
                if (!SerializeObject())
                    throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Users));
            }
            else
                throw new Exception("User uncorrect id!");
        }

        public new void Remove(User user)
        {
            this.RemoveNonSerialized(user);

            if (!DataBase.Courses.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Courses));
            if (!DataBase.AnswerTasks.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.AnswerTasks));
            if (!DataBase.Tasks.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Tasks));
            if (!DataBase.Certificates.SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Certificates));

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Users));
        }

        public new void RemoveAll(Predicate<User> match)
        {
            this.RemoveAllNonSerialized(match);

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Users));
        }

        public new void RemoveAt(int index) => this.Remove(DataBase.Users[index]);

        public void Update(User user)
        {
            int objectIndex = DataBase.Users.FindIndex(item => item.IdUser == user.IdUser);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Users[objectIndex] == user)
                return;


            DataBase.Users[objectIndex] = user;

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Users));
        }

        public new void Clear()
        {
            foreach (User user in DataBase.Users)
            {
                this.RemoveNonSerialized(user);
            }

            if (!SerializeObject())
                throw new ArgumentException("Uncorrect Serialize: " + nameof(DataBase.Users));
        }


        #region Serialize

        public void RemoveNonSerialized(User user)
        {
            UserType typeUser = user.UserType;

            switch (typeUser)
            {
                case UserType.Teacher:
                    {
                        DataBase.Courses.RemoveAllNonSerialized(course => course.IdTeacher == user.IdUser);
                        DataBase.AnswerTasks.RemoveAllNonSerialized(answer => answer.IdUser == user.IdUser);
                        DataBase.Certificates.RemoveAllNonSerialized(teather => teather.IdPresenterTeacher == user.IdUser);

                        base.Remove(user);
                    }
                    break;

                case UserType.Student:
                    {
                        DataBase.Subscriptions.RemoveAllNonSerialized(sub => sub.IdStudent == user.IdUser);
                        DataBase.AnswerTasks.RemoveAllNonSerialized(answer => answer.IdUser == user.IdUser);
                        DataBase.Certificates.RemoveAllNonSerialized(owner => owner.IdOwner == user.IdUser);

                        base.Remove(user);
                    }
                    break;

                default:
                    throw new ArgumentNullException(nameof(typeUser));
            }
        }

        public void RemoveAllNonSerialized(Predicate<User> match)
        {
            foreach (User user in DataBase.Users)
            {
                if (match(user))
                    this.RemoveNonSerialized(user);
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
            string pathStud = SerializeSetting.Default.StudentCollectionSerializationPath;
            string pathTeat = SerializeSetting.Default.TeatherCollectionSerializationPath;

            if (!CheckCorrectPathToSerialize(pathStud))
                throw new ArgumentException("Uncorrect Path: " + nameof(pathStud));

            if (!CheckCorrectPathToSerialize(pathTeat))
                throw new ArgumentException("Uncorrect Path: " + nameof(pathTeat));

            if (Serialize.SerializeObject(DataBase.Users.Teathers(), pathStud)
                && Serialize.SerializeObject(DataBase.Users.Students(), pathTeat))
                return true;

            return false;
        }

        public bool DeserializeObject()
        {
            string pathStud = SerializeSetting.Default.StudentCollectionSerializationPath;
            string pathTeat = SerializeSetting.Default.TeatherCollectionSerializationPath;

            if (!CheckCorrectPathToDeserialize(pathStud))
                throw new ArgumentException("Uncorrect Path: " + nameof(pathStud));

            if (!CheckCorrectPathToDeserialize(pathTeat))
                throw new ArgumentException("Uncorrect Path: " + nameof(pathTeat));

            List<Teather> newListTeather = new List<Teather>();
            List<Student> newListStudent = new List<Student>();
            if (Serialize.DeserializeObject(ref newListStudent, pathStud) && Serialize.DeserializeObject(ref newListTeather, pathStud))
            {
                base.Clear();
                base.AddRange(newListTeather);
                base.AddRange(newListStudent);
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
