using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SkillCourse.DataBaseStructure.entities
{
    [Serializable]
    public class Student : User, ICloneable
    {
        protected Student(UserType userType, string firstName, string lastName, string email, string password, GenderType gender, DateTime lastLoginDate)
        {
            IdUser = idCounter;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            LastLoginDate = lastLoginDate;
        }

        private Student(int id, UserType userType, string firstName, string lastName, string email, string password, GenderType gender, DateTime lastLoginDate)
        {
            IdUser = idCounter;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            LastLoginDate = lastLoginDate;
        }


        public object Clone()
        {
            return new Student(IdUser, UserType, FirstName, LastName, Email, Password, Gender, LastLoginDate);
        }
    }
}
