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
    public partial class Component_NavigationBut : UserControl
    {
        private Action clickOnThis;
        public string name;

        public Component_NavigationBut(string text, Image? image, bool action, Action buttonThisObject, ControlCollection? controlsAddBut)
        {
            InitializeComponent();
            clickOnThis = buttonThisObject;
            Dock = DockStyle.Top;
            button1.Text = text;
            name = text;
            if (image != null)
                button1.Image = image;

            ChangeStateDopButton(action);

            if (controlsAddBut != null)
                foreach (Control item in controlsAddBut)
                {
                    panelDopButton.Controls.Add(item);
                }
        }

        public void ChangeStateDopButton(bool action)
        {
            if (action)
            {
                button1.ForeColor = SystemColors.ControlLight;
                panelDopButton.Visible = true;
            }
            else
            {
                button1.ForeColor = Color.FromArgb(142, 173, 212);
                panelDopButton.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickOnThis?.Invoke();
        }
    }
}
