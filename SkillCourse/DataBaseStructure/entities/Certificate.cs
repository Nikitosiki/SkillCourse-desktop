﻿using SkillCourse.DataBaseStructure.types;
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
    public class Certificate
    {
        private static int idCounter = 0;

        private int idCertificate;
        private string description;
        private DateTime presentationTime;

        private int idPresenterTeacher;
        private int idOwner;

        public Certificate(string description, DateTime presentationTime, int idPresenterTeacher, int idOwner)
        {
            IdCertificate = idCounter++;
            Description = description;
            PresentationTime = presentationTime;
            IdPresenterTeacher = idPresenterTeacher;
            IdOwner = idOwner;
        }

        [DisplayName("Id Certificate")]
        public int IdCertificate
        {
            get
            {
                return idCertificate;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idCertificate));
                idCertificate = value;
            }
        }

        [DisplayName("Description")]
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(description));
                description = value;
            }
        }

        [DisplayName("Presentation Time")]
        public DateTime PresentationTime
        {
            get
            {
                return presentationTime;
            }
            set
            {
                if ((value < new DateTime(2000, 01, 01)) || value > DateTime.Now.AddDays(1))
                    throw new ArgumentOutOfRangeException(nameof(presentationTime));
                presentationTime = value;
            }
        }

        [DisplayName("Id Presenter Teacher")]
        public int IdPresenterTeacher
        {
            get
            {
                return idPresenterTeacher;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idPresenterTeacher));
                idPresenterTeacher = value;
            }
        }

        [DisplayName("Id Owner")]
        public int IdOwner
        {
            get
            {
                return idOwner;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idOwner));
                idOwner = value;
            }
        }
    }
}