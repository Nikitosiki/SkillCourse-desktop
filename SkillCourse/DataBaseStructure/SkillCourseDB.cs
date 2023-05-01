using System;
using System.Collections.Generic;
using System.IO;
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

            FullDBDeserialize();              
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


        private bool FullDBDeserialize()
        {
            if (!Users.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(Users));
            if (!Courses.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(Courses));
            if (!Tasks.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(Tasks));
            if (!AnswerTasks.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(AnswerTasks));
            if (!Subscriptions.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(Subscriptions));
            if (!Certificates.DeserializeObject())
                throw new ArgumentException("Uncorrect Deserialize: " + nameof(Certificates));

            return true;
        }

        //public void addCourse(string groupNumber, string lastName, string firstName, string patronymicNameStud)
        //{
        //    if (instance != null)
        //        this.Students.Add(new Student(groupNumber, lastName, firstName, patronymicNameStud));
        //}
    }
}
