using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Cafe_Management_System
{
    public partial class UsersForms : Form
    {
        public UsersForms()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Usuario\source\repos\Cafe Management System\Cafe Management System\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        void pupulate()
        {
            con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void buttonPlaceorder_Click(object sender, EventArgs e)
        {
            UserOrder order = new UserOrder();
            order.Show();
            this.Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            ItemsForms items = new ItemsForms();
            items.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTbl values ('" + textBoxusername.Text+ "','" + textBoxPhone.Text + "','" + textBoxPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Added Successfully");
            con.Close();
            pupulate();
        }

        private void UsersForms_Load(object sender, EventArgs e)
        {
            pupulate();
        }

        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItemGridView.SelectedRows.Count > 0)
            {
                textBoxusername.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPhone.Text = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPassword.Text = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Please select a user to delete");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM UsersTbl WHERE Uphone = @phone";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully");
                        pupulate();
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified phone number");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting the user: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "" || textBoxusername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                con.Open();
                string query = "UPDATE UsersTbl SET Uname = @name, Uphone = @phone, Upassword = @password WHERE Uphone = @phone";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textBoxusername.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User edited successfully");
                con.Close();
                pupulate();
            }
        }
    }
}
