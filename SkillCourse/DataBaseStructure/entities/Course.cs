﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Course : ICloneable
    {
        private static int idCounter = 0;

        private int idCourse;
        private string name;
        private string description;
        private string imagePath;

        private int idTeacher;


        public Course(string name, string description, string imagePath, int idTeacher)
        {
            IdCourse = ++idCounter;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            IdTeacher = idTeacher;
        }

        private Course(int id, string name, string description, string imagePath, int idTeacher)
        {
            IdCourse = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
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
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(imagePath));
                imagePath = value;
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


        public object Clone()
        {
            return new Course(IdCourse, Name, Description, ImagePath, IdTeacher);
        }
    }
}
