using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure.entities
{
    [Serializable]
    public class Teather : User, ICloneable
    {
        protected Teather(UserType userType, string firstName, string lastName, string email, string password, GenderType gender, DateTime lastLoginDate)
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

        protected Teather(int id, UserType userType, string firstName, string lastName, string email, string password, GenderType gender, DateTime lastLoginDate)
        {
            IdUser = id;
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
            return new Teather(IdUser, UserType, FirstName, LastName, Email, Password, Gender, LastLoginDate);
        }
    }
}
