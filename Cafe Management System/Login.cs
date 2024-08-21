using System;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserOrder user = new UserOrder();
            user.Show();
            this.Hide();
        }
    }
}
