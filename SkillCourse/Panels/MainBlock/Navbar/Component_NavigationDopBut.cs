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
    public partial class Component_NavigationDopBut : UserControl
    {
        private Action clickOnThis;
        public string name;

        public Component_NavigationDopBut(string text, Action buttonThisObject)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            buttonThis.Text = text;
            name = text;
            clickOnThis = buttonThisObject;
        }

        public void ChangeDopButton(bool action)
        {
            if (action)
            {
                buttonThis.Font = new Font(buttonThis.Font, FontStyle.Bold);
            }
            else
            {
                buttonThis.Font = new Font(buttonThis.Font, FontStyle.Regular);
            }
        }

        private void buttonThis_Click(object sender, EventArgs e)
        {
            clickOnThis?.Invoke();
        }
    }
}
