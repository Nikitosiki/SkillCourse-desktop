using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class CourseCollection : List<Course>
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


        public new void Add(Course course)
        {
            //Есть ли такой учитель, который создает курс
            if (CheckCorrectObject(course))
                base.Add(course);
        }

        public new void Remove(Course course)
        {
            DataBase.Tasks.RemoveAll(task => task.IdCourse == course.IdCourse);
            DataBase.Certificates.RemoveAll(certificate => certificate.IdCourse == course.IdCourse);
            DataBase.Subscriptions.RemoveAll(subscription => subscription.IdCourse == course.IdCourse);

            base.Remove(course);
        }

        public new void RemoveAll(Predicate<Course> match)
        {
            foreach (Course course in DataBase.Courses)
            {
                if (match(course))
                    this.Remove(course);
            }
        }

        public new void RemoveAt(int index)
        {
            Course removeCourse = DataBase.Courses[index];
            this.Remove(removeCourse);
        }

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
        }

        public new void Clear()
        {
            foreach (Course course in DataBase.Courses)
            {
                this.Remove(course);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new Exception(); }
        private new void Insert(int index, Course item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new Exception(); }
    }
}
