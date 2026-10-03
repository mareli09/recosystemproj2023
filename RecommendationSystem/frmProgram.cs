using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace RecommendationSystem
{
    public partial class frmManageProgram : Form
    {
        int ID;
        public frmManageProgram()
        {
            InitializeComponent();
        }
        public static string connection = "server=localhost;user id=root;password=;database=recsys";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            MySqlConnection con = new MySqlConnection(connection);
            string qry = "select * from tblprogram where dateremove = 'N/A'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[0].Visible = false;
           
        }
        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            if(txtProgramname.Text != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(connection);
                string insertqry = "INSERT INTO tblprogram(programname,dateadded,dateremove) VALUES(@programname,@dateadded,@dateremove)";
                string formatteddate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");

                using (MySqlCommand command = new MySqlCommand(insertqry, con))
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblprogram WHERE programname='" + txtProgramname.Text + "'",con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                MessageBox.Show("Name already existing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                con.Close();
                                command.Parameters.AddWithValue("@id", ID);
                                command.Parameters.AddWithValue("@programname", txtProgramname.Text);
                                command.Parameters.AddWithValue("@dateadded", formatteddate);
                                command.Parameters.AddWithValue("@dateremove", "N/A");
                                con.Open();
                                command.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Program is successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loaddata();
                                txtProgramname.Text = "";
                            }
                        }
                    }

                    
                }

            }
            else
            {
                MessageBox.Show("Fill up Program Name first before clicking add button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtProgramname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtProgramname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtProgramname.Text != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(connection);
                string insertqry = "update tblprogram set dateremove = @dateremove where ID = @id";
                string formatteddate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");

                using (MySqlCommand command = new MySqlCommand(insertqry, con))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@dateremove", formatteddate);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Program Name is successfully removed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    txtProgramname.Text = "";



                }

            }
            else
            {
                MessageBox.Show("Select Program Name first before clicking remove button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProgram_Click(object sender, EventArgs e)
        {
            if (txtProgramname.Text != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(connection);
                string insertqry = "update tblprogram set programname = @programname, dateadded=@dateadded, dateremove = @dateremove where ID = @id";
                string formatteddate = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");

                using (MySqlCommand command = new MySqlCommand(insertqry, con))
                {

                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblprogram WHERE programname='" + txtProgramname.Text + "'", con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Name already existing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                con.Close();
                                command.Parameters.AddWithValue("@id", ID);
                                command.Parameters.AddWithValue("@programname", txtProgramname.Text);
                                command.Parameters.AddWithValue("@dateadded", formatteddate);
                                command.Parameters.AddWithValue("@dateremove", "N/A");
                                con.Open();
                                command.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Program Name is successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loaddata();
                                txtProgramname.Text = "";
                            }
                        }
                    }


                }

            }
            else
            {
                MessageBox.Show("Select Program Name first before clicking update button", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
