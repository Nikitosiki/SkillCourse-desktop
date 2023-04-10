using SkillCourse.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NikitosikSUI;

namespace SkillCourse
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            panel_Main.Controls.Add(new PanelAutorization_LogIn(this));
        }

        private void newButton_SingUp_Click(object sender, EventArgs e)
        {
            SelectSingUp();
        }

        private void newButton_LogIn_Click(object sender, EventArgs e)
        {
            SelectLogIn();
        }

        private void SelectLogIn()
        {
            if (!(panel_Main.Controls.Count > 0 && panel_Main.Controls[0] is PanelAutorization_LogIn))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(new PanelAutorization_LogIn(this));
                PaintButton("newButton_LogIn");
            }
        }

        public void SelectLogInWithRegistred(string userName)
        {
            if (!(panel_Main.Controls.Count > 0 && panel_Main.Controls[0] is PanelAutorization_LogIn))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(new PanelAutorization_LogIn(this, userName));
                PaintButton("newButton_LogIn");
            }
        }

        private void SelectSingUp()
        {
            if (!(panel_Main.Controls.Count > 0 && panel_Main.Controls[0] is PanelAutorization_SingUp))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(new PanelAutorization_SingUp(this));
                PaintButton("newButton_SingUp");
            }
        }

        private void PaintButton(string buttonName)
        {
            switch (buttonName)
            {
                case "newButton_LogIn":
                    newButton_LogIn.BorderColor = FlatColors.ProjectMintGreen;
                    newButton_LogIn.BorderColorOnHover = FlatColors.ProjectMintGreen;
                    newButton_LogIn.BackColor = FlatColors.ProjectMintGreen;

                    newButton_SingUp.BorderColor = FlatColors.ProjectGrey;
                    newButton_SingUp.BorderColorOnHover = FlatColors.ProjectGrey;
                    newButton_SingUp.BackColor = FlatColors.ProjectGrey;
                    break;
                case "newButton_SingUp":
                    newButton_SingUp.BorderColor = FlatColors.ProjectMintGreen;
                    newButton_SingUp.BorderColorOnHover = FlatColors.ProjectMintGreen;
                    newButton_SingUp.BackColor = FlatColors.ProjectMintGreen;

                    newButton_LogIn.BorderColor = FlatColors.ProjectGrey;
                    newButton_LogIn.BorderColorOnHover = FlatColors.ProjectGrey;
                    newButton_LogIn.BackColor = FlatColors.ProjectGrey;
                    break;
                default:
                    break;
            }
        }
    }
}
