namespace Cafe_Management_System
{
    partial class UsersForms
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
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonPlaceorder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labeluserslist = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.labelManageusers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonItems
            // 
            this.buttonItems.BackColor = System.Drawing.Color.White;
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItems.Location = new System.Drawing.Point(12, 127);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(226, 40);
            this.buttonItems.TabIndex = 24;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonPlaceorder
            // 
            this.buttonPlaceorder.BackColor = System.Drawing.Color.White;
            this.buttonPlaceorder.FlatAppearance.BorderSize = 0;
            this.buttonPlaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceorder.Location = new System.Drawing.Point(12, 56);
            this.buttonPlaceorder.Name = "buttonPlaceorder";
            this.buttonPlaceorder.Size = new System.Drawing.Size(226, 40);
            this.buttonPlaceorder.TabIndex = 23;
            this.buttonPlaceorder.Text = "Place Order";
            this.buttonPlaceorder.UseVisualStyleBackColor = false;
            this.buttonPlaceorder.Click += new System.EventHandler(this.buttonPlaceorder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labeluserslist);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.ItemGridView);
            this.panel1.Controls.Add(this.labelManageusers);
            this.panel1.Location = new System.Drawing.Point(250, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 727);
            this.panel1.TabIndex = 21;
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
            // labeluserslist
            // 
            this.labeluserslist.AutoSize = true;
            this.labeluserslist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeluserslist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserslist.ForeColor = System.Drawing.Color.Black;
            this.labeluserslist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labeluserslist.Location = new System.Drawing.Point(740, 108);
            this.labeluserslist.Name = "labeluserslist";
            this.labeluserslist.Size = new System.Drawing.Size(155, 45);
            this.labeluserslist.TabIndex = 19;
            this.labeluserslist.Text = "Users List";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Silver;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(147, 323);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(351, 19);
            this.textBoxPassword.TabIndex = 18;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.Silver;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Location = new System.Drawing.Point(111, 257);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(351, 19);
            this.textBoxPhone.TabIndex = 17;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.Silver;
            this.textBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxusername.Location = new System.Drawing.Point(162, 198);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(332, 19);
            this.textBoxusername.TabIndex = 16;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPassword.Location = new System.Drawing.Point(9, 308);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(132, 38);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.Location = new System.Drawing.Point(9, 242);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(96, 38);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelusername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelusername.Location = new System.Drawing.Point(9, 183);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(147, 38);
            this.labelusername.TabIndex = 7;
            this.labelusername.Text = "UserName";
            this.labelusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemGridView
            // 
            this.ItemGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.ItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.GridColor = System.Drawing.SystemColors.Info;
            this.ItemGridView.Location = new System.Drawing.Point(555, 156);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(562, 552);
            this.ItemGridView.TabIndex = 6;
            this.ItemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGridView_CellContentClick);
            // 
            // labelManageusers
            // 
            this.labelManageusers.AutoSize = true;
            this.labelManageusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelManageusers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageusers.ForeColor = System.Drawing.Color.Black;
            this.labelManageusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelManageusers.Location = new System.Drawing.Point(695, 18);
            this.labelManageusers.Name = "labelManageusers";
            this.labelManageusers.Size = new System.Drawing.Size(206, 45);
            this.labelManageusers.TabIndex = 4;
            this.labelManageusers.Text = "Mange Users";
            // 
            // UsersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1400, 753);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonPlaceorder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForms";
            this.Load += new System.EventHandler(this.UsersForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonPlaceorder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labeluserslist;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Label labelManageusers;
    }
}