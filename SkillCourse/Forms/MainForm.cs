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
using SkillCourse.DataBaseStructure.entities;
using SkillCourse.DataBaseStructure.types;
using System.IO;


namespace SkillCourse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Random();
            panel2.Controls.Add(new PanelMainBlock_Courses());

        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            Authorization LoadForm = new Authorization();
            //this.Hide();
            LoadForm.ShowDialog();
        }


        #region clickHandler_navbar
        private void newButton_Courses_Click(object sender, EventArgs e)
        {
            ChangeColorButton(sender);
            EditControl(panel2, new PanelMainBlock_Courses());
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
                panelEdit.Controls.Add(Content);
            }
        }

        public void EditControlMainPage(object content)
        {
            EditControl(panel2, content);
        }

        #endregion


        #region randomFilling

        public void Random()
        {
            RandomAddUserToUserCollection();
            RandomAddCourseToCourseCollection();
        }

        public void RandomAddUserToUserCollection()
        {
            SkillCourseDB DataBase = SkillCourseDB.Instance;

            DataBase.Users.Add(new Teather(UserType.Teacher, "Kir", "Leir", "leir.k@gmail.com", "123456789", GenderType.Male));
        }

        public void RandomAddCourseToCourseCollection()
        {
            SkillCourseDB DataBase = SkillCourseDB.Instance;
            Image image = Properties.Resources.image008;

            for (int i = 0; i < 100; i++)
            {
                string nameCourse = $"{i} - ый курс, по программированию!";
                string descriptionCourse = "Description: Это...";

                int idTeather = DataBase.Users.Teathers()[0].IdUser;
                Course course = new Course(nameCourse, descriptionCourse, image, idTeather);
                DataBase.Courses.Add(course);
            }
        }

        #endregion
    }
}
