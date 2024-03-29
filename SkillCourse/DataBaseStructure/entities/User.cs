﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillCourse.DataBaseStructure.types;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;
using Microsoft.VisualBasic.Logging;
using System.Text.Json.Serialization;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public abstract class User
    {
        protected static int idCounter = SkillCourseDB.Instance.Users.Any() ? SkillCourseDB.Instance.Users.Max(u => u.idUser) : 0;

        private int idUser;
        private UserType userType;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string? phoneNumber;
        private string? imagePath;
        private DateTime dateOfBirth;
        private GenderType gender;
        private DateTime lastLoginDate;

        protected User(UserType userType, string firstName, string lastName, string email, string password)
        {
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        [DisplayName("Id User")]
        public int IdUser
        {
            get
            {
                return idUser;
            }
            protected set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(idUser));
                idUser = value;
            }
        }

        [DisplayName("User Type")]
        public UserType UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }

        [DisplayName("First Name")]
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(firstName));
                firstName = value;
            }
        }

        [DisplayName("Last Name")]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(lastName));
                lastName = value;
            }
        }

        [DisplayName("Email")]
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new FormatException($"Invalid format.\n{nameof(email)}");
                email = value;
            }
        }

        [DisplayName("Phone Number")]
        public string? PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value == null)
                {
                    phoneNumber = null;
                    return;
                }

                phoneNumber = value;
            }
        }

        [DisplayName("Password")]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value == null)
                    throw new FormatException($"Incorrect value.");
                password = value;
            }
        }

        [DisplayName("Image Path")]
        public string? ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
            }
        }

        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if ((value < new DateTime(1900, 01, 01)) || value > DateTime.Now.AddDays(1))
                    throw new ArgumentOutOfRangeException(nameof(dateOfBirth));
                dateOfBirth = value;
            }
        }

        [DisplayName("Gender")]
        public GenderType Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        [DisplayName("Last Login Date")]
        public DateTime LastLoginDate
        {
            get
            {
                return lastLoginDate;
            }
            set
            {
                if ((value < new DateTime(2000, 01, 01)) || value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(lastLoginDate));
                lastLoginDate = value;
            }
        }
    }
}
