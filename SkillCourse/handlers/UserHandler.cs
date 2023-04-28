using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.handlers
{
    public static class UserHandler
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


        public static List<Student> GetStudents(Course course)
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser))
                .OrderBy(user => user.LastName).ToList();
        }

        public static Teather? GetTeacher(Course course)
        {
            return DataBase.Users.Teathers().Find(cours => cours.IdUser == course.IdTeacher);
        }

        public static List<Task> GetAllTasks(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse)
                .OrderBy(task => task.TaskStartTime).ToList();
        }

        public static List<Task> GetOnlyTask(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse && task.TaskTypeMessage == false)
                .OrderBy(task => task.TaskStartTime).ToList();
        }
    }
}
