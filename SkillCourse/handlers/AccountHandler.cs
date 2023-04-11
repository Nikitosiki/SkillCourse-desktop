using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SkillCourse
{
    public class AccountHandler
    {
        private event Action<User?> OnChangeUser;
        public void subscribeOnChange(Action<User> subscribeEvent)
        {
            OnChangeUser += subscribeEvent;
        }


        private static AccountHandler? instance;
        public static AccountHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountHandler();
                }
                return instance;
            }
        }

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


        private User? userLog;

        [DisplayName("User Log")]
        public User? UserLog
        {
            get
            {
                return userLog;
            }
            private set
            {
                if (value?.IdUser < 0 || DataBase.Users.Find(user => user.IdUser == value?.IdUser) != null)
                    throw new ArgumentOutOfRangeException(nameof(userLog));
                userLog = value;
            }
        }

        private AccountHandler() { }

        public bool LogIn(string email, string password)
        {
            User? thisUser = null;
            if (!FindUser(ref thisUser, email))
                throw new ArgumentException("User not found.");

            if (!PasswordEncryptor.CheckPassword(password, thisUser.Password))
                throw new ArgumentException("Incorrect password.");

            userLog = thisUser;
            OnChangeUser(thisUser);

            return true;
        }

        public bool RegIn(string firstName, string lastName, string email, DateTime dateOfBirth, UserType type, string password)
        {
            if (password.Length < 8 || !Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
                throw new FormatException($"Invalid format.\n{nameof(password)}");

            string hashPass = PasswordEncryptor.Encrypt(password);

            User newUser;
            switch (type)
            {
                case UserType.Teacher:
                    newUser = new Teather(firstName, lastName, email, hashPass, dateOfBirth, GenderType.None);
                    break;

                case UserType.Student:
                    newUser = new Student(firstName, lastName, email, hashPass, dateOfBirth, GenderType.None);
                    break;

                default:
                    throw new FormatException($"Uncorrect user format, {type}.");
            }


            //DataBase.Users.Add(newUser);
            return true;
        }

        public bool LogOut()
        {
            UserLog = null;
            OnChangeUser(null);
            return true;
        }

        public bool FindUser(ref User ?AuthorizationUser, string email)
        {
            AuthorizationUser = DataBase.Users.Find(user => user.Email == email);
            if (AuthorizationUser == null)
                return false;
            return true;
        }
    }
}
