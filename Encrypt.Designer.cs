namespace Encrypt_Me
{
    partial class Encrypt
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
            txt_text = new TextBox();
            txt_secretKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTestLogin = new Button();
            txt_utf8 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_encrypt = new TextBox();
            SuspendLayout();
            // 
            // txt_text
            // 
            txt_text.BorderStyle = BorderStyle.FixedSingle;
            txt_text.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_text.Location = new Point(62, 203);
            txt_text.Name = "txt_text";
            txt_text.Size = new Size(343, 45);
            txt_text.TabIndex = 0;
            // 
            // txt_secretKey
            // 
            txt_secretKey.BorderStyle = BorderStyle.FixedSingle;
            txt_secretKey.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_secretKey.Location = new Point(426, 202);
            txt_secretKey.Name = "txt_secretKey";
            txt_secretKey.Size = new Size(400, 45);
            txt_secretKey.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 161);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 2;
            label1.Text = "Some Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(426, 160);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 3;
            label2.Text = "Secret Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 42);
            label3.Name = "label3";
            label3.Size = new Size(194, 65);
            label3.TabIndex = 4;
            label3.Text = "Encrypt";
            // 
            // btnTestLogin
            // 
            btnTestLogin.BackColor = Color.FromArgb(34, 50, 86);
            btnTestLogin.FlatAppearance.BorderSize = 0;
            btnTestLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 221, 221);
            btnTestLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 221, 221);
            btnTestLogin.FlatStyle = FlatStyle.Flat;
            btnTestLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestLogin.ForeColor = Color.White;
            btnTestLogin.ImageAlign = ContentAlignment.TopCenter;
            btnTestLogin.Location = new Point(846, 203);
            btnTestLogin.Name = "btnTestLogin";
            btnTestLogin.Size = new Size(173, 45);
            btnTestLogin.TabIndex = 10;
            btnTestLogin.Text = "Encrypt";
            btnTestLogin.UseVisualStyleBackColor = false;
            // 
            // txt_utf8
            // 
            txt_utf8.BorderStyle = BorderStyle.FixedSingle;
            txt_utf8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_utf8.Location = new Point(62, 351);
            txt_utf8.Multiline = true;
            txt_utf8.Name = "txt_utf8";
            txt_utf8.Size = new Size(957, 190);
            txt_utf8.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 303);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 12;
            label4.Text = "UTF 8 Bytes";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 582);
            label5.Name = "label5";
            label5.Size = new Size(198, 32);
            label5.TabIndex = 14;
            label5.Text = "Encryption Result";
            // 
            // txt_encrypt
            // 
            txt_encrypt.BorderStyle = BorderStyle.FixedSingle;
            txt_encrypt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_encrypt.Location = new Point(61, 630);
            txt_encrypt.Multiline = true;
            txt_encrypt.Name = "txt_encrypt";
            txt_encrypt.Size = new Size(957, 190);
            txt_encrypt.TabIndex = 13;
            // 
            // Encrypt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 204, 204);
            ClientSize = new Size(1069, 885);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(txt_encrypt);
            Controls.Add(label4);
            Controls.Add(txt_utf8);
            Controls.Add(btnTestLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_secretKey);
            Controls.Add(txt_text);
            Name = "Encrypt";
            Text = "Encrypt";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_text;
        private TextBox txt_secretKey;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTestLogin;
        private TextBox txt_utf8;
        private Label label4;
        private Label label5;
        private TextBox txt_encrypt;
    }
}