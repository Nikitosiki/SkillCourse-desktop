using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents.AnswerTaskComponent
{
    public partial class Component_AssignmentScore : UserControl
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
            }
        }

        public Component_AssignmentScore()
        {
            InitializeComponent();
            ChangeColorGrade();
        }

        public Component_AssignmentScore(int grade) : this()
        {
            this.Grade = grade;
            ChangeColorGrade();
        }

        private void ChangeGrade(bool plus, int value)
        {
            int thisGrade = this.Grade;
            if (plus)
            {
                if (thisGrade + value > maxGrade)
                    thisGrade = maxGrade;
                else
                    thisGrade += value;
            }
            else
            {
                if (thisGrade - value < minGrade)
                    thisGrade = minGrade;
                else
                    thisGrade -= value;
            }
            this.Grade = thisGrade;
            ChangeColorGrade();
        }

        private void ChangeColorGrade()
        {
            int thisGrade = this.Grade;

            if (thisGrade == 0)
                labelGrade.ForeColor = Color.FromArgb(255, 120, 120);
            if (thisGrade == 1)
                labelGrade.ForeColor = Color.FromArgb(255, 145, 145);
            if (thisGrade == 2)
                labelGrade.ForeColor = Color.FromArgb(255, 206, 206);
            if (thisGrade >= 3)
                labelGrade.ForeColor = SystemColors.ControlLightLight;
        }

        private void buttonPlus2_Click(object sender, EventArgs e)
        {
            ChangeGrade(true, 2);
        }

        private void buttonPlus1_Click(object sender, EventArgs e)
        {
            ChangeGrade(true, 1);
        }

        private void buttonMinus1_Click(object sender, EventArgs e)
        {
            ChangeGrade(false, 1);
        }

        private void buttonMinus2_Click(object sender, EventArgs e)
        {
            ChangeGrade(false, 2);
        }
    }
}
