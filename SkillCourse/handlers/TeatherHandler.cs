using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse
{
    public class TeatherHandler : Teather
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


        public TeatherHandler(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender) :
            base(firstName, lastName, email, password, dateOfBirth, gender) { }



        public List<Course> MyCourses
        {
            get
            {
                return DataBase.Courses.FindAll(course => course.IdTeacher == this.IdUser);
            }
        }

        public List<Task> GetTasks(Course course)
        {
            return DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse).ToList();
        }

        public List<Student> GetStudents(Course course)
        {
            IEnumerable<int> subscriptionIds = DataBase.Subscriptions.Where(sub => sub.IdCourse == course.IdCourse).Select(sub => sub.IdStudent);
            return DataBase.Users.Students().Where(user => subscriptionIds.Contains(user.IdUser)).ToList();
        }

        public List<Certificate> GetCertificate(Course course)
        {
            return DataBase.Certificates.Where(cer => cer.IdCourse == course.IdCourse).ToList();
        }

        public List<Course> FindAllCourses(string search)
        {
            string[] searchWords = search.Split(' '); // разбиваем на отдельные слова
            return DataBase.Courses
                .Where(course => searchWords.Any(word =>
                    course.Name.Contains(word) || course.Description.Contains(word)))
                .ToList();
        }

        public Course? CreateCourse(string name, string description)
        {
            try
            {
                Course newCourse = new Course(name, description, "imageDefaultCourse", this.IdUser);
                DataBase.Courses.Add(newCourse);
                return newCourse;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool ChangeImageToCourse(Course course)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath + "\\Resources";
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    course.ImagePath = openFileDialog.SafeFileName;
                    DataBase.Courses.Update(course);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddStudentToCourse(Course course, Student student)
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

        public bool AddStudentToCourse(Course course, List<Student> students)
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

        public bool AddTaskToCourse(Course course, string textTask)
        {
            try
            {
                // Проверяем, что такой курс существует
                if (DataBase.Courses.Any(cou => cou.IdCourse == course.IdCourse))
                {
                    Task task = new Task(textTask, course.IdCourse);
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
                        List<Task> courseTasks = DataBase.Tasks.Where(task => task.IdCourse == course.IdCourse).ToList();

                        // Находим ответы на задачи для перечисления заданий и студента
                        List<AnswerTask> completedTasks = DataBase.AnswerTasks.Where(ans => ans.IdUser == student.IdUser)
                            .Join(courseTasks, ans => ans.IdTask, task => task.IdTask, (ans, task) => ans).ToList();

                        return courseTasks.Count == completedTasks.Count;
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
