using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillCourse.DataBaseStructure.types;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class AnswerTask
    {
        private static int idCounter = 0;

        private int idAnswerToTask;
        private StateTask state;
        private int grade;

        private int idTask;
        private int idUser;


        public AnswerTask(StateTask state, int grade, int idTask, int idUser)
        {
            IdAnswerToTask = idCounter++;
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
        public int Grade
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
    }
}
