using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.DataBaseStructure
{
    public partial class Student
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

        public List<Task> GetAllTasks(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse)
                .OrderBy(task => task.TaskStartTime).ToList();
        }

        public List<Task> GetOnlyTask(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse && task.TaskTypeMessage == false)
                .OrderBy(task => task.TaskStartTime).ToList();
        }

        public List<Student> GetStudents(Course course)
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser))
                .OrderBy(user => user.LastName).ToList();
        }

        public Teather? GetTeacher(Course course)
        {
            return DataBase.Users.Teathers().Find(cours => cours.IdUser == course.IdTeacher);
        }

        public List<Course> FindAllCourses(string search)
        {
            string[] searchWords = search.Split(' '); // разбиваем на отдельные слова
            return DataBase.Courses
                .Where(course => searchWords.Any(word =>
                    course.Name.Contains(word) || course.Description.Contains(word)))
                .ToList();
        }

        public bool SubscripToCourse(Course course)
        {
            try
            {
                // Проверяем, что студент еще не подписан на курс
                if (!DataBase.Subscriptions.Any(sub => sub.IdCourse == course.IdCourse && sub.IdStudent == this.IdUser))
                {
                    SubscriptionCourse subscription = new SubscriptionCourse
                    (
                        this.IdUser,
                        course.IdCourse
                    );
                    DataBase.Subscriptions.Add(subscription);

                    return true;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CompleteTask(Task task)
        {
            try
            {
                // Проверяем, есть ли такой task
                if (DataBase.Tasks.Any(tas => tas.IdTask == task.IdTask))
                {
                    // Проверяем, что нету ли такого ответа
                    if (!DataBase.AnswerTasks.Any(ans => ans.IdTask == task.IdTask))
                    {
                        AnswerTask answer = new AnswerTask(StateTask.Done, null, task.IdTask, this.IdUser);
                        DataBase.AnswerTasks.Update(answer);

                        return true;

                    }

                    // Проверяем, если есть такой ответ, может он NotDone, и его можно сдать
                    if (DataBase.AnswerTasks.Any(ans => ans.IdTask == task.IdTask && ans.State == StateTask.NotDone))
                    {
                        AnswerTask answer = DataBase.AnswerTasks.Where(ans => ans.IdTask == task.IdTask).Last();
                        answer.State = StateTask.Done;
                        DataBase.AnswerTasks.Update(answer);

                        return true;
                    }

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
