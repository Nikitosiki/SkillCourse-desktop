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

namespace SkillCourse.PanelComponents
{
    public partial class Component_BriefСourse_Subscription : UserControl
    {
        private Action? clickOnUnsubscribe;
        private Action? clickOnSubscribe;

        private bool autoUpdate;
        private Course thisCourse;
        private Student handler = (Student)AccountHandler.Instance.UserLog;

        public Component_BriefСourse_Subscription(Course course, bool AutoUpdate, Action? clickOnUnsubscribe, Action? clickOnSubscribe)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            Name = course.Name + " " + course.Description;
            this.autoUpdate = AutoUpdate;
            this.thisCourse = course;

            label_NameCourse.Text = course.Name;
            label_DescriptionCourse.Text = course.Description;
            picture_imageCourse.Image = Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image;
            defoultStateSubButton(true);

            this.clickOnUnsubscribe = clickOnUnsubscribe;
            this.clickOnSubscribe = clickOnSubscribe;
        }

        private void defoultStateSubButton(bool autoRefresh)
        {
            if (handler.CheckSubscrib(thisCourse))
            {
                button_SubCourse.Text = "Unsubscribe";
                button_SubCourse.BackColor = Color.Gray;
            }
            else
            {
                button_SubCourse.Text = "Subscribe";
                button_SubCourse.BackColor = Color.FromArgb(220, 50, 80);       //80, 175, 138
            }
            if (autoRefresh)
                this.Refresh();
        }

        private void button_SubCourse_Click(object sender, EventArgs e)
        {
            if (button_SubCourse.Text == "Subscribe")
            {
                //Добавить проверку на созданном модальном окне: "Все ваши записи будут удалены, Вы уверены что хотите отпсаться? 🤨"
                if (true)
                {
                    clickOnUnsubscribe?.Invoke();
                    defoultStateSubButton(autoUpdate);
                }
            }
            else
            {
                clickOnSubscribe?.Invoke();
                defoultStateSubButton(autoUpdate);
            }
        }
    }
}
