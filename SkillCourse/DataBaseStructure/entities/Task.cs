using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Task
    {
        private static int idCounter = 0;

        private int idTask;
        private string textTask;

        private int idCourse;

        public Task(string textTask, int idCourse)
        {
            IdTask = idCounter++;
            TextTask = textTask;
            IdCourse = idCourse;
        }

        [DisplayName("Id Task")]
        public int IdTask
        {
            get
            {
                return idTask;
            }
            private set
            {
                if (value < 0)                    
                    throw new ArgumentOutOfRangeException(nameof(idTask));
                idTask = value;
            }
        }

        [DisplayName("Text Task")]
        public string TextTask
        {
            get
            {
                return textTask;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(textTask));
                textTask = value;
            }
        }

        [DisplayName("Id Course")]
        public int IdCourse
        {
            get
            {
                return idCourse;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idCourse));
                idCourse = value;
            }
        }
    }
}
