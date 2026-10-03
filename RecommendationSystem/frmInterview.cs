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
using System.Xml.Linq;

namespace RecommendationSystem
{
    public partial class frmInterview : Form
    {
        int ID;
        public frmInterview()
        {
            InitializeComponent();
        }
        public static string connection = "server=localhost;user id=root;password=;database=recsys";
        private void frmInterview_Load(object sender, EventArgs e)
        {
            loaddata();

            MySqlConnection con = new MySqlConnection(connection); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select programname from tblprogram where dateremove = 'N/A'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString("programname");
                cbProgram.Items.Add(name);
            }
            cmd.Dispose();
            reader.Close();
            con.Close();

        }
        void clear()
        {
            txtResidentName.Text = "";
            cbProgram.Items.Clear();
            txtQuestion1.Text = "";
            txtQuestion2.Text = "";

        }
        void loaddata() 
        {
            MySqlConnection con = new MySqlConnection(connection);
            string qry = "select * from tblinterview where dateremove = 'N/A'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvInterview.DataSource = dt;
            con.Close();
            dgvInterview.AutoResizeColumns();
            dgvInterview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInterview.Columns[0].Visible = false;
        }

        private void btnAddInterview_Click(object sender, EventArgs e)
        {
            if (txtResidentName.Text != string.Empty && cbProgram.Text != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(connection);
                string insertqry = "INSERT INTO tblInterview(ResidentName,Program,Question1,Question2,DateAdded,DateRemove) VALUES(@residentname,@program,@questionno1,@questionno2,@dateadded,@dateremove)";
                string formatteddate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");

                using (MySqlCommand command = new MySqlCommand(insertqry, con))
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblInterview WHERE residentname='" + txtResidentName.Text + "' and program = '"+cbProgram.Text+"'", con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Entry already exist please select another program", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                con.Close();
                                command.Parameters.AddWithValue("@residentname", txtResidentName.Text);
                                command.Parameters.AddWithValue("@program", cbProgram.Text);
                                command.Parameters.AddWithValue("@questionno1", txtQuestion1.Text);
                                command.Parameters.AddWithValue("@questionno2", txtQuestion2.Text);
                                command.Parameters.AddWithValue("@dateadded", formatteddate);
                                command.Parameters.AddWithValue("@dateremove", "N/A");
                                con.Open();
                                command.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Entry successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loaddata();
                                
                            }
                        }
                    }


                }

            }
            else
            {
                MessageBox.Show("Fill up resident name first before clicking enter button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvInterview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                ID = Convert.ToInt32(dgvInterview.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtResidentName.Text = dgvInterview.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbProgram.Text = dgvInterview.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuestion1.Text = dgvInterview.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuestion2.Text = dgvInterview.Rows[e.RowIndex].Cells[4].Value.ToString();
                
        }

        private void dgvInterview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtResidentName.Text != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(connection);
                string insertqry = "update tblinterview set residentname = @resident, program=@program, question1 = @q1, question2 = @q2, dateadded = @date where ID = @id";
                string formatteddate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");

                using (MySqlCommand command = new MySqlCommand(insertqry, con))
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblinterview WHERE residentname ='" + txtResidentName.Text + "'", con))
                    {
                        


                                con.Close();
                                command.Parameters.AddWithValue("@id", ID);
                                command.Parameters.AddWithValue("@resident", txtResidentName.Text);
                                command.Parameters.AddWithValue("@program", cbProgram.Text);
                                command.Parameters.AddWithValue("@q1", txtQuestion1.Text);
                                command.Parameters.AddWithValue("@q2", txtQuestion2.Text);
                                command.Parameters.AddWithValue("@date", formatteddate);
                                con.Open();
                                command.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Information is successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loaddata();
                                txtResidentName.Text = "";

                    }


                }

            }
            else
            {
                MessageBox.Show("Select Resident Name first before clicking update button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
