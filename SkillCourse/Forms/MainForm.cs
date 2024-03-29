﻿using SkillCourse.Panels;
using SkillCourse.Panels.MainBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NikitosikSUI;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.types;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using SkillCourse.PanelComponents;
using Microsoft.VisualBasic.Devices;
using SkillCourse.Panels.MainBlock.Navbar;
using System.Diagnostics;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.helpers;

namespace SkillCourse
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer TUpdateTimeLastVisit = new System.Windows.Forms.Timer();
        public DataBaseStructure.User? User { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            LoadLabelVersions();
            TUpdateTimeLastVisit.Interval = 60000;
            TUpdateTimeLastVisit.Tick += TUpdateTimeLastVisit_Tick;
            AccountHandler.Instance.subscribeOnChange(updateUser);

            //--- NavigateBar

            //panelMain.Controls.Add(new PanelMainBlock_Courses());
            panelNavbarBut.Controls.Add(PanelMainBlock_Navbar.NewInstance((User != null ? User.UserType : null), panelMain));
            NavigatePages.setMainPanel(panelMain);
            //AddButtonToNavbar();

            //--- endNavigateBar


            //Random();
            //Certificate certificate = new Certificate("По завершению долгожданного...", DateTime.Now, 3, 1, 1);
            //SkillCourseDB.Instance.Certificates.Add(certificate);
            //Certificate certificate1 = new Certificate("Ты снова пришёл сюда?", DateTime.Now, 3, 1, 2);
            //SkillCourseDB.Instance.Certificates.Add(certificate1);
            //Certificate certificate2 = new Certificate("Я думал, мы это уже обговорили, проваливай", DateTime.Now, 8, 1, 4);
            //SkillCourseDB.Instance.Certificates.Add(certificate2);
            //SubscriptionCourse sub = new SubscriptionCourse(4, 101);
            //SkillCourseDB.Instance.Subscriptions.Add(sub);
            //DataBaseStructure.Task task = new DataBaseStructure.Task("Вы маєте це зробити, скільки буде:\n8 + 4 = ?\nЯкий мій улюблений фільм?\nТи хто такий?}", 18, false);
            //SkillCourseDB.Instance.Tasks.Add(task);
            //Debug.WriteLine(PasswordEncryptor.Encrypt("12345678d"));
            //DataBaseStructure.User User1 = new DataBaseStructure.Student("Nikita", "Savenko", "nikita@dot.net", "12369nik", new DateTime(2003, 5, 17), GenderType.Male);
            //SkillCourseDB.Instance.Users.Add(User1);
            //DataBaseStructure.User User2 = new DataBaseStructure.Student("Efim", "Efimovich", "efim@dot.net", "1234567q", new DateTime(2002, 9, 27), GenderType.Male);
            //SkillCourseDB.Instance.Users.Add(User2);

            //DataBaseStructure.User User3 = new DataBaseStructure.Teather("Raf", "Vlad", "v_-369Nmd@gmail.com", "12345678d", new DateTime(2005, 4, 10), GenderType.None);
            //SkillCourseDB.Instance.Users.Add(User3);

            //Course course = new Course("1. Об'єктно-орієнтоване програмування (КР)", "Мета вивчення: надати студентам можливості щодо самостійного розроблення програмного забезпечення для заданої предметної області за допомогою об’єктно-орієнтованої парадигми програмування, а також розвиток у студента soft-skills:\r\n - креативність та гнучкість мислення, \r\n - прийняття рішень, \r\n - пошук відкритої інформації, \r\n - аналіз і винесення суджень.\r\n\r\n\r\n", "imageDefaultCourse", User3.IdUser);
            //SkillCourseDB.Instance.Courses.Add(course);
            //DataBaseStructure.Task task = new DataBaseStructure.Task("Это наше первое занятие.", course.IdCourse);
            //SkillCourseDB.Instance.Tasks.Add(task);
            //DataBaseStructure.Task task1 = new DataBaseStructure.Task("Пояснювальна записка до курсової роботи.", course.IdCourse);
            //SkillCourseDB.Instance.Tasks.Add(task1);
        }

        private void LoadLabelVersions()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            DateTime creationTime = System.IO.File.GetLastWriteTime(assemblyPath);

            labelVersions.Text = $"SkillCourse  {creationTime.ToString("MMM dd")} Version";
        }

        private void TUpdateTimeLastVisit_Tick(object? sender, EventArgs e)
        {
            if (User != null)
                AccountHandler.Instance.UpdateLastVisitUser(User);
        }

        private void newButtonAuthorization_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "LogIn / RegIn")
            {
                Authorization LoadForm = new Authorization();
                LoadForm.ShowDialog();
            }
            else
            {
                AccountHandler.Instance.LogOut();
            }

        }

        public void updateUser(DataBaseStructure.User? user)
        {
            NavigatePages.clearPanel();
            if (user == null)
            {
                //Все настройки для Не авторизированного пользователя
                TUpdateTimeLastVisit.Stop();

                User = null;

                backRoundPanel1.Hide();
                tableLayoutPanelNaming.Hide();
                labelAuthorization.Show();

                newButtonAuthorization.Text = "LogIn / RegIn";

                ((PanelMainBlock_Navbar)panelNavbarBut.Controls[0]).Redraw(null);
            }
            else
            {
                TUpdateTimeLastVisit.Start();

                User = user;

                backRoundPanel1.Show();
                tableLayoutPanelNaming.Show();
                labelAuthorization.Hide();

                labelFirstN.Text = user.FirstName;
                labelLastN.Text = user.LastName;
                string path = SerializeSetting.Default.UserImages + user.ImagePath;
                pictureBoxIconUser.Image = ImageSaveHelper.ResizeImageWithCrop(ImageSaveHelper.LoadUserImageFromFile(path), pictureBoxIconUser.Width, pictureBoxIconUser.Height);

                newButtonAuthorization.Text = "Go Out";

                ((PanelMainBlock_Navbar)panelNavbarBut.Controls[0]).Redraw(user.UserType);
            }
        }

        #region randomFilling

        //public void Random()
        //{
        //    RandomAddUserToUserCollection();
        //    RandomAddCourseToCourseCollection();

        //    SkillCourseDB DataBase = SkillCourseDB.Instance;
        //    DataBase.Users.Add(new Student("Nik", "Tas", "tas.nk@gmail.com", PasswordEncryptor.Encrypt("000000001"), DateTime.Now.AddDays(-8000), GenderType.Female));
        //    DataBase.Subscriptions.Add(new SubscriptionCourse(2, 5));
        //    DataBase.Tasks.Add(new DataBaseStructure.Task("bla-bla-blabalalala", 5));
        //    DataBase.AnswerTasks.Add(new AnswerTask(StateTask.Done, 2, 1, 2));
        //    DataBase.Certificates.Add(new Certificate("You>!", DateTime.Now, 1, 2, 3));
        //}

        //public void RandomAddUserToUserCollection()
        //{
        //    SkillCourseDB DataBase = SkillCourseDB.Instance;

        //    DataBase.Users.Add(new Teather("Kir", "Leir", "leir.k@gmail.com", PasswordEncryptor.Encrypt("123456789"), DateTime.Now.AddDays(-8000), GenderType.Male));
        //}

        //public void RandomAddCourseToCourseCollection()
        //{
        //    SkillCourseDB DataBase = SkillCourseDB.Instance;
        //    string image = "image008";

        //    for (int i = 0; i < 100; i++)
        //    {
        //        string nameCourse = $"{i} - ый курс, по программированию!";
        //        string descriptionCourse = "Description: Это...";

        //        int idTeather = DataBase.Users.Teathers()[0].IdUser;
        //        Course course = new Course(nameCourse, descriptionCourse, image, idTeather);
        //        DataBase.Courses.Add(course);
        //    }
        //}

        #endregion
    }
}
