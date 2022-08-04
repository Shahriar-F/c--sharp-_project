
namespace LibraryManagementSystem
{
    partial class StudentProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfileForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseStudentProfileForm = new System.Windows.Forms.Button();
            this.txtDepartmentStudentProfileForm = new System.Windows.Forms.TextBox();
            this.txtSemesterNoStudentProfileForm = new System.Windows.Forms.TextBox();
            this.txtIDStudentProfileForm = new System.Windows.Forms.TextBox();
            this.txtNameStudentProfileForm = new System.Windows.Forms.TextBox();
            this.lblDepartmentStudentProfileFormForm = new System.Windows.Forms.Label();
            this.lblSemesterNoStudentProfileFormForm = new System.Windows.Forms.Label();
            this.lblIDStudentProfileFormForm = new System.Windows.Forms.Label();
            this.lblNameStudentProfileForm = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 162);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Profile Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseStudentProfileForm
            // 
            this.btnCloseStudentProfileForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseStudentProfileForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseStudentProfileForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStudentProfileForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseStudentProfileForm.Location = new System.Drawing.Point(413, 525);
            this.btnCloseStudentProfileForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseStudentProfileForm.Name = "btnCloseStudentProfileForm";
            this.btnCloseStudentProfileForm.Size = new System.Drawing.Size(84, 46);
            this.btnCloseStudentProfileForm.TabIndex = 19;
            this.btnCloseStudentProfileForm.Text = "Close";
            this.btnCloseStudentProfileForm.UseVisualStyleBackColor = false;
            this.btnCloseStudentProfileForm.Click += new System.EventHandler(this.btnCloseStudentProfileForm_Click);
            // 
            // txtDepartmentStudentProfileForm
            // 
            this.txtDepartmentStudentProfileForm.Location = new System.Drawing.Point(276, 443);
            this.txtDepartmentStudentProfileForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentStudentProfileForm.Multiline = true;
            this.txtDepartmentStudentProfileForm.Name = "txtDepartmentStudentProfileForm";
            this.txtDepartmentStudentProfileForm.ReadOnly = true;
            this.txtDepartmentStudentProfileForm.Size = new System.Drawing.Size(221, 26);
            this.txtDepartmentStudentProfileForm.TabIndex = 18;
            // 
            // txtSemesterNoStudentProfileForm
            // 
            this.txtSemesterNoStudentProfileForm.Location = new System.Drawing.Point(276, 378);
            this.txtSemesterNoStudentProfileForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemesterNoStudentProfileForm.Multiline = true;
            this.txtSemesterNoStudentProfileForm.Name = "txtSemesterNoStudentProfileForm";
            this.txtSemesterNoStudentProfileForm.ReadOnly = true;
            this.txtSemesterNoStudentProfileForm.Size = new System.Drawing.Size(221, 26);
            this.txtSemesterNoStudentProfileForm.TabIndex = 17;
            // 
            // txtIDStudentProfileForm
            // 
            this.txtIDStudentProfileForm.Location = new System.Drawing.Point(276, 316);
            this.txtIDStudentProfileForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDStudentProfileForm.Multiline = true;
            this.txtIDStudentProfileForm.Name = "txtIDStudentProfileForm";
            this.txtIDStudentProfileForm.ReadOnly = true;
            this.txtIDStudentProfileForm.Size = new System.Drawing.Size(221, 26);
            this.txtIDStudentProfileForm.TabIndex = 16;
            // 
            // txtNameStudentProfileForm
            // 
            this.txtNameStudentProfileForm.Location = new System.Drawing.Point(276, 256);
            this.txtNameStudentProfileForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameStudentProfileForm.Multiline = true;
            this.txtNameStudentProfileForm.Name = "txtNameStudentProfileForm";
            this.txtNameStudentProfileForm.ReadOnly = true;
            this.txtNameStudentProfileForm.Size = new System.Drawing.Size(221, 26);
            this.txtNameStudentProfileForm.TabIndex = 15;
            // 
            // lblDepartmentStudentProfileFormForm
            // 
            this.lblDepartmentStudentProfileFormForm.AutoSize = true;
            this.lblDepartmentStudentProfileFormForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentStudentProfileFormForm.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentStudentProfileFormForm.Location = new System.Drawing.Point(155, 434);
            this.lblDepartmentStudentProfileFormForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentStudentProfileFormForm.Name = "lblDepartmentStudentProfileFormForm";
            this.lblDepartmentStudentProfileFormForm.Size = new System.Drawing.Size(102, 18);
            this.lblDepartmentStudentProfileFormForm.TabIndex = 14;
            this.lblDepartmentStudentProfileFormForm.Text = "Department     :";
            // 
            // lblSemesterNoStudentProfileFormForm
            // 
            this.lblSemesterNoStudentProfileFormForm.AutoSize = true;
            this.lblSemesterNoStudentProfileFormForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterNoStudentProfileFormForm.ForeColor = System.Drawing.Color.White;
            this.lblSemesterNoStudentProfileFormForm.Location = new System.Drawing.Point(158, 378);
            this.lblSemesterNoStudentProfileFormForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemesterNoStudentProfileFormForm.Name = "lblSemesterNoStudentProfileFormForm";
            this.lblSemesterNoStudentProfileFormForm.Size = new System.Drawing.Size(101, 18);
            this.lblSemesterNoStudentProfileFormForm.TabIndex = 13;
            this.lblSemesterNoStudentProfileFormForm.Text = "Semester No   :";
            // 
            // lblIDStudentProfileFormForm
            // 
            this.lblIDStudentProfileFormForm.AutoSize = true;
            this.lblIDStudentProfileFormForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDStudentProfileFormForm.ForeColor = System.Drawing.Color.White;
            this.lblIDStudentProfileFormForm.Location = new System.Drawing.Point(158, 316);
            this.lblIDStudentProfileFormForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDStudentProfileFormForm.Name = "lblIDStudentProfileFormForm";
            this.lblIDStudentProfileFormForm.Size = new System.Drawing.Size(88, 18);
            this.lblIDStudentProfileFormForm.TabIndex = 12;
            this.lblIDStudentProfileFormForm.Text = "ID                     :";
            // 
            // lblNameStudentProfileForm
            // 
            this.lblNameStudentProfileForm.AutoSize = true;
            this.lblNameStudentProfileForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStudentProfileForm.ForeColor = System.Drawing.Color.White;
            this.lblNameStudentProfileForm.Location = new System.Drawing.Point(158, 259);
            this.lblNameStudentProfileForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameStudentProfileForm.Name = "lblNameStudentProfileForm";
            this.lblNameStudentProfileForm.Size = new System.Drawing.Size(91, 18);
            this.lblNameStudentProfileForm.TabIndex = 11;
            this.lblNameStudentProfileForm.Text = "Name              :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // StudentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(585, 584);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseStudentProfileForm);
            this.Controls.Add(this.txtDepartmentStudentProfileForm);
            this.Controls.Add(this.txtSemesterNoStudentProfileForm);
            this.Controls.Add(this.txtIDStudentProfileForm);
            this.Controls.Add(this.txtNameStudentProfileForm);
            this.Controls.Add(this.lblDepartmentStudentProfileFormForm);
            this.Controls.Add(this.lblSemesterNoStudentProfileFormForm);
            this.Controls.Add(this.lblIDStudentProfileFormForm);
            this.Controls.Add(this.lblNameStudentProfileForm);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile Form";
            this.Load += new System.EventHandler(this.StudentProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseStudentProfileForm;
        private System.Windows.Forms.TextBox txtDepartmentStudentProfileForm;
        private System.Windows.Forms.TextBox txtSemesterNoStudentProfileForm;
        private System.Windows.Forms.TextBox txtIDStudentProfileForm;
        private System.Windows.Forms.TextBox txtNameStudentProfileForm;
        private System.Windows.Forms.Label lblDepartmentStudentProfileFormForm;
        private System.Windows.Forms.Label lblSemesterNoStudentProfileFormForm;
        private System.Windows.Forms.Label lblIDStudentProfileFormForm;
        private System.Windows.Forms.Label lblNameStudentProfileForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}