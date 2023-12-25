using Encrypt_Me.model;
using Encrypt_Me.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Me
{
    public partial class Login : Form
    {

        Database db = new Database();
        public Login()
        {
            InitializeComponent();
            round_panel();
            RoundButton(btnLogin);
        }

        private void RoundButton(Button btn)
        {
            btn.Cursor = Cursors.Hand;
            GraphicsPath radius = new GraphicsPath();

            radius.StartFigure();
            radius.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            radius.AddLine(10, 0, btn.Width - 20, 0);
            radius.AddArc(new Rectangle(btn.Width - 20, 0, 20, 20), -90, 90);
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10);
            radius.AddArc(new Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90);
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height);
            radius.AddArc(new Rectangle(0, btn.Height - 20, 20, 20), 90, 90);
            radius.CloseFigure();
            btn.Region = new Region(radius);
        }

        private void round_panel()
        {
            GraphicsPath radius = new GraphicsPath();

            radius.StartFigure();
            radius.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            radius.AddLine(10, 0, panel1.Width - 20, 0);
            radius.AddArc(new Rectangle(panel1.Width - 20, 0, 20, 20), -90, 90);
            radius.AddLine(panel1.Width, 20, panel1.Width, panel1.Height - 10);
            radius.AddArc(new Rectangle(panel1.Width - 25, panel1.Height - 25, 25, 25), 0, 90);
            radius.AddLine(panel1.Width - 10, panel1.Width, 20, panel1.Height);
            radius.AddArc(new Rectangle(0, panel1.Height - 20, 20, 20), 90, 90);
            radius.CloseFigure();
            panel1.Region = new Region(radius);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // get data from database
            string pwd = db.getUserPasswordByUsername(username);

            // get hash inserted password
            EncryptionService encryptionService = new EncryptionService();
            string secretKey = encryptionService.getSecretKeyUserData();
            ResultModel result = encryptionService.encryptToSHA256(password, secretKey);
            string hashedPassword = result.getResult();

            // compare
            if(hashedPassword.Equals(pwd)) {
                MessageBox.Show("Success Authenticated", "Success!");
            }
            else
            {
                MessageBox.Show("Please Check Username or Password","Failed!");

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }


}
