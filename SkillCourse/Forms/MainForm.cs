using SkillCourse.Panels;
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

namespace SkillCourse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Random();
            panel2.Controls.Add(new PanelMainBlock_Courses());
            AddButtonToNavbar();

            AccountHandler.Instance.subscribeOnChange(updateUser);
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            Authorization LoadForm = new Authorization();
            //this.Hide();
            LoadForm.ShowDialog();
        }

        public void updateUser(DataBaseStructure.User? user)
        {
            if (user == null)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 25);
                label1.Font = new Font(label1.Font.FontFamily, 14);
                label1.Text = "not authorized";
            }
            else
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 25);
                label1.Font = new Font(label1.Font.FontFamily, 12);
                label1.Text = user.FirstName + "\n" + user.LastName;
            }
        }


        public void ChangeActiveButton(Button button)
        {

        }

        private void AddButtonToNavbar()
        {
            panelNavbarBut.Controls.Add(new Component_NavigationBut("Edit profile", false));
            panelNavbarBut.Controls.Add(new Component_NavigationBut("Certificates", false));
            panelNavbarBut.Controls.Add(new Component_NavigationBut("Add Courses", false));
            panelNavbarBut.Controls.Add(new Component_NavigationBut("Teachers", false));
            panelNavbarBut.Controls.Add(new Component_NavigationBut("Courses", true));
        }


        #region clickHandler_navbar
        private void newButton_Courses_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            //EditControlWithLoad(panel2, new PanelMainBlock_Courses(), new Component_Loading());

            EditControl(panel2, new PanelMainBlock_Courses());

            //EditControl(panel2, new PanelMainBlock_EditProfile());

            //// Асинхронно загружаем пользовательский элемент в фоновом потоке
            //object panel = await System.Threading.Tasks.Task.Run(() =>
            //{
            //    object control = new PanelMainBlock_Courses();
            //    // Выполняем здесь необходимые операции загрузки
            //    // ...
            //    return control;
            //});

            //EditControl(panel2, panel);


            //Control control = await System.Threading.Tasks.Task.Run(() =>
            //{
            //    Control cont = new Control();
            //    cont = new PanelMainBlock_Courses();

            //    return cont;
            //});

            //Panel panelEdit = (Panel)panel2;
            //panelEdit.Controls.Clear();
            //panelEdit.Controls.Add(control);
        }

        private void newButton_Teacher_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            EditControl(panel2, new PanelMainBlock_Teachers());
        }

        private void newButton_EditProfile_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            EditControl(panel2, new PanelMainBlock_EditProfile());
        }

        private void newButton_AddCourses_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            EditControl(panel2, new PanelMainBlock_AddCourses());
        }

        private void newButton_Certificate_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            EditControl(panel2, new PanelMainBlock_AddCourses());
        }

        private void ChangeColorButton(object senderButtonSelected)
        {
            // Сброс всех кнопок на дефолт
            foreach (Control control in groupBox2.Controls)
            {
                control.ForeColor = FlatColors.ProjectBlueGreyButton;
            }

            // ----
            ((Label)senderButtonSelected).ForeColor = SystemColors.ControlLight;

        }

        public void EditControl(object panel, object content)
        {
            Panel panelEdit = (Panel)panel;
            UserControl Content = (UserControl)content;

            if (panelEdit.Controls.Count < 1 || panelEdit.Controls[0] != Content)
            {
                panelEdit.Controls.Clear();
                //panelEdit.Visible = false;
                panelEdit.Controls.Add(Content);

            }
        }

        public void EditControlWithLoad(object panel, object content, object loader)
        {
            Panel panelEdit = (Panel)panel;
            UserControl Content = (UserControl)content;
            UserControl Loader = (UserControl)loader;

            if (panelEdit.Controls.Count < 1 || panelEdit.Controls[0] != Content)
            {
                panelEdit.Controls.Clear();
                panelEdit.Controls.Add(Loader);
                //panelEdit.Controls.Add(Content);
                //panelEdit.Controls.Remove(Loader);
            }
        }

        public void EditControlMainPage(object content)
        {
            EditControl(panel2, content);
        }

        #endregion


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
