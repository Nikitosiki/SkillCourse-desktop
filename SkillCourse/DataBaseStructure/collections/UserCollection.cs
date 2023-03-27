using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure.entities;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class UserCollection : List<User>
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
            if (targetIndex != -1)
                return true;

            return false;
        }


        public new void Add(User user)
        {
            if (CheckCorrectId(user))
                base.Add(user);
        }

        public new void Remove(User user)
        {
            UserType typeUser = user.UserType;

            switch (typeUser)
            {
                case UserType.Teacher:
                    {
                        DataBase.Courses.RemoveAll(course => course.IdTeacher == user.IdUser);
                        DataBase.AnswerTasks.RemoveAll(answer => answer.IdUser == user.IdUser);
                        DataBase.Certificates.RemoveAll(teather => teather.IdPresenterTeacher == user.IdUser);

                        base.Remove(user);
                    }
                    break;

                case UserType.Student:
                    {
                        DataBase.Subscriptions.RemoveAll(sub => sub.IdStudent == user.IdUser);
                        DataBase.AnswerTasks.RemoveAll(answer => answer.IdUser == user.IdUser);
                        DataBase.Certificates.RemoveAll(owner => owner.IdOwner == user.IdUser);

                        base.Remove(user);
                    }
                    break;

                default:
                    throw new ArgumentNullException(nameof(typeUser));
            }
        }

        public new void RemoveAll(Predicate<User> match)
        {
            foreach (User user in DataBase.Users)
            {
                if (match(user))
                    this.Remove(user);
            }
        }

        public new void RemoveAt(int index)
        {
            User removeUser = DataBase.Users[index];
            this.Remove(removeUser);
        }

        public void Update(User user)
        {
            int objectIndex = DataBase.Users.FindIndex(item => item.IdUser == user.IdUser);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Users[objectIndex] == user)
                return;


            DataBase.Users[objectIndex] = user;
        }

        public new void Clear()
        {
            foreach (User user in DataBase.Users)
            {
                this.Remove(user);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new Exception(); }
        private new void Insert(int index, Course item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new Exception(); }
    }
}
