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

        public static User? GetUser(int idUser)
        {
            return DataBase.Users.Find(user => user.IdUser == idUser);
        }

        public static Course? GetCourse(SubscriptionCourse sub)
        {
            return DataBase.Courses.Find(cour => cour.IdCourse == sub.IdCourse);
        }

        public static Course? GetCourse(int idCourse)
        {
            return DataBase.Courses.Find(cour => cour.IdCourse == idCourse);
        }

        public static string GetFullName(User user)
        {
            return $"{user.FirstName} {user.LastName}";
        }

        public static string GetFullName(int idUser)
        {
            User? user = DataBase.Users.Find(user => user.IdUser == idUser);
            return user != null ? $"{user.FirstName} {user.LastName}" : String.Empty;
        }

        public static Course? FindCourse(string name)
        {
            return DataBase.Courses.FindLast(course => course.Name == name);
        }

        public static Task? FindTask(Course course, string name)
        {
            return DataBase.Tasks.FindLast(task => task.IdCourse == course.IdCourse && task.TextTask == name);
        }

        public static Student? GetStudent(AnswerTask answer)
        {
            return DataBase.Users.Students().Find(user => user.IdUser == answer.IdUser);
        }

        public static Student? GetStudent(SubscriptionCourse sub)
        {
            return DataBase.Users.Students().Find(user => user.IdUser == sub.IdStudent);
        }

        public static List<Student> GetStudents(Course course)
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser))
                .OrderBy(user => user.LastName).ToList();
        }

        public static List<Student> GetStudentsOut(Course course)
        {
            
            return DataBase.Users.Students().Except(GetStudents(course)).ToList();
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
