using System.Drawing.Drawing2D;

namespace Encrypt_Me
{
    public partial class EncryptMe : Form
    {
        public EncryptMe()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RoundButton(btnEncryptModule);
            RoundButton(btnUserManagement);
            RoundButton(btnTestLogin);

            btnEncryptModule.Padding = new Padding(40);
            btnUserManagement.Padding = new Padding(10, 40, 10, 20);
            btnTestLogin.Padding = new Padding(40);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RoundButton(Button btn)
        { 
            btn.Cursor = Cursors.Hand; 
            GraphicsPath radius = new GraphicsPath();

            radius.StartFigure();
            // Appends an elliptical arc to the current figure
            // Left corner top
            radius.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            // Appends a line segment to the current figure
            radius.AddLine(10, 0, btn.Width - 20, 0);
            // Appends an elliptical arc to the current figure
            // Right corner top
            radius.AddArc(new Rectangle(btn.Width - 20, 0, 20, 20), -90, 90);
            // Appends a line segment to the current figure
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10);
            // Appends an elliptical arc to the current figure 
            // Right corner bottom
            radius.AddArc(new Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90);
            // Appends a line segment to the current figure
            // Left corner bottom
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height);
            // Appends an elliptical arc to the current figure
            radius.AddArc(new Rectangle(0, btn.Height - 20, 20, 20), 90, 90);
            // Close the current figure and start a new one
            radius.CloseFigure();
            // Set the window associated with the control
            btn.Region = new Region(radius);
        }


    }



}
