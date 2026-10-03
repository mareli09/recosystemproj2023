using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecommendationSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public string connection = "server=localhost;user id=root;password=;database=recsys";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string query = "select * from tblUser where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[14].ToString() == "SUPERADMIN")
                    {

                        MessageBox.Show("Successfully Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHomePage HP = new frmHomePage();
                        HP.Show();
                        this.Hide();


                    }
                    if (reader[14].ToString() == "ADMIN")
                    {

                        MessageBox.Show("Successfully Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHomePage HP = new frmHomePage();
                        HP.Show();
                        this.Hide();


                    }
                    //else if (reader[15].ToString()=="ADMIN")

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Fill Username and Password first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //not doing anything.
            }
        }
        private void btnViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnViewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
