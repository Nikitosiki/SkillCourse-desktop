using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Student : User, ICloneable
    {
        [JsonConstructor]
        public Student(int idUser, string firstName, string lastName, string email, string? phoneNumber, string password, string? imagePath, DateTime dateOfBirth, GenderType gender, DateTime lastLoginDate) : base (UserType.Student, firstName, lastName, email, password)
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

        public Student(string firstName, string lastName, string email, string password, DateTime dateOfBirth, GenderType gender) : base(UserType.Student, firstName, lastName, email, password)
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

        public object Clone()
        {
            return new Student(IdUser, FirstName, LastName, Email, PhoneNumber, Password, ImagePath, DateOfBirth, Gender, LastLoginDate);
        }
    }
}
