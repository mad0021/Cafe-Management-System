using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Usuario\source\repos\Cafe Management System\Cafe Management System\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        void pupulate()
        {
            con.Open();
            string query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGridView.DataSource = ds.Tables[0];
            con.Close();
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

        int num = 0;
        int price, total;
        string item, cat;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxquantity.Text == "")
            {
                MessageBox.Show("What is the quantity of the item?");
            }

            else if (flag == 0)
            {
                MessageBox.Show("Select the product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(textBoxquantity.Text);
                table.Rows.Add(num, item, cat, price, total);
                dataGridViewOrder.DataSource = table;
                flag = 0;
            }
        }
        DataTable table = new DataTable();
        int flag = 0;

        private void itemtblBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cafedbDataSet1.Itemtbl' Puede moverla o quitarla según sea necesario.
            this.itemtblTableAdapter.Fill(this.cafedbDataSet1.Itemtbl);
            pupulate();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            dataGridViewOrder.DataSource = table;
        }

        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemGridView.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }
    }
}
