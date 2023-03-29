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
    public partial class PanelAutorization_LogIn : UserControl
    {
        private Form parentForm;

        public PanelAutorization_LogIn(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            AccountHandler.Instance.LogIn(newGoogleTextBox3.Text, newGoogleTextBox4.Text);
            parentForm.Hide();
        }
    }
}
