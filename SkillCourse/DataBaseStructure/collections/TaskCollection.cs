using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class TaskCollection : List<Task>
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


        private bool CheckCorrectObject(Task task)
        {
            if (DataBase.Courses.Find(course => course.IdCourse == task.IdCourse) != null)
                return true;

            return false;
        }

        private bool CheckCorrectId(Task task)
        {
            int targetIndex = this.FindIndex(item => item.IdTask == task.IdTask);
            if (targetIndex != -1)
                return true;

            return false;
        }


        public new void Add(Task task)
        {
            if (CheckCorrectObject(task) && CheckCorrectId(task))
                base.Add(task);
        }

        public new void Remove(Task task)
        {
            DataBase.AnswerTasks.RemoveAll(answer => answer.IdTask == task.IdTask);

            base.Remove(task);
        }

        public new void RemoveAll(Predicate<Task> match)
        {
            foreach (Task task in DataBase.Tasks)
            {
                if (match(task))
                    this.Remove(task);
            }
        }

        public new void RemoveAt(int index)
        {
            Task task = DataBase.Tasks[index];
            this.Remove(task);
        }

        public void Update(Task task)
        {
            if (!CheckCorrectObject(task))
                throw new ArgumentOutOfRangeException(nameof(task));

            int objectIndex = DataBase.Tasks.FindIndex(item => item.IdTask == task.IdTask);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.Tasks[objectIndex] == task)
                return;


            DataBase.Tasks[objectIndex] = task;
        }

        public new void Clear()
        {
            foreach (Task task in DataBase.Tasks)
            {
                this.Remove(task);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }
    }
}
