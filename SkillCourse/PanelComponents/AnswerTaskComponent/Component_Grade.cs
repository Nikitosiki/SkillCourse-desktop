using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents.AnswerTaskComponent
{
    public partial class Component_Grade : UserControl
    {
        public readonly int maxGrade = 5;
        public readonly int minGrade = 0;

        public int Grade
        {
            get
            {
                return Int32.Parse(labelGrade.Text);
            }
            set
            {
                if (value < minGrade || value > maxGrade)
                    throw new ArgumentOutOfRangeException("Incorrect value of Grade.");

                labelGrade.Text = value.ToString();
                ChangeColorGrade(value);
            }
        }

        public Component_Grade()
        {
            InitializeComponent();
            ChangeColorGrade(this.Grade);
        }

        public Component_Grade(int grade) : this()
        {
            this.Grade = grade;
            ChangeColorGrade(grade);
        }

        private void ChangeColorGrade(int thisGrade)
        {
            if (thisGrade == 0)
                labelGrade.ForeColor = Color.FromArgb(255, 120, 120);
            if (thisGrade == 1)
                labelGrade.ForeColor = Color.FromArgb(255, 145, 145);
            if (thisGrade == 2)
                labelGrade.ForeColor = Color.FromArgb(255, 206, 206);
            if (thisGrade >= 3)
                labelGrade.ForeColor = SystemColors.ControlLightLight;
        }
    }
}
