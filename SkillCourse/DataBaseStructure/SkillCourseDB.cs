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

        public CourseCollection Courses { get; set; }


        private SkillCourseDB()
        {
            Courses = new CourseCollection();

            randomAddCourseToCourseCollection();
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


        public void randomAddCourseToCourseCollection()
        {
            Image image = Properties.Resources.image008;

            for (int i = 0; i < 100; i++)
            {
                string nameCourse = $"{i} - ый курс, по программированию!";
                string descriptionCourse = "Description: Это...";

                Course course = new Course(nameCourse, descriptionCourse, image, 0);
                Courses.Add(course);
            }
        }


        //public void addCourse(string groupNumber, string lastName, string firstName, string patronymicNameStud)
        //{
        //    if (instance != null)
        //        this.Students.Add(new Student(groupNumber, lastName, firstName, patronymicNameStud));
        //}
    }
}
