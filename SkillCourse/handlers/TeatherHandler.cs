﻿using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCourse
{
    public class TeatherHandler : Teather
    {
        private static SkillCourseDB? instanceDB = null;
        private static SkillCourseDB DataBase
        {
            get
            {
                if (instanceDB == null)
                {
                    instanceDB = SkillCourseDB.Instance;
                }
                return instanceDB;
            }
        }


        public TeatherHandler(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender) :
            base(firstName, lastName, email, password, dateOfBirth, gender) { }



        public List<Course> Courses
        {
            get
            {
                return DataBase.Courses.FindAll(course => course.IdTeacher == this.IdUser);
            }
        }

        public List<Course> FindAllCourses(string search)
        {
            string[] searchWords = search.Split(' '); // разбиваем на отдельные слова
            return DataBase.Courses
                .Where(course => searchWords.Any(word =>
                    course.Name.Contains(word) || course.Description.Contains(word)))
                .ToList();
        }

        public bool CreateCourse(string name, string description)
        {
            try
            {
                DataBase.Courses.Add(new Course(name, description, "imageDefaultCourse", this.IdUser));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangeImageToCourse(Course course)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath + "\\Resources";
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    course.ImagePath = openFileDialog.SafeFileName;
                    DataBase.Courses.Update(course);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
