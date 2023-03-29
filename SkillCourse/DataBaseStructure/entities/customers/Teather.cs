using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Teather : User, ICloneable
    {
        public Teather(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender)
        {
            IdUser = ++idCounter;
            UserType = UserType.Teacher;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            LastLoginDate = DateTime.Now;
        }

        [JsonConstructor]
        private Teather(int id, string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender, DateTime lastLoginDate)
        {
            IdUser = id;
            UserType = UserType.Teacher;
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
            return new Teather(IdUser, FirstName, LastName, Email, Password, DateOfBirth, Gender, LastLoginDate);
        }
    }
}
