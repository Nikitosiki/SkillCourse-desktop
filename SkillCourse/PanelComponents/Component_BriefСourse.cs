using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents
{
    public partial class Component_BriefСourse : UserControl
    {
        private Action clickOnCourse;
        public Component_BriefСourse(string nameCourse, string descriptionCourse, Image imageCourse, Action buttonCoutse)
        {
            InitializeComponent();
            //this.Dock = DockStyle.Fill;

            label_NameCourse.Text = nameCourse;
            label_DescriptionCourse.Text = descriptionCourse;
            picture_imageCourse.Image = imageCourse;
            clickOnCourse = buttonCoutse;
        }

        private void button_ViewCourse_Click(object sender, EventArgs e)
        {
            clickOnCourse?.Invoke();
        }
    }
}
