namespace Encrypt_Me
{
    partial class UserManagement
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
            label1 = new Label();
            txt_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            label4 = new Label();
            txt_nama = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 137);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(39, 179);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(343, 45);
            txt_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 31);
            label3.Name = "label3";
            label3.Size = new Size(431, 65);
            label3.TabIndex = 5;
            label3.Text = "User Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 137);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(419, 179);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(343, 45);
            txt_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 256);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 9;
            label4.Text = "Nama";
            // 
            // txt_nama
            // 
            txt_nama.BorderStyle = BorderStyle.FixedSingle;
            txt_nama.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nama.Location = new Point(39, 298);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(343, 45);
            txt_nama.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(34, 50, 86);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btn_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.ImageAlign = ContentAlignment.TopCenter;
            btn_add.Location = new Point(39, 371);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(173, 45);
            btn_add.TabIndex = 11;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(34, 50, 86);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.ImageAlign = ContentAlignment.TopCenter;
            btn_update.Location = new Point(239, 371);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(173, 45);
            btn_update.TabIndex = 12;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(110, 18, 18);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.ImageAlign = ContentAlignment.TopCenter;
            btn_delete.Location = new Point(441, 371);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(173, 45);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(988, 342);
            dataGridView1.TabIndex = 14;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 885);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(txt_nama);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Name = "UserManagement";
            Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private Label label3;
        private Label label2;
        private TextBox txt_password;
        private Label label4;
        private TextBox txt_nama;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dataGridView1;
    }
}