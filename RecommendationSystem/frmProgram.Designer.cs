namespace RecommendationSystem
{
    partial class frmManageProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProgramname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdateProgram = new System.Windows.Forms.Button();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecommendation = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnInterview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProgramname
            // 
            this.txtProgramname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramname.Location = new System.Drawing.Point(224, 173);
            this.txtProgramname.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgramname.Multiline = true;
            this.txtProgramname.Name = "txtProgramname";
            this.txtProgramname.Size = new System.Drawing.Size(891, 44);
            this.txtProgramname.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Program Name:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 344);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 40);
            this.btnRemove.TabIndex = 91;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateProgram
            // 
            this.btnUpdateProgram.Location = new System.Drawing.Point(224, 291);
            this.btnUpdateProgram.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProgram.Name = "btnUpdateProgram";
            this.btnUpdateProgram.Size = new System.Drawing.Size(113, 40);
            this.btnUpdateProgram.TabIndex = 90;
            this.btnUpdateProgram.Text = "UPDATE";
            this.btnUpdateProgram.UseVisualStyleBackColor = true;
            this.btnUpdateProgram.Click += new System.EventHandler(this.btnUpdateProgram_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(224, 236);
            this.btnAddProgram.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(113, 40);
            this.btnAddProgram.TabIndex = 89;
            this.btnAddProgram.Text = "ADD";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(755, 329);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(225, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 87;
            this.label16.Text = "PROGRAM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRecommendation);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnProgram);
            this.panel1.Controls.Add(this.btnInterview);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 681);
            this.panel1.TabIndex = 94;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(2, 435);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRecommendation
            // 
            this.btnRecommendation.FlatAppearance.BorderSize = 0;
            this.btnRecommendation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommendation.ForeColor = System.Drawing.Color.White;
            this.btnRecommendation.Location = new System.Drawing.Point(2, 361);
            this.btnRecommendation.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecommendation.Name = "btnRecommendation";
            this.btnRecommendation.Size = new System.Drawing.Size(171, 34);
            this.btnRecommendation.TabIndex = 7;
            this.btnRecommendation.Text = "RECOMMENDATION";
            this.btnRecommendation.UseVisualStyleBackColor = true;
            this.btnRecommendation.Click += new System.EventHandler(this.btnRecommendation_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(2, 399);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(171, 34);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "ABOUT US";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProgram.FlatAppearance.BorderSize = 3;
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgram.ForeColor = System.Drawing.Color.White;
            this.btnProgram.Location = new System.Drawing.Point(2, 325);
            this.btnProgram.Margin = new System.Windows.Forms.Padding(2);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(171, 34);
            this.btnProgram.TabIndex = 5;
            this.btnProgram.Text = "PROGRAM";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnInterview
            // 
            this.btnInterview.FlatAppearance.BorderSize = 0;
            this.btnInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterview.ForeColor = System.Drawing.Color.White;
            this.btnInterview.Location = new System.Drawing.Point(2, 289);
            this.btnInterview.Margin = new System.Windows.Forms.Padding(2);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(171, 34);
            this.btnInterview.TabIndex = 4;
            this.btnInterview.Text = "INTERVIEW";
            this.btnInterview.UseVisualStyleBackColor = true;
            this.btnInterview.Click += new System.EventHandler(this.btnInterview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecommendationSystem.Properties.Resources.earist;
            this.pictureBox1.Location = new System.Drawing.Point(22, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(2, 253);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(171, 34);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "USER MANAGEMENT";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(2, 217);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmManageProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtProgramname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdateProgram);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProgramname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdateProgram;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRecommendation;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnHome;
    }
}

