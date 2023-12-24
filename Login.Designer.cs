namespace Encrypt_Me
{
    partial class Login
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
            panel1 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            txt_password = new TextBox();
            label1 = new Label();
            txt_username = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 242, 245);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(204, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 537);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(34, 50, 86);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(253, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(173, 45);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 296);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(59, 340);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(611, 45);
            txt_password.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 171);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(59, 215);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(611, 45);
            txt_username.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(276, 58);
            label3.Name = "label3";
            label3.Size = new Size(150, 65);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 242, 245);
            BackgroundImage = Properties.Resources.Rectangle_32__1_;
            ClientSize = new Size(1120, 1025);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txt_username;
        private Label label2;
        private TextBox txt_password;
        private Label label1;
        private Button btnLogin;
    }
}