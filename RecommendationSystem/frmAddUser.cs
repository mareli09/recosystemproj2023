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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        public string connection = "server=localhost;user id=root;password=;database=recsys";
        public string selectedgender;
        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtEmployeeNo.Text != string.Empty && txtLastName.Text != string.Empty && txtFirstName.Text != string.Empty && dtBirthdate.Text != DateTime.Now.ToString() && txtPosition.Text != string.Empty && txtDepartment.Text != string.Empty && txtAddress.Text != string.Empty && txtContactNo.Text != string.Empty && txtEmail.Text != string.Empty && cbAccessLevel.Text != string.Empty && cbActive.Text != string.Empty)
            {


                string formattedDate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
                MySqlConnection conn = new MySqlConnection(connection);
                

                string insertQuery = "INSERT INTO tblUser (LASTNAME,MIDDLENAME,FIRSTNAME,GENDER,BIRTHDATE,POSITION,DEPARTMENT,ADDRESS,CONTACTNO,EMAIL,ACCESSLEVEL,ACTIVE,DATEADDED,DATEINACTIVE,USERNAME,PASSWORD) VALUES (@lastname,@middlename,@firstname,@gender,@birthdate,@position,@department,@address,@contactno,@email,@accesslevel,@active,@dateadded,@dateinactive,@user,@password)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblUser WHERE username='" + txtUsername.Text + "'", conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Useename is already taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                conn.Close();
                                command.Parameters.AddWithValue("@lastname", txtLastName.Text);
                                command.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                                command.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                                command.Parameters.AddWithValue("@birthdate", dtBirthdate.Text);
                                command.Parameters.AddWithValue("@position", txtPosition.Text);
                                command.Parameters.AddWithValue("@department", txtDepartment.Text);
                                command.Parameters.AddWithValue("@address", txtAddress.Text);
                                command.Parameters.AddWithValue("@contactno", txtContactNo.Text);
                                command.Parameters.AddWithValue("@email", txtEmail.Text);
                                command.Parameters.AddWithValue("@accesslevel", cbAccessLevel.Text);
                                command.Parameters.AddWithValue("@active", cbActive.Text);
                                command.Parameters.AddWithValue("@dateadded", formattedDate);
                                if (cbActive.DataSource == "ACTIVE")
                                    command.Parameters.AddWithValue("@dateinactive", "N/A");
                                else
                                    command.Parameters.AddWithValue("@dateinactive", formattedDate);
                                command.Parameters.AddWithValue("@gender", selectedgender);
                                command.Parameters.AddWithValue("@user", txtUsername.Text);
                                command.Parameters.AddWithValue("@password", txtPassword.Text);
                                conn.Open();
                                command.ExecuteNonQuery();
                            }
                        }

                    }

                    //using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblprogram WHERE programname='" + txtProgramname.Text + "'", con))
                    //{
                    //    using (MySqlDataReader reader = cmd.ExecuteReader())
                    //    {
                    //        if (reader.Read())
                    //        {
                    //            MessageBox.Show("Name already existing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            return;
                    //        }
                    //        else
                    //        {
                    //            con.Close();
                    //            command.Parameters.AddWithValue("@id", ID);
                    //            command.Parameters.AddWithValue("@programname", txtProgramname.Text);
                    //            command.Parameters.AddWithValue("@dateadded", formatteddate);
                    //            command.Parameters.AddWithValue("@dateremove", "N/A");
                    //            con.Open();
                    //            command.ExecuteNonQuery();
                    //            con.Close();
                    //            MessageBox.Show("Program is successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            loaddata();
                    //            txtProgramname.Text = "";
                    //        }
                    //    }
                    //}

                }

                conn.Close();
                MessageBox.Show("Successfully Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManageUser manageUser = new frmManageUser();
                this.Hide();
                manageUser.Show();
            }
            else
            {
                //display error message
                MessageBox.Show("Fill up required fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            string[] values = { "ADMIN", "EARISTREPRESENTATIVE", "BARANGAYREPRESENTATIVE" };
            cbAccessLevel.DataSource = values;

            string[] values2 = { "ACTIVE", "INACTIVE" };
            cbActive.DataSource = values2;



            if (rbMale.Checked)
            {
                selectedgender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                selectedgender = rbFemale.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Text= string.Empty;
            txtContactNo.Text= string.Empty;
            txtDepartment.Text= string.Empty;
            txtEmployeeNo.Text= string.Empty;
            txtFirstName.Text= string.Empty;
            txtLastName.Text= string.Empty;
            txtMiddleName.Text= string.Empty;
            txtEmail.Text= string.Empty;
            txtPosition.Text= string.Empty;
            cbActive.DataSource = null;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage hp = new frmHomePage();
            this.Show(hp);
            this.Hide();
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmManageUser manageUser = new frmManageUser();
            this.Hide();
            manageUser.Show();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            frmInterview interview = new frmInterview();
            interview.Show();
            this.Hide();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            frmManageProgram mp = new frmManageProgram();
            mp.Show();
            this.Hide();
        }

        private void btnRecommendation_Click(object sender, EventArgs e)
        {
            frmRecommendation recommendation = new frmRecommendation();
            recommendation.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            this.Hide();
            about.Show();
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
