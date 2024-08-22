namespace Cafe_Management_System
{
    partial class UserOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.labelOrdernum = new System.Windows.Forms.Label();
            this.labelSellername = new System.Windows.Forms.Label();
            this.labelOrderamount = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelYourorder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.textBoxsellername = new System.Windows.Forms.TextBox();
            this.textBoxOrdernum = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.cafedbDataSet1 = new Cafe_Management_System.CafedbDataSet1();
            this.itemtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtblTableAdapter = new Cafe_Management_System.CafedbDataSet1TableAdapters.ItemtblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafedbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(680, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Place Order";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Bevearge"});
            this.comboBox1.Location = new System.Drawing.Point(37, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 40);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Catergory";
            // 
            // ItemGridView
            // 
            this.ItemGridView.AutoGenerateColumns = false;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.DataSource = this.cafedbDataSet1;
            this.ItemGridView.Location = new System.Drawing.Point(364, 73);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(757, 251);
            this.ItemGridView.TabIndex = 6;
            this.ItemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGridView_CellContentClick);
            // 
            // labelOrdernum
            // 
            this.labelOrdernum.AutoSize = true;
            this.labelOrdernum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOrdernum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdernum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOrdernum.Location = new System.Drawing.Point(30, 136);
            this.labelOrdernum.Name = "labelOrdernum";
            this.labelOrdernum.Size = new System.Drawing.Size(158, 38);
            this.labelOrdernum.TabIndex = 7;
            this.labelOrdernum.Text = "Order Num";
            this.labelOrdernum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSellername
            // 
            this.labelSellername.AutoSize = true;
            this.labelSellername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSellername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSellername.Location = new System.Drawing.Point(30, 204);
            this.labelSellername.Name = "labelSellername";
            this.labelSellername.Size = new System.Drawing.Size(168, 38);
            this.labelSellername.TabIndex = 8;
            this.labelSellername.Text = "Seller Name";
            this.labelSellername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrderamount
            // 
            this.labelOrderamount.AutoSize = true;
            this.labelOrderamount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOrderamount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderamount.ForeColor = System.Drawing.Color.Black;
            this.labelOrderamount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOrderamount.Location = new System.Drawing.Point(817, 677);
            this.labelOrderamount.Name = "labelOrderamount";
            this.labelOrderamount.Size = new System.Drawing.Size(226, 45);
            this.labelOrderamount.TabIndex = 10;
            this.labelOrderamount.Text = "Order Amount";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(37, 322);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(226, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add to Cart";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(302, 408);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 62;
            this.dataGridViewOrder.RowTemplate.Height = 28;
            this.dataGridViewOrder.Size = new System.Drawing.Size(819, 251);
            this.dataGridViewOrder.TabIndex = 12;
            // 
            // labelYourorder
            // 
            this.labelYourorder.AutoSize = true;
            this.labelYourorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelYourorder.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourorder.ForeColor = System.Drawing.Color.Black;
            this.labelYourorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYourorder.Location = new System.Drawing.Point(680, 360);
            this.labelYourorder.Name = "labelYourorder";
            this.labelYourorder.Size = new System.Drawing.Size(174, 45);
            this.labelYourorder.TabIndex = 13;
            this.labelYourorder.Text = "Your Order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Place the Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelQuantity.Location = new System.Drawing.Point(30, 265);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(123, 38);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxquantity);
            this.panel1.Controls.Add(this.textBoxsellername);
            this.panel1.Controls.Add(this.textBoxOrdernum);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelYourorder);
            this.panel1.Controls.Add(this.dataGridViewOrder);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelOrderamount);
            this.panel1.Controls.Add(this.labelSellername);
            this.panel1.Controls.Add(this.labelOrdernum);
            this.panel1.Controls.Add(this.ItemGridView);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(249, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 727);
            this.panel1.TabIndex = 10;
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.BackColor = System.Drawing.Color.Silver;
            this.textBoxquantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxquantity.Location = new System.Drawing.Point(159, 280);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(136, 19);
            this.textBoxquantity.TabIndex = 19;
            // 
            // textBoxsellername
            // 
            this.textBoxsellername.BackColor = System.Drawing.Color.Silver;
            this.textBoxsellername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsellername.Location = new System.Drawing.Point(194, 219);
            this.textBoxsellername.Name = "textBoxsellername";
            this.textBoxsellername.Size = new System.Drawing.Size(136, 19);
            this.textBoxsellername.TabIndex = 18;
            // 
            // textBoxOrdernum
            // 
            this.textBoxOrdernum.BackColor = System.Drawing.Color.Silver;
            this.textBoxOrdernum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOrdernum.Location = new System.Drawing.Point(194, 151);
            this.textBoxOrdernum.Name = "textBoxOrdernum";
            this.textBoxOrdernum.Size = new System.Drawing.Size(136, 19);
            this.textBoxOrdernum.TabIndex = 17;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Silver;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(11, 733);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(226, 40);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelClose.Location = new System.Drawing.Point(1364, -2);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 38);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.BackColor = System.Drawing.Color.White;
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItems.Location = new System.Drawing.Point(17, 87);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(173, 40);
            this.buttonItems.TabIndex = 13;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.White;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(17, 161);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(167, 40);
            this.buttonUsers.TabIndex = 14;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // cafedbDataSet1
            // 
            this.cafedbDataSet1.DataSetName = "CafedbDataSet1";
            this.cafedbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtblBindingSource
            // 
            this.itemtblBindingSource.DataMember = "Itemtbl";
            this.itemtblBindingSource.DataSource = this.cafedbDataSet1;
            this.itemtblBindingSource.CurrentChanged += new System.EventHandler(this.itemtblBindingSource_CurrentChanged);
            // 
            // itemtblTableAdapter
            // 
            this.itemtblTableAdapter.ClearBeforeFill = true;
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1401, 795);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafedbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Label labelOrdernum;
        private System.Windows.Forms.Label labelSellername;
        private System.Windows.Forms.Label labelOrderamount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelYourorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.TextBox textBoxsellername;
        private System.Windows.Forms.TextBox textBoxOrdernum;
        private CafedbDataSet1 cafedbDataSet1;
        private System.Windows.Forms.BindingSource itemtblBindingSource;
        private CafedbDataSet1TableAdapters.ItemtblTableAdapter itemtblTableAdapter;
    }
}