using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public class Teather : User, ICloneable
    {
        [JsonConstructor]
        public Teather(int idUser, string firstName, string lastName, string email, string? phoneNumber, string password, string? imagePath, DateTime dateOfBirth, GenderType gender, DateTime lastLoginDate)
        {
            idCounter++;
            IdUser = idUser;
            UserType = UserType.Student;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            ImagePath = imagePath;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            LastLoginDate = lastLoginDate;
        }

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


        public object Clone()
        {
            return new Student(IdUser, FirstName, LastName, Email, PhoneNumber, Password, ImagePath, DateOfBirth, Gender, LastLoginDate);
        }
    }
}
