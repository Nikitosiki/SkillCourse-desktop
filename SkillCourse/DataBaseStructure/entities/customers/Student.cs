using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Student : User, ICloneable
    {
        public Student(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender)
        {
            IdUser = ++idCounter;
            UserType = UserType.Student;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            LastLoginDate = DateTime.Now;
        }

        [JsonConstructor]
        private Student(int id, string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender, DateTime lastLoginDate)
        {
            IdUser = id;
            UserType = UserType.Student;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            LastLoginDate = lastLoginDate;
        }


        public object Clone()
        {
            return new Student(IdUser, FirstName, LastName, Email, Password, DateOfBirth, Gender, LastLoginDate);
        }
    }
}
