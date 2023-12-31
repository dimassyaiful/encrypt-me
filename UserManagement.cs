using Encrypt_Me.services;
using System.Data;
using System.Drawing.Drawing2D; 

namespace Encrypt_Me
{
    public partial class UserManagement : Form
    {
        Database db = new Database();
        string selectedId = null;
        bool isNew = true;

        public UserManagement()
        {
            InitializeComponent();
            RoundButton(btn_add);
            RoundButton(btn_update);
            RoundButton(btn_delete);
            populateUserData();


        }

        private void populateUserData()
        {
            DataTable dataTable = db.getUserData();
            // Check if data is retrieved successfully
            if (dataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Error fetching data from the database.");
            }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get data from the clicked row
                var selectedData = dataGridView1.Rows[e.RowIndex];

                // Display the data in the TextBox
                txt_nama.Text = selectedData.Cells[0].Value?.ToString();
                // txt_password.Text = selectedData.Cells[2].Value?.ToString();
                txt_username.Text = selectedData.Cells[1].Value?.ToString();
                selectedId = selectedData.Cells[3].Value?.ToString();
                isNew = false;
                btn_update.Text = "Update";
                btn_add.Visible = true;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_nama.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_id.Text = "";
            isNew = true;
            btn_update.Text = "Add";
            btn_add.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string nama = txt_nama.Text;
            string passwod = txt_password.Text;
            string username = txt_username.Text;

            if (nama.Equals("") || passwod.Equals("") || passwod.Equals(""))
            {
                MessageBox.Show("Field Cannot be Empty");
                return;
            }

            if (isNew.Equals(true))
            {
                db.insertUserData(nama, username, passwod);
            }
            else
            {
                db.updateUserData(selectedId, nama, username, passwod);
            }
            populateUserData();


            txt_nama.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_id.Text = "";
            isNew = true;
            btn_update.Text = "Add";
            btn_add.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId == null) return;

            DialogResult result = MessageBox.Show("Yakin untuk menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            db.deleteUserData(selectedId);
            populateUserData();
            txt_nama.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_id.Text = "";
            isNew = true;
            btn_update.Text = "Add";
            btn_add.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isNew = false;
            btn_update.Text = "Update";
            btn_add.Visible = true;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }
    }


}
