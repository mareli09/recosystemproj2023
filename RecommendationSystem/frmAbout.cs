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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage hp = new frmHomePage();
            hp.Show();
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
