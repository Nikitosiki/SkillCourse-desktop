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
            InitializeTimer();
        }

        public Component_newCertificate(string nameCourse, string? description, string owner, string teacher, string number, DateTime presentationDate)
        {
            InitializeComponent();
            InitializeTimer();

            labelText.Text = $"\"{nameCourse}\"\n{description}";
            labelOwner.Text = owner;
            labelTeacher.Text = teacher;
            labelNumber.Text = "№ " + InsertDashEvery4thChar(number.ToUpper()) + " / " + presentationDate.ToString("d");
        }

        string InsertDashEvery4thChar(string input)
        {
            return string.Concat(input.Select((c, i) => i > 0 && i % 4 == 0 ? $"-{c}" : c.ToString()));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            roundButtonPrint.Visible = false;
            handlers.PrintHandler.ShowPrintPreview(this);
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1500;
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();
        }

        private int oldCursorPositionX = Cursor.Position.X;
        private int oldCursorPositionY = Cursor.Position.Y;
        private void Component_newCertificate_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position.X != oldCursorPositionX || Cursor.Position.Y != oldCursorPositionY)
            {
                oldCursorPositionX = Cursor.Position.X;
                oldCursorPositionY = Cursor.Position.Y;

                roundButtonPrint.Visible = true;
                timer1.Stop();
                timer1.Start();
                timer1.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            roundButtonPrint.Visible = false;
            timer1.Enabled = false;
        }
    }
}
