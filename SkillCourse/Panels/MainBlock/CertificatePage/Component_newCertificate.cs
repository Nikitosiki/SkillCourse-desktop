using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.CertificatePage
{
    public partial class Component_newCertificate : UserControl
    {
        public Component_newCertificate()
        {
            InitializeComponent();
        }

        public Component_newCertificate(string nameCourse, string owner, string teacher, string number)
        {
            InitializeComponent();

            labelText.Text = $"\"{nameCourse}\"";
            labelOwner.Text = owner;
            labelTeacher.Text = teacher;
            labelNumber.Text = "№ " + number.ToUpper();
        }
    }
}
