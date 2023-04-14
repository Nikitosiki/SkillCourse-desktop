using SkillCourse.DataBaseStructure.serialize.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class SubscriptionCourse : ICloneable
    {
        private static int idCounter = SkillCourseDB.Instance.Subscriptions.Any() ? SkillCourseDB.Instance.Subscriptions.Max(s => s.IdSubscriptionCourse) : 0;

        private int idSubscriptionCourse;
        private DateTime dateSub;

        private int idCourse;
        private int idStudent;


        public SubscriptionCourse(int idStudent, int idCourse)
        {
            IdSubscriptionCourse = ++idCounter;
            DateSub = DateTime.Now;
            IdCourse = idCourse;
            IdStudent = idStudent;
        }

        [JsonConstructor]
        public SubscriptionCourse(int idSubscriptionCourse, DateTime dateSub, int idStudent, int idCourse)
        {
            idCounter++;
            IdSubscriptionCourse = idSubscriptionCourse;
            DateSub = dateSub;
            IdCourse = idCourse;
            IdStudent = idStudent;
        }

        [DisplayName("Id Subscription Course")]
        public int IdSubscriptionCourse
        {
            get
            {
                return idSubscriptionCourse;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idSubscriptionCourse));
                idSubscriptionCourse = value;
            }
        }

        [DisplayName("Date Subscription")]
        public DateTime DateSub
        {
            get
            {
                return dateSub;
            }
            private set
            {
                if ((value < new DateTime(2000, 01, 01)) || value > DateTime.Now.AddDays(1))
                    throw new ArgumentOutOfRangeException(nameof(dateSub));
                dateSub = value;
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

        [DisplayName("Id Student")]
        public int IdStudent
        {
            get
            {
                return idStudent;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idStudent));
                idStudent = value;
            }
        }


        public object Clone()
        {
            return new SubscriptionCourse(IdSubscriptionCourse, DateSub, IdStudent, IdCourse);
        }
    }
}
