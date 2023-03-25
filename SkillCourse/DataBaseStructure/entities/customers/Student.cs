using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure.entities
{
    [Serializable]
    public class Student : User
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
    }
}
