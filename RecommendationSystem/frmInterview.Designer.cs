namespace RecommendationSystem
{
    partial class frmInterview
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
            this.dgvInterview = new System.Windows.Forms.DataGridView();
            this.btnAddInterview = new System.Windows.Forms.Button();
            this.txtQuestion2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResidentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInterview
            // 
            this.dgvInterview.AllowUserToAddRows = false;
            this.dgvInterview.AllowUserToDeleteRows = false;
            this.dgvInterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterview.Location = new System.Drawing.Point(249, 69);
            this.dgvInterview.Name = "dgvInterview";
            this.dgvInterview.ReadOnly = true;
            this.dgvInterview.Size = new System.Drawing.Size(870, 235);
            this.dgvInterview.TabIndex = 101;
            this.dgvInterview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInterview_CellContentClick);
            this.dgvInterview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInterview_CellContentDoubleClick);
            // 
            // btnAddInterview
            // 
            this.btnAddInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInterview.Location = new System.Drawing.Point(496, 558);
            this.btnAddInterview.Name = "btnAddInterview";
            this.btnAddInterview.Size = new System.Drawing.Size(140, 39);
            this.btnAddInterview.TabIndex = 100;
            this.btnAddInterview.Text = "ENTER";
            this.btnAddInterview.UseVisualStyleBackColor = true;
            this.btnAddInterview.Click += new System.EventHandler(this.btnAddInterview_Click);
            // 
            // txtQuestion2
            // 
            this.txtQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion2.Location = new System.Drawing.Point(773, 499);
            this.txtQuestion2.Multiline = true;
            this.txtQuestion2.Name = "txtQuestion2";
            this.txtQuestion2.Size = new System.Drawing.Size(87, 34);
            this.txtQuestion2.TabIndex = 99;
            this.txtQuestion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 49);
            this.label4.TabIndex = 98;
            this.label4.Text = "How many will be interested to benefited in the selected program?";
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion1.Location = new System.Drawing.Point(773, 438);
            this.txtQuestion1.Multiline = true;
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.Size = new System.Drawing.Size(87, 35);
            this.txtQuestion1.TabIndex = 97;
            this.txtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 45);
            this.label3.TabIndex = 96;
            this.label3.Text = "How many will be benefited in the selected program?";
            // 
            // cbProgram
            // 
            this.cbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(549, 384);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(364, 32);
            this.cbProgram.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Select Program:";
            // 
            // txtResidentName
            // 
            this.txtResidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentName.Location = new System.Drawing.Point(549, 325);
            this.txtResidentName.Multiline = true;
            this.txtResidentName.Name = "txtResidentName";
            this.txtResidentName.Size = new System.Drawing.Size(364, 35);
            this.txtResidentName.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Resident Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(211, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 25);
            this.label16.TabIndex = 91;
            this.label16.Text = "INTERVIEW";
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
            this.panel1.TabIndex = 102;
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
            this.btnProgram.FlatAppearance.BorderSize = 0;
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
            this.btnInterview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInterview.FlatAppearance.BorderSize = 3;
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
            this.btnInterview.Click += new System.EventHandler(this.frmInterview_Load);
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(655, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 39);
            this.btnUpdate.TabIndex = 103;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 681);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInterview);
            this.Controls.Add(this.btnAddInterview);
            this.Controls.Add(this.txtQuestion2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResidentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInterview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview";
            this.Load += new System.EventHandler(this.frmInterview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInterview;
        private System.Windows.Forms.Button btnAddInterview;
        private System.Windows.Forms.TextBox txtQuestion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResidentName;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnUpdate;
    }
}