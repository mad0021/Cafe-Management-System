using System;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForms Item = new ItemsForms();
            Item.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForms users = new UsersForms();
            users.Show();
        }
    }
}
