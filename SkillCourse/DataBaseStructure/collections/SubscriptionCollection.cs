using SkillCourse.DataBaseStructure.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class SubscriptionCollection : List<SubscriptionCourse>
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
            if (targetIndex != -1)
                return true;

            return false;
        }


        public new void Add(SubscriptionCourse subCourse)
        {
            if (CheckCorrectObject(subCourse) && CheckCorrectId(subCourse))
                base.Add(subCourse);
        }

        public new void Remove(SubscriptionCourse subCourse)
        {           
            base.Remove(subCourse);
        }

        public new void RemoveAll(Predicate<SubscriptionCourse> match)
        {
            foreach (SubscriptionCourse subCourse in DataBase.Subscriptions)
            {
                if (match(subCourse))
                    this.Remove(subCourse);
            }
        }

        public new void RemoveAt(int index)
        {
            SubscriptionCourse removeSub = DataBase.Subscriptions[index];
            this.Remove(removeSub);
        }

        public void Update(SubscriptionCourse subCourse)
        {
            if (!CheckCorrectObject(subCourse))
                throw new ArgumentOutOfRangeException(nameof(subCourse));

            int objectIndex = DataBase.Subscriptions.FindIndex(item => item.IdSubscriptionCourse == subCourse.IdSubscriptionCourse);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Subscriptions[objectIndex] == subCourse)
                return;


            DataBase.Subscriptions[objectIndex] = subCourse;
        }

        public new void Clear()
        {
            foreach (SubscriptionCourse subCourse in DataBase.Subscriptions)
            {
                this.Remove(subCourse);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }
    }
}
