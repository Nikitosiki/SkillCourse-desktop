using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using System.Xml.Linq;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Task : ICloneable
    {
        private static int idCounter = SkillCourseDB.Instance.Tasks.Any() ? SkillCourseDB.Instance.Tasks.Max(t => t.idTask) : 0;

        private int idTask;
        private string textTask;
        private bool taskTypeMessage = false;
        private DateTime taskStartTime;

        private int idCourse;


        public Task(string textTask, int idCourse)
        {
            IdTask = ++idCounter;
            TextTask = textTask;
            IdCourse = idCourse;
            TaskTypeMessage = false;
            TaskStartTime = DateTime.Now;
        }

        public Task(string textTask, int idCourse, bool taskTypeMessage)
        {
            IdTask = ++idCounter;
            TextTask = textTask;
            IdCourse = idCourse;
            TaskTypeMessage = taskTypeMessage;
            TaskStartTime = DateTime.Now;
        }

        [JsonConstructor]
        public Task(int idTask, string textTask, int idCourse, bool taskTypeMessage, DateTime taskStartTime)
        {
            idCounter++;
            IdTask = idTask;
            TextTask = textTask;
            IdCourse = idCourse;
            TaskTypeMessage = taskTypeMessage;
            TaskStartTime = taskStartTime;
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

        [DisplayName("Task Type Message")]
        public bool TaskTypeMessage
        {
            get
            {
                return taskTypeMessage;
            }
            private set
            {
                taskTypeMessage = value;
            }
        }

        [DisplayName("Task Start Time")]
        public DateTime TaskStartTime
        {
            get
            {
                return taskStartTime;
            }
            private set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(taskStartTime));
                taskStartTime = value;
            }
        }


        public object Clone()
        {
            return new Task(IdCourse, TextTask, IdCourse, TaskTypeMessage, TaskStartTime);
        }
    }
}
