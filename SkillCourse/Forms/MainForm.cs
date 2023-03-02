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

namespace SkillCourse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

    }
}
