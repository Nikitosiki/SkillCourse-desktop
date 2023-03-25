﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class SubscriptionCourse
    {
        private static int idCounter = 0;

        private int idSubscriptionCourse;
        private DateTime dateSub;

        private int idCourse;
        private int idStudent;

        public SubscriptionCourse(int idStudent, int idCourse)
        {
            IdSubscriptionCourse = idCounter++;
            DateSub = DateTime.Now;
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
    }
}