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
            label4 = new Label();
            label5 = new Label();
            txt_encrypt = new TextBox();
            label6 = new Label();
            txt_encryptionInBytes = new TextBox();
            txt_bytesOfUtf8 = new TextBox();
            txt_result = new TextBox();
            label7 = new Label();
            txt_totalBit = new Label();
            SuspendLayout();
            // 
            // txt_text
            // 
            txt_text.BorderStyle = BorderStyle.FixedSingle;
            txt_text.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_text.Location = new Point(62, 161);
            txt_text.Name = "txt_text";
            txt_text.Size = new Size(343, 45);
            txt_text.TabIndex = 0;
            // 
            // txt_secretKey
            // 
            txt_secretKey.BorderStyle = BorderStyle.FixedSingle;
            txt_secretKey.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_secretKey.Location = new Point(426, 160);
            txt_secretKey.Name = "txt_secretKey";
            txt_secretKey.Size = new Size(400, 45);
            txt_secretKey.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 119);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 2;
            label1.Text = "Some Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(426, 118);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 3;
            label2.Text = "Secret Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 23);
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
            btnTestLogin.Location = new Point(846, 161);
            btnTestLogin.Name = "btnTestLogin";
            btnTestLogin.Size = new Size(173, 45);
            btnTestLogin.TabIndex = 10;
            btnTestLogin.Text = "Encrypt";
            btnTestLogin.UseVisualStyleBackColor = false;
            btnTestLogin.Click += btnTestLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 237);
            label4.Name = "label4";
            label4.Size = new Size(173, 32);
            label4.TabIndex = 12;
            label4.Text = "Text to Binary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 534);
            label5.Name = "label5";
            label5.Size = new Size(286, 32);
            label5.TabIndex = 14;
            label5.Text = "SHA256 in Hexadecimal";
            // 
            // txt_encrypt
            // 
            txt_encrypt.BorderStyle = BorderStyle.FixedSingle;
            txt_encrypt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_encrypt.Location = new Point(62, 580);
            txt_encrypt.Multiline = true;
            txt_encrypt.Name = "txt_encrypt";
            txt_encrypt.Size = new Size(957, 82);
            txt_encrypt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(62, 390);
            label6.Name = "label6";
            label6.Size = new Size(214, 32);
            label6.TabIndex = 16;
            label6.Text = "SHA256 in Binary";
            // 
            // txt_encryptionInBytes
            // 
            txt_encryptionInBytes.BorderStyle = BorderStyle.FixedSingle;
            txt_encryptionInBytes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_encryptionInBytes.Location = new Point(61, 430);
            txt_encryptionInBytes.Multiline = true;
            txt_encryptionInBytes.Name = "txt_encryptionInBytes";
            txt_encryptionInBytes.Size = new Size(957, 82);
            txt_encryptionInBytes.TabIndex = 15;
            // 
            // txt_bytesOfUtf8
            // 
            txt_bytesOfUtf8.BorderStyle = BorderStyle.FixedSingle;
            txt_bytesOfUtf8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bytesOfUtf8.Location = new Point(60, 279);
            txt_bytesOfUtf8.Multiline = true;
            txt_bytesOfUtf8.Name = "txt_bytesOfUtf8";
            txt_bytesOfUtf8.Size = new Size(957, 79);
            txt_bytesOfUtf8.TabIndex = 17;
            // 
            // txt_result
            // 
            txt_result.BorderStyle = BorderStyle.FixedSingle;
            txt_result.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_result.Location = new Point(62, 739);
            txt_result.Multiline = true;
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(957, 82);
            txt_result.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(62, 693);
            label7.Name = "label7";
            label7.Size = new Size(84, 32);
            label7.TabIndex = 19;
            label7.Text = "Result";
            // 
            // txt_totalBit
            // 
            txt_totalBit.AutoSize = true;
            txt_totalBit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_totalBit.Location = new Point(972, 237);
            txt_totalBit.Name = "txt_totalBit";
            txt_totalBit.Size = new Size(0, 32);
            txt_totalBit.TabIndex = 21;
            // 
            // Encrypt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 242, 245);
            ClientSize = new Size(1069, 885);
            ControlBox = false;
            Controls.Add(txt_totalBit);
            Controls.Add(label7);
            Controls.Add(txt_result);
            Controls.Add(txt_bytesOfUtf8);
            Controls.Add(label6);
            Controls.Add(txt_encryptionInBytes);
            Controls.Add(label5);
            Controls.Add(txt_encrypt);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private TextBox txt_encrypt;
        private Label label6;
        private TextBox txt_encryptionInBytes;
        private TextBox txt_bytesOfUtf8;
        private TextBox txt_result;
        private Label label7;
        private Label txt_totalBit;
    }
}