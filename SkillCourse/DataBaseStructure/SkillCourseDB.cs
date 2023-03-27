using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class SkillCourseDB
    {
        private static SkillCourseDB? instance;

        public AnswerToTaskCollection AnswerTasks { get; set; }
        public CertificateCollection Certificates { get; set; }
        public SubscriptionCollection Subscriptions { get; set; }
        public CourseCollection Courses { get; set; }
        public TaskCollection Tasks { get; set; }
        public UserCollection Users { get; set; }



        private SkillCourseDB()
        {
            AnswerTasks = new AnswerToTaskCollection();
            Certificates = new CertificateCollection();
            Subscriptions = new SubscriptionCollection();
            Courses = new CourseCollection();
            Tasks = new TaskCollection();
            Users = new UserCollection();
        }

        public static SkillCourseDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SkillCourseDB();
                }
                return instance;
            }
        }


        //public void addCourse(string groupNumber, string lastName, string firstName, string patronymicNameStud)
        //{
        //    if (instance != null)
        //        this.Students.Add(new Student(groupNumber, lastName, firstName, patronymicNameStud));
        //}
    }
}
