using SkillCourse.Panels.MainBlock.CertificatePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Certificates : UserControl
    {
        public PanelMainBlock_Certificates()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
            flowLayoutPanel1.Controls.Add(new Component_newCertificate());
        }
    }
}
