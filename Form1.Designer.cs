namespace Encrypt_Me
{
    partial class EncryptMe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnTestLogin = new Button();
            btnUserManagement = new Button();
            btnEncryptModule = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 242, 245);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(100, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 222);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 112);
            label2.Name = "label2";
            label2.Size = new Size(683, 46);
            label2.TabIndex = 2;
            label2.Text = "This app can encrypt your sensitive data using the secure SHA-256 algorithm\r\nproviding a strong layer of protection for your information.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 57);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 1;
            label1.Text = "Let's Encrypt!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.efad0625e5ad29afebce1fe3f60c083c_1;
            pictureBox1.Location = new Point(794, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.Rectangle_32__1_;
            panel2.Controls.Add(btnTestLogin);
            panel2.Controls.Add(btnUserManagement);
            panel2.Controls.Add(btnEncryptModule);
            panel2.Location = new Point(100, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 794);
            panel2.TabIndex = 1;
            // 
            // btnTestLogin
            // 
            btnTestLogin.BackColor = Color.FromArgb(244, 242, 245);
            btnTestLogin.FlatAppearance.BorderSize = 0;
            btnTestLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btnTestLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btnTestLogin.FlatStyle = FlatStyle.Flat;
            btnTestLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestLogin.Image = Properties.Resources.icons8_login_100;
            btnTestLogin.ImageAlign = ContentAlignment.TopCenter;
            btnTestLogin.Location = new Point(741, 239);
            btnTestLogin.Name = "btnTestLogin";
            btnTestLogin.Size = new Size(250, 250);
            btnTestLogin.TabIndex = 2;
            btnTestLogin.Text = "Test Login";
            btnTestLogin.TextAlign = ContentAlignment.BottomCenter;
            btnTestLogin.UseVisualStyleBackColor = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(244, 242, 245);
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btnUserManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserManagement.Image = Properties.Resources.icons8_users_100;
            btnUserManagement.ImageAlign = ContentAlignment.TopCenter;
            btnUserManagement.Location = new Point(431, 239);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(250, 250);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User\r\nManagement";
            btnUserManagement.TextAlign = ContentAlignment.BottomCenter;
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnEncryptModule
            // 
            btnEncryptModule.BackColor = Color.FromArgb(244, 242, 245);
            btnEncryptModule.FlatAppearance.BorderSize = 0;
            btnEncryptModule.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btnEncryptModule.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btnEncryptModule.FlatStyle = FlatStyle.Flat;
            btnEncryptModule.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncryptModule.Image = Properties.Resources.icons8_encrypt_100;
            btnEncryptModule.ImageAlign = ContentAlignment.TopCenter;
            btnEncryptModule.Location = new Point(127, 239);
            btnEncryptModule.Name = "btnEncryptModule";
            btnEncryptModule.Size = new Size(250, 250);
            btnEncryptModule.TabIndex = 0;
            btnEncryptModule.Text = "Encrypt";
            btnEncryptModule.TextAlign = ContentAlignment.BottomCenter;
            btnEncryptModule.UseVisualStyleBackColor = false;
            // 
            // EncryptMe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 50, 86);
            ClientSize = new Size(1200, 1000);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EncryptMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encrypt Me";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnEncryptModule;
        private Button btnTestLogin;
        private Button btnUserManagement;
    }
}
