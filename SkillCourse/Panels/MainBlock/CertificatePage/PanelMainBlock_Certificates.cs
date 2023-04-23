using SkillCourse.DataBaseStructure;
using SkillCourse.Panels.MainBlock.CertificatePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Certificates : UserControl
    {
        private int countControls = 0;
        private int selectIndexControl = 0;

        public PanelMainBlock_Certificates()
        {
            InitializeComponent();

            panelThisCertificates.Controls.Add(new Component_newCertificate());
            panelThisCertificates.Controls.Add(new Component_newCertificate());
            panelThisCertificates.Controls.Add(new Component_newCertificate());

            countControls = panelThisCertificates.Controls.Count;
        }

        public PanelMainBlock_Certificates(Certificate certificate)
        {
            InitializeComponent();

            string nameCourse = SkillCourseDB.Instance.Courses.FindLast(cour => cour.IdCourse == certificate.IdCourse).Name;
            User owner = SkillCourseDB.Instance.Users.FindLast(user => user.IdUser == certificate.IdOwner);
            string nameOwner = owner.LastName + " " + owner.FirstName;
            User teacher = SkillCourseDB.Instance.Users.FindLast(user => user.IdUser == certificate.IdPresenterTeacher);
            string nameTeacher = teacher.LastName + " " + teacher.FirstName;

            panelThisCertificates.Controls.Add(new Component_newCertificate(nameCourse, certificate.Description,
                nameOwner, nameTeacher, certificate.IdCertificate, certificate.PresentationTime));

            buttonScrollLeft.Visible = false;
            buttonScrollRight.Visible = false;
        }


        private void buttonScrollRight_Click(object sender, EventArgs e)
        {
            ScrollMove(true);
        }

        private void buttonScrollLeft_Click(object sender, EventArgs e)
        {
            ScrollMove(false);
        }

        private void ScrollMove(bool right)
        {
            int stepSize = 40;
            int sizeControl = 866;
            int countControl = panelThisCertificates.Controls.Count;
            int currentScrollPosition = panelThisCertificates.HorizontalScroll.Value;
            float selectControl = (float)currentScrollPosition / (float)sizeControl;      //тот на котором мы сейчас находимся

            if (right)
            {
                // от 0 .. 2 - selectControl
                // от 1 .. 3 - countControl
                if (selectControl + 1 < countControl)
                {
                    int sumSizeControl = (((int)selectControl + 1) * sizeControl);   // + 3
                    ScrollPanelAnimation(sumSizeControl, stepSize);
                }
            }
            else
            {
                if (selectControl > 0)
                {
                    int sumSizeControl = (((int)(selectControl - 0.000001)) * sizeControl);   // + 3
                    ScrollPanelAnimation(sumSizeControl, stepSize);
                }
            }

        }

        private void ScrollPanelAnimation(int targetScrollPosition, int stepSize)
        {
            // Анимация прокрутки
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // Интервал обновления анимации (в миллисекундах)
            timer.Tick += (s, args) =>
            {
                if (panelThisCertificates.HorizontalScroll.Value < targetScrollPosition)
                {
                    if (panelThisCertificates.HorizontalScroll.Value <= targetScrollPosition - stepSize)
                        panelThisCertificates.HorizontalScroll.Value += stepSize; // Шаг анимации
                    else
                    {
                        panelThisCertificates.AutoScrollPosition = new Point(targetScrollPosition, 0);
                    }
                }
                else if (panelThisCertificates.HorizontalScroll.Value > targetScrollPosition)
                {
                    if (panelThisCertificates.HorizontalScroll.Value >= targetScrollPosition + stepSize)
                        panelThisCertificates.HorizontalScroll.Value -= stepSize; // Шаг анимации
                    else
                    {
                        panelThisCertificates.AutoScrollPosition = new Point(targetScrollPosition, 0);
                    }
                }
                else
                {
                    timer.Stop(); // Останавливаем таймер после завершения анимации
                }
            };
            timer.Start(); // Запускаем таймер для анимации
        }
    }
}
