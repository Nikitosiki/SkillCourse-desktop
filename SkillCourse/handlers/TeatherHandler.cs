using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.DataBaseStructure
{
    public partial class Teather
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
        public List<Course> MyCourses
        {
            get
            {
                return DataBase.Courses.FindAll(course => course.IdTeacher == this.IdUser);
            }
        }

        public List<AnswerTask> GetAllAnswerTask_Waiting(Task task)     // Ожидают проверки
        {
            return DataBase.AnswerTasks.Where(anwer => anwer.IdTask == task.IdTask && anwer.State == StateTask.Done).ToList();
        }

        public List<AnswerTask> GetAllAnswerTask_Checked(Task task)     // Проверенные задания
        {
            return DataBase.AnswerTasks.Where(anwer => anwer.IdTask == task.IdTask && anwer.State == StateTask.Checked).ToList();
        }

        public List<SubscriptionCourse> GetOnlySub_Waiting(Course course)     // У которых ещё нету сертификата
        {
            return DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse && 
                !DataBase.Certificates.Any(cer => cer.IdCourse == course.IdCourse && cer.IdOwner == sub.IdStudent))
                .ToList();
        }

        public List<SubscriptionCourse> GetOnlySub_Issued(Course course)     // Которым уже выдан сертификат
        {
            return DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse &&
                DataBase.Certificates.Any(cer => cer.IdCourse == course.IdCourse && cer.IdOwner == sub.IdStudent))
                .ToList();
        }

        public List<Task> GetTasksNoMessage(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse && task.TaskTypeMessage == false).ToList();
        }

        public List<Task> GetTasks(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse).ToList();
        }

        public Task? GetTask(AnswerTask answer)
        {
            return DataBase.Tasks.FindLast(task => task.IdTask == answer.IdTask);
        }

        public List<Task> GetAllMyTasks()
        {
            return DataBase.Tasks.Where(task => MyCourses.Any(course => course.IdCourse == task.IdCourse)).ToList();
        }

        public List<Student> GetStudents(Course course)
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser)).ToList();
        }

        public List<Student> GetAllStudents()
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => MyCourses.Any(course => course.IdCourse == sub.IdCourse)).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser)).ToList();
        }

        public List<Certificate> GetCertificate(Course course)
        {
            return DataBase.Certificates.Where(cer => cer.IdCourse == course.IdCourse).ToList();
        }

        public List<AnswerTask> GetAnswersToBeChecked(Course course)
        {
            // Находим задачи для курса
            List<Task> courseTasks = DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse).ToList();

            // Находим ответы на задачи для перечисления заданий
            return DataBase.AnswerTasks
                .Join(courseTasks, ans => ans.IdTask, task => task.IdTask, (ans, task) => ans)
                .Where(answer => answer.State == StateTask.Done)
                .ToList();
        }

        public List<Course> FindAllCourses(string search)
        {
            string[] searchWords = search.Split(' '); // разбиваем на отдельные слова
            return DataBase.Courses
                .Where(course => searchWords.Any(word =>
                    course.Name.Contains(word) || course.Description.Contains(word)))
                .ToList();
        }

        public int ProcentCompleteCourse(SubscriptionCourse sub)
        {
            List<Task> tasksCourseThisSub = DataBase.Tasks.Where(task => task.IdCourse == sub.IdCourse).ToList();

            int allTask = DataBase.Tasks.Where(task => task.IdCourse == sub.IdCourse && task.TaskTypeMessage == false).Count();

            // Если заданий нету, то мы выполнилит на 100%
            if (allTask == 0)
                return 100;

            int completeTask = DataBase.AnswerTasks.Where(answer =>
                (answer.State == StateTask.Done || answer.State == StateTask.Checked) &&
                answer.IdUser == sub.IdStudent &&
                tasksCourseThisSub.Any(task => task.IdTask == answer.IdTask)
                ).Count();

            if (completeTask == 0)
                return 0;

            return (Int32)(((double)completeTask / (double)allTask) * 100);
        }

        public Course? CreateCourse(Course newCourse)
        {
            try
            {
                DataBase.Courses.Add(newCourse);
                return newCourse;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Course? CreateCourse(string name, string description)
        {
            try
            {
                if (name == null || name == "" || description == null || description == "")
                    return null;

                Course newCourse = new Course(name, description, "imageDefaultCourse", this.IdUser);
                DataBase.Courses.Add(newCourse);
                return newCourse;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UnSubscripStudentToCourse(Course course, Student student)
        {
            try
            {
                var subRemove = DataBase.Subscriptions.FindLast(sub => sub.IdCourse == course.IdCourse && sub.IdStudent == student.IdUser);
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

        public bool SubscripStudentToCourse(Course course, Student student)
        {
            try
            {
                // Проверяем, что студент еще не подписан на курс
                if (!DataBase.Subscriptions.Any(sub => sub.IdCourse == course.IdCourse && sub.IdStudent == student.IdUser))
                {
                    SubscriptionCourse subscription = new SubscriptionCourse
                    (
                        student.IdUser,
                        course.IdCourse
                    );
                    DataBase.Subscriptions.Add(subscription);

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SubscripStudentToCourse(Course course, List<Student> students)
        {
            try
            {
                foreach (Student student in students)
                {
                    // Проверяем, что студент еще не подписан на курс
                    if (!DataBase.Subscriptions.Any(sub => sub.IdCourse == course.IdCourse && sub.IdStudent == student.IdUser))
                    {
                        SubscriptionCourse subscription = new SubscriptionCourse
                        (
                            student.IdUser,
                            course.IdCourse
                        );
                        DataBase.Subscriptions.Add(subscription);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddTaskToCourse(Course course, string textTask, bool taskTypeMessage)
        {
            try
            {
                // Проверяем, что такой курс существует
                if (DataBase.Courses.Any(cou => cou.IdCourse == course.IdCourse))
                {
                    if (textTask == null || textTask == "")
                        return false;

                    Task task = new Task(textTask, course.IdCourse, taskTypeMessage);
                    DataBase.Tasks.Add(task);

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddCertificate(int idCourse, int idStudent, string description)
        {
            return AddCertificate(
                DataBase.Courses.Find(course => course.IdCourse == idCourse),
                DataBase.Users.Students().Find(user => user.IdUser == idStudent),
                description);
        }

        public bool AddCertificate(Course course, Student student, string description)
        {
            try
            {
                // Проверяем, что такой курс и студент существует
                if (DataBase.Courses.Any(cou => cou.IdCourse == course.IdCourse) &&
                    DataBase.Users.Students().Any(user => user.IdUser == user.IdUser))
                    //Нет ли уже такого сертификата
                    if (!DataBase.Certificates.Any(Cer => Cer.IdCourse == course.IdCourse && Cer.IdOwner == student.IdUser))                    
                    {
                        //Проверяем что студент выполнил все задания
                        //------------------------------------------


                        // Находим задачи для заданного курса
                        List<Task> courseTasks = DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse && task.TaskTypeMessage == false).ToList();

                        // Находим ответы на задачи для перечисления заданий и студента
                        List<AnswerTask> completedTasks = DataBase.AnswerTasks.Where(ans => ans.IdUser == student.IdUser)
                            .Join(courseTasks, ans => ans.IdTask, task => task.IdTask, (ans, task) => ans).ToList();

                        if (courseTasks.Count != completedTasks.Count)
                            return false;

                        Certificate newCertificate = new Certificate(description, DateTime.Now, this.IdUser, student.IdUser, course.IdCourse);
                        DataBase.Certificates.Add(newCertificate);

                        return true;
                    }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Оценить задание
        public bool RateTask(AnswerTask answer, int garde)
        {
            try
            {
                if (DataBase.AnswerTasks.Any(ans => ans.IdTask == answer.IdTask))
                {
                    answer.Grade = garde;
                    answer.State = StateTask.Checked;
                    DataBase.AnswerTasks.Update(answer);

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
