using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillCourse.DataBaseStructure.types;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;
using Microsoft.VisualBasic.Logging;

namespace SkillCourse.DataBaseStructure
{
    [Serializable]
    public abstract class User
    {
        protected static int idCounter = 0;

        private int idUser;
        private UserType userType;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string? phoneNumber;
        private DateTime? dateOfBirth;
        private GenderType gender;
        private DateTime lastLoginDate;



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

        [DisplayName("phoneNumber")]
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

                if (!Regex.IsMatch(value, @"^\+\d{1,3}-\d{3}-\d{3}-\d{4}$"))
                    throw new FormatException($"Invalid format.\n{nameof(phoneNumber)}");
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
                if (value.Length < 8 || !Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
                    throw new FormatException($"Invalid format.\n{nameof(password)}");
                password = value;
            }
        }

        [DisplayName("Date Of Birth")]
        public DateTime? DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (value == null)
                {
                    dateOfBirth = null;
                    return;
                }

                if ((value < new DateTime(2000, 01, 01)) || value > DateTime.Now.AddDays(1))
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
