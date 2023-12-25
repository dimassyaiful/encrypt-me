using Encrypt_Me.services;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Encrypt_Me
{
    public partial class EncryptMe : Form
    { 
        Database db = new Database();
        public EncryptMe()
        {
            InitializeComponent();
            LoadPanel1();
            LoadPanel2();
            LoadPanel3();
            LoadPanel4();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
            panel1.Visible = true;
        }

        public void LoadPanel1()
        {
            Form activeForm;
            home page = new home(this);
            activeForm = page;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(activeForm);
            activeForm.Visible = true;
        }

        public void LoadPanel2()
        {
            Form activeForm;
            Encrypt page = new Encrypt();
            activeForm = page;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(activeForm);
            activeForm.Visible = true;
        }


        public void LoadPanel3()
        {
            Form activeForm;
            UserManagement page = new UserManagement();
            activeForm = page;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(activeForm);
            activeForm.Visible = true;
        }

        public void LoadPanel4()
        {
            Form activeForm;
            Login page = new Login();
            activeForm = page;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Add(activeForm);
            activeForm.Visible = true;
        }

        public void togglePanel(int number)
        { 
            if (number.Equals(1))
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (number.Equals(2))
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (number.Equals(3))
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel4.Visible = false;
            }
            else if (number.Equals(4))
            {
                panel4.Visible = true;
                panel3.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            togglePanel(1);

        }
    }



}
