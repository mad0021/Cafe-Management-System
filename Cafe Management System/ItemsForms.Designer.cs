namespace Cafe_Management_System
{
    partial class ItemsForms
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonPlaceorder = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelItemlist = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxnumber = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSellername = new System.Windows.Forms.Label();
            this.labelOrdernum = new System.Windows.Forms.Label();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.labelManageitems = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.White;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(7, 170);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(226, 40);
            this.buttonUsers.TabIndex = 20;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonPlaceorder
            // 
            this.buttonPlaceorder.BackColor = System.Drawing.Color.White;
            this.buttonPlaceorder.FlatAppearance.BorderSize = 0;
            this.buttonPlaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceorder.Location = new System.Drawing.Point(7, 96);
            this.buttonPlaceorder.Name = "buttonPlaceorder";
            this.buttonPlaceorder.Size = new System.Drawing.Size(226, 40);
            this.buttonPlaceorder.TabIndex = 19;
            this.buttonPlaceorder.Text = "Place Order";
            this.buttonPlaceorder.UseVisualStyleBackColor = false;
            this.buttonPlaceorder.Click += new System.EventHandler(this.buttonPlaceorder_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelClose.Location = new System.Drawing.Point(1360, 5);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 38);
            this.labelClose.TabIndex = 18;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelItemlist);
            this.panel1.Controls.Add(this.textBoxprice);
            this.panel1.Controls.Add(this.textBoxname);
            this.panel1.Controls.Add(this.textBoxnumber);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelSellername);
            this.panel1.Controls.Add(this.labelOrdernum);
            this.panel1.Controls.Add(this.ItemGridView);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.labelManageitems);
            this.panel1.Location = new System.Drawing.Point(245, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 727);
            this.panel1.TabIndex = 16;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Silver;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(127, 386);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 40);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Silver;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(238, 386);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 40);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelItemlist
            // 
            this.labelItemlist.AutoSize = true;
            this.labelItemlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelItemlist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemlist.ForeColor = System.Drawing.Color.Black;
            this.labelItemlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelItemlist.Location = new System.Drawing.Point(740, 108);
            this.labelItemlist.Name = "labelItemlist";
            this.labelItemlist.Size = new System.Drawing.Size(142, 45);
            this.labelItemlist.TabIndex = 19;
            this.labelItemlist.Text = "Item List";
            // 
            // textBoxprice
            // 
            this.textBoxprice.BackColor = System.Drawing.Color.Silver;
            this.textBoxprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxprice.Location = new System.Drawing.Point(177, 323);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(234, 19);
            this.textBoxprice.TabIndex = 18;
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.Color.Silver;
            this.textBoxname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxname.Location = new System.Drawing.Point(190, 242);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(234, 19);
            this.textBoxname.TabIndex = 17;
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.BackColor = System.Drawing.Color.Silver;
            this.textBoxnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnumber.Location = new System.Drawing.Point(218, 156);
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(221, 19);
            this.textBoxnumber.TabIndex = 16;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelQuantity.Location = new System.Drawing.Point(30, 311);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(141, 38);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Item Price";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(16, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSellername
            // 
            this.labelSellername.AutoSize = true;
            this.labelSellername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSellername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSellername.Location = new System.Drawing.Point(30, 230);
            this.labelSellername.Name = "labelSellername";
            this.labelSellername.Size = new System.Drawing.Size(154, 38);
            this.labelSellername.TabIndex = 8;
            this.labelSellername.Text = "Item Name";
            this.labelSellername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrdernum
            // 
            this.labelOrdernum.AutoSize = true;
            this.labelOrdernum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOrdernum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdernum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOrdernum.Location = new System.Drawing.Point(30, 144);
            this.labelOrdernum.Name = "labelOrdernum";
            this.labelOrdernum.Size = new System.Drawing.Size(182, 38);
            this.labelOrdernum.TabIndex = 7;
            this.labelOrdernum.Text = "Item Number";
            this.labelOrdernum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemGridView
            // 
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Location = new System.Drawing.Point(445, 156);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(672, 552);
            this.ItemGridView.TabIndex = 6;
            this.ItemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGridView_CellContentClick);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Food",
            "Bevearge"});
            this.CatCb.Location = new System.Drawing.Point(37, 73);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(279, 40);
            this.CatCb.TabIndex = 5;
            this.CatCb.Text = "Catergory";
            // 
            // labelManageitems
            // 
            this.labelManageitems.AutoSize = true;
            this.labelManageitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelManageitems.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageitems.ForeColor = System.Drawing.Color.Black;
            this.labelManageitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelManageitems.Location = new System.Drawing.Point(695, 18);
            this.labelManageitems.Name = "labelManageitems";
            this.labelManageitems.Size = new System.Drawing.Size(206, 45);
            this.labelManageitems.TabIndex = 4;
            this.labelManageitems.Text = "Mange items";
            // 
            // ItemsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1399, 790);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonPlaceorder);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ItemsForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonPlaceorder;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSellername;
        private System.Windows.Forms.Label labelOrdernum;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label labelManageitems;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxnumber;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelItemlist;
    }
}