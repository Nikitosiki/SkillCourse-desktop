using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    public class AnswerToTaskCollection : List<AnswerTask>
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


        private bool CheckCorrectObject(AnswerTask answer)
        {
            if (DataBase.Tasks.Find(task => task.IdTask == answer.IdTask) != null)
                if (DataBase.Users.Students().Find(student => student.IdUser == answer.IdUser) != null)
                    return true;

            return false;
        }

        private bool CheckCorrectId(AnswerTask answer)
        {
            int targetIndex = this.FindIndex(item => item.IdAnswerToTask == answer.IdAnswerToTask);
            if (targetIndex != -1)
                return true;

            return false;
        }


        public new void Add(AnswerTask answer)
        {
            if (CheckCorrectObject(answer) && CheckCorrectId(answer))
                base.Add(answer);
        }

        public new void Remove(AnswerTask answer)
        {
            base.Remove(answer);
        }

        public new void RemoveAll(Predicate<AnswerTask> match)
        {
            foreach (AnswerTask answer in DataBase.AnswerTasks)
            {
                if (match(answer))
                    this.Remove(answer);
            }
        }

        public new void RemoveAt(int index)
        {
            AnswerTask answer = DataBase.AnswerTasks[index];
            this.Remove(answer);
        }

        public void Update(AnswerTask answer)
        {
            if (!CheckCorrectObject(answer))
                throw new ArgumentOutOfRangeException(nameof(answer));

            int objectIndex = DataBase.AnswerTasks.FindIndex(item => item.IdAnswerToTask == answer.IdAnswerToTask);

            if (objectIndex == -1)
                throw new ArgumentOutOfRangeException(nameof(objectIndex));

            if (DataBase.AnswerTasks[objectIndex] == answer)
                return;


            DataBase.AnswerTasks[objectIndex] = answer;
        }

        public new void Clear()
        {
            foreach (AnswerTask answer in DataBase.AnswerTasks)
            {
                this.Remove(answer);
            }
        }




        private new void AddRange(IEnumerable<Course> collection) { throw new NotImplementedException(); }
        private new void Insert(int index, Course item) { throw new NotImplementedException(); }
        private new void InsertRange(int index, IEnumerable<Course> collection) { throw new NotImplementedException(); }
    }
}
