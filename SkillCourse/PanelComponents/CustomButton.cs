namespace CPProject.components
{
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
            Font = new Font("Arial", 12);
            BackColor = Color.White;
            AutoSize = true;
            Height = 29;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.White;
            Cursor = Cursors.Hand;
            IsActivated = false;
        }
        private bool isActivated;
        public bool IsActivated
        {
            get => isActivated;
            set { setActive(value); isActivated = value; }
        }

        private void setActive(bool isActive)
        {
            if (isActive)
            {
                BackColor = Color.FromArgb(255, 184, 76);
                ForeColor = Color.White;
                Font = new Font("Arial", 12, FontStyle.Bold);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }
    }
}
