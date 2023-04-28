using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.DataBaseStructure
{
    public partial class Student
    {
        [JsonIgnore]
        private static SkillCourseDB? instanceDB = null;
        [JsonIgnore]
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

        [JsonIgnore]
        public List<Course> CoursesSubscribed
        {
            get
            {
                IEnumerable<int> courseIds = DataBase.Subscriptions.Where(sub => sub.IdStudent == this.IdUser).Select(sub => sub.IdCourse);
                return DataBase.Courses.Where(course => courseIds.Contains(course.IdCourse)).ToList();
            }
        }

        [JsonIgnore]
        public List<Certificate> MyCertificates
        {
            get
            {
                return DataBase.Certificates.FindAll(ser => ser.IdOwner == this.IdUser);
            }
        }

        public Course? GetCourse(string name)
        {
            return DataBase.Courses.FindLast(course => course.Name == name);
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

        public List<Task> GetOnlyTask_Assigned(Course course)
        {
            return DataBase.Tasks
                .Where(task => task.IdCourse == course.IdCourse &&
                               task.TaskTypeMessage == false &&
                               DataBase.AnswerTasks.Any(answerTask => answerTask.IdTask == task.IdTask && answerTask.State == StateTask.Done))
                .OrderBy(task => task.TaskStartTime)
                .ToList();
        }

        public List<Task> GetOnlyTask_Checked(Course course)
        {
            return DataBase.Tasks
                .Where(task => task.IdCourse == course.IdCourse &&
                               task.TaskTypeMessage == false &&
                               DataBase.AnswerTasks.Any(answerTask => answerTask.IdTask == task.IdTask && answerTask.State == StateTask.Checked))
                .OrderBy(task => task.TaskStartTime)
                .ToList();
        }

        public List<Task> GetOnlyTask_Missing(Course course)
        {
            return DataBase.Tasks
                .Where(task => task.IdCourse == course.IdCourse &&
                               task.TaskTypeMessage == false &&
                               (!DataBase.AnswerTasks.Any(answerTask => answerTask.IdTask == task.IdTask) ||
                                DataBase.AnswerTasks.Any(answerTask => answerTask.IdTask == task.IdTask && answerTask.State == StateTask.NotDone)))
                .OrderBy(task => task.TaskStartTime)
                .ToList();
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

        //--- Does not work correctly
        public void SortCoursesByName(ref List<Course> listCourse)
        {
            listCourse.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
        }

        //--- Does not work correctly
        public void SortCoursesBySubscription(ref List<Course> courses)
        {
            List<SubscriptionCourse> subscriptions = DataBase.Subscriptions.FindAll(s => s.IdStudent == this.IdUser);

            // Используем метод List<T>.Sort() с передачей делегата сравнения для сортировки по наличию подписок
            courses.Sort((c1, c2) =>
            {
                // Проверяем наличие подписки на курсы
                bool c1HasSubscription = subscriptions.Any(s => s.IdCourse == c1.IdCourse);
                bool c2HasSubscription = subscriptions.Any(s => s.IdCourse == c2.IdCourse);

                // Сортируем курсы таким образом, чтобы сначала были курсы с подписками, а потом без подписок
                if (c1HasSubscription && !c2HasSubscription)
                {
                    return -1; // c1 с подпиской, c2 без подписки - c1 меньше, должен быть раньше
                }
                else if (!c1HasSubscription && c2HasSubscription)
                {
                    return 1; // c1 без подписки, c2 с подпиской - c1 больше, должен быть позже
                }
                else
                {
                    return c1.Name.CompareTo(c2.Name); // Если подписки одинаковы или отсутствуют, сортируем по названию
                }
            });
        }

        public bool CheckSubscrib(Course course)
        {          
            return DataBase.Subscriptions.Any(sub => sub.IdStudent == this.IdUser && sub.IdCourse == course.IdCourse);
        }

        public bool CheckCompletedOrBallTask(Task task)
        {
            return DataBase.AnswerTasks.Any(ans => ans.IdTask == task.IdTask
            && ans.IdUser == this.IdUser && ans.State != StateTask.NotDone);
        }

        public string GetBallToTask(Task task)
        {
            if (CheckCompletedOrBallTask(task))
            {
                AnswerTask answer = DataBase.AnswerTasks.Find(ans => ans.IdTask == task.IdTask && ans.IdUser == this.IdUser);

                if (answer.State == StateTask.Done)
                    return $"Assigned";

                if (answer.State == StateTask.Checked)
                    return $"{answer.Grade} / 5";

                return $"Send";  //Error
            }
            else
            {
                return $"Missing";
            }

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

        public bool UnSubscripToCourse(Course course)
        {
            try
            {
                var subRemove = DataBase.Subscriptions.FindLast(sub => sub.IdCourse == course.IdCourse && sub.IdStudent == this.IdUser);
                if (subRemove != null)
                {
                    DataBase.Subscriptions.Remove(subRemove);
                    return true;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CompleteTask(Task task, string answerText)
        {
            try
            {
                // Проверяем, есть ли такой task
                if (DataBase.Tasks.Any(tas => tas.IdTask == task.IdTask))
                {
                    // Проверяем, что нету ли такого ответа
                    if (!DataBase.AnswerTasks.Any(ans => ans.IdTask == task.IdTask && ans.IdUser == this.IdUser))
                    {
                        AnswerTask answer = new AnswerTask(StateTask.Done, null, answerText, task.IdTask, this.IdUser);
                        DataBase.AnswerTasks.Add(answer);

                        return true;

                    }

                    // Проверяем, если есть такой ответ, может он NotDone, и его можно сдать
                    if (DataBase.AnswerTasks.Any(ans => ans.IdTask == task.IdTask && ans.IdUser == this.IdUser && ans.State == StateTask.NotDone))
                    {
                        AnswerTask answer = DataBase.AnswerTasks.Where(ans => ans.IdTask == task.IdTask).Last();
                        answer.State = StateTask.Done;
                        answer.Text = answerText;
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
