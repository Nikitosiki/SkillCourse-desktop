using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_FindCertificate : UserControl
    {
        public PanelMainBlock_FindCertificate()
        {
            InitializeComponent();
        }

        private void maskedTextBoxInputKey_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxInputKey.ForeColor == Color.Brown)
                maskedTextBoxInputKey.ForeColor = SystemColors.ControlDark;
        }

        private void newButtonApply_Click(object sender, EventArgs e)
        {
            string keyCertificate = maskedTextBoxInputKey.Text.Replace("-", "").ToLower();
            Certificate? certificate = SkillCourseDB.Instance.Certificates.FindLast(cert => cert.IdCertificate == keyCertificate);

            if (certificate == null)
            {
                maskedTextBoxInputKey.ForeColor = Color.Brown;
                return;
            }

            NavigatePages.OpenNewPage(new PanelMainBlock_Certificates(certificate), (Panel)this.Parent);
        }
    }
}
