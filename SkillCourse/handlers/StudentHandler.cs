using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse
{
    public class StudentHandler : Student
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



        public StudentHandler(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender) :
            base(firstName, lastName, email, password, dateOfBirth, gender) { }


        public List<Course> CoursesSubscribed
        {
            get
            {
                IEnumerable<int> courseIds = DataBase.Subscriptions.Where(sub => sub.IdStudent == this.IdUser).Select(sub => sub.IdCourse);
                return DataBase.Courses.Where(course => courseIds.Contains(course.IdCourse)).ToList();
            }
        }

        public List<Certificate> MyCertificates
        {
            get
            {
                return DataBase.Certificates.FindAll(ser => ser.IdOwner == this.IdUser);
            }
        }

    }
}
