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

        public Component_NavigationBut(string text, Image? image, bool action, Action buttonThisObject, List<Component_NavigationDopBut> controlsAddBut)
        {
            InitializeComponent();
            clickOnThis = buttonThisObject;
            Dock = DockStyle.Top;
            button1.Text = text;
            name = text;
            if (image != null)
                button1.Image = image;

            ChangeStateButton(action);

            if (controlsAddBut != null)
                foreach (Component_NavigationDopBut item in controlsAddBut)
                {
                    panelDopButton.Controls.Add(item);
                }
        }

        public void ChangeStateButton(bool action)
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

        public void UpdateStateDopButton(string nameDopButtop)
        {
            foreach (Control item in panelDopButton.Controls)
            {
                Component_NavigationDopBut objectPan = (Component_NavigationDopBut)item;
                if (objectPan.name == nameDopButtop)
                    objectPan.ChangeDopButton(true);
                else
                    objectPan.ChangeDopButton(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка, не пытаемся ли мы нажать на уже выбранную кнопку
            //if (button1.ForeColor != SystemColors.ControlLight)
            clickOnThis?.Invoke();
        }
    }
}
