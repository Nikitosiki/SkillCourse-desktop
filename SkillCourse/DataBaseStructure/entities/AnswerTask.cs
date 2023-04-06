using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using SkillCourse.DataBaseStructure.types;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class AnswerTask : ICloneable
    {
        private static int idCounter = 0;

        private int idAnswerToTask;
        private StateTask state = StateTask.NotDone;
        private int? grade;
        //private string? text;

        private int idTask;
        private int idUser;


        public AnswerTask(StateTask state, int? grade, int idTask, int idUser)
        {
            IdAnswerToTask = ++idCounter;
            State = state;
            Grade = grade;
            IdTask = idTask;
            IdUser = idUser;
        }

        private AnswerTask(int id, StateTask state, int? grade, int idTask, int idUser)
        {
            IdAnswerToTask = id;
            State = state;
            Grade = grade;
            IdTask = idTask;
            IdUser = idUser;
        }

        [DisplayName("Id Answer To Task")]
        public int IdAnswerToTask
        {
            get
            {
                return idAnswerToTask;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idAnswerToTask));
                idAnswerToTask = value;
            }
        }

        [DisplayName("State Task")]
        public StateTask State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        [DisplayName("Grade")]
        public int? Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(grade));
                grade = value;
            }
        }

        //[DisplayName("Text")]
        //public string? Text
        //{
        //    get
        //    {
        //        return text;
        //    }
        //    set
        //    {
        //        text = value;
        //    }
        //}

        [DisplayName("Id Task")]
        public int IdTask
        {
            get
            {
                return idTask;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idTask));
                idTask = value;
            }
        }

        [DisplayName("Id User")]
        public int IdUser
        {
            get
            {
                return idUser;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idUser));
                idUser = value;
            }
        }


        public object Clone()
        {
            return new AnswerTask(IdAnswerToTask, State, Grade, IdTask, IdUser);
        }
    }
}
