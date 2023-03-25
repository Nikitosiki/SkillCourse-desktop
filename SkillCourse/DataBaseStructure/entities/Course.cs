﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Course
    {
        private static int idCounter = 0;

        private int idCourse;
        private string name;
        private string description;
        private Image image;

        private int idTeacher;


        public Course(string name, string description, Image image, int idTeacher)
        {
            IdCourse = idCounter++;
            Name = name;
            Description = description;
            Image = image;
            IdTeacher = idTeacher;
        }

        [DisplayName("Id Course")]
        public int IdCourse
        {
            get
            {
                return idCourse;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idCourse));
                idCourse = value;
            }
        }

        [DisplayName("Name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(name));
                name = value;
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

        [DisplayName("Image")]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(image));
                image = value;
            }
        }

        [DisplayName("Id Teacher")]
        public int IdTeacher
        {
            get
            {
                return idTeacher;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idTeacher));
                idTeacher = value;
            }
        }
    }
}
