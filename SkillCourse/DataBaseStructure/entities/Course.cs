using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
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
                return IdCourse;
            }
            set
            {
                if (value >= 0)
                    idCourse = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(IdCourse));
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
                if (value != null)
                    name = value;
                else
                    throw new ArgumentNullException(nameof(name));
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
                if (value != null)
                    description = value;
                else
                    throw new ArgumentNullException(nameof(description));
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
                if (value != null)
                    image = value;
                else
                    throw new ArgumentNullException(nameof(image));
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
                if (value >= 0)
                    idTeacher = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(idTeacher));
            }
        }
    }
}
