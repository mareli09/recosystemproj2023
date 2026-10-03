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
    public partial class frmManageUser : Form
    {
        int ID;
        public frmManageUser()
        {
            InitializeComponent();
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser au = new frmAddUser();
            au.Show();
            this.Hide();
        }
        public string connection = "server=localhost;user id=root;password=;database=recsys";
        private void frmManageUser_Load(object sender, EventArgs e)
        {
            string query = "select * from tbluser";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txtProgramname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(e.RowIndex != -1)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            lblEmployeeNo.Text =  dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblGender.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblBirthDate.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            llblPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            lblAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            lblContact.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            lblEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            lblAccessLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            lblActive.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            lblEmployeeNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblGender.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblBirthDate.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            llblPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            lblAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            lblContact.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            lblEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            lblAccessLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            lblActive.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblEmployeeNo.Text = string.Empty;
            lblLastName.Text = string.Empty;
            lblMiddleName.Text = string.Empty;
            lblFirstName.Text = string.Empty;
            lblGender.Text = string.Empty;
            lblBirthDate.Text = string.Empty;
            llblPosition.Text = string.Empty;
            lblDepartment.Text = string.Empty;
            lblAddress.Text = string.Empty;
            lblContact.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblAccessLevel.Text = string.Empty;
            lblActive.Text = string.Empty;
        }
    }
}
