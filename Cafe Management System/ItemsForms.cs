using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class ItemsForms : Form
    {
        public ItemsForms()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Usuario\source\repos\Cafe Management System\Cafe Management System\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        void pupulate()
        {
            con.Open();
            string query = "select * from Itemtbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlaceorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxnumber.Text == "" || textBoxname.Text == "" || textBoxprice.Text == "" || CatCb.SelectedItem == null)
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                con.Open();
                string query = "insert into Itemtbl values ('" + textBoxnumber.Text + "','" + textBoxname.Text + "','" + CatCb.SelectedItem.ToString() + "','" + textBoxprice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully");
                con.Close();
                pupulate();
            }
        }

        private void ItemsForms_Load(object sender, EventArgs e)
        {
            pupulate();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItemGridView.SelectedRows.Count > 0)
            {
                textBoxnumber.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
                textBoxname.Text = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
                CatCb.SelectedItem = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
                textBoxprice.Text = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxnumber.Text == "")
            {
                MessageBox.Show("Please select a item to delete");

            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Itemtbl WHERE ItemName = @name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", textBoxname.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully");
                        pupulate();
                    }
                    else
                    {
                        MessageBox.Show("No item found");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting the item: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxnumber.Text == "" || textBoxname.Text == "" || CatCb.SelectedItem == null || textBoxprice.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                string query = "UPDATE Itemtbl SET ItemName = @name, ItemCat = @cat, ItemPrice = @price WHERE ItemNum = @number";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Usuario\source\repos\Cafe Management System\Cafe Management System\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@number", textBoxnumber.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@cat", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", textBoxprice.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item edited successfully");
                        pupulate();
                    }
                    else
                    {
                        MessageBox.Show("No item found");
                    }
                }
            }
        }
    }
}
