using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SkillCourse.Panels
{
    public partial class PanelAutorization_SingUp : UserControl
    {
        private Form parentForm;

        public PanelAutorization_SingUp(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            //MainForm LoadForm = new MainForm();
            //LoadForm.ShowDialog();

            parentForm.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to register as a teacher?", "notice", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
    }
}