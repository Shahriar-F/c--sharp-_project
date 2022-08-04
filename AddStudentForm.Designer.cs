
namespace LibraryManagementSystem
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.lblStudentSemester = new System.Windows.Forms.Label();
            this.lblStudentMobileNumber = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentSemester = new System.Windows.Forms.TextBox();
            this.txtStudentMobileNumber = new System.Windows.Forms.TextBox();
            this.btnRefreshAddStudentForm = new System.Windows.Forms.Button();
            this.btnSaveAddStudentForm = new System.Windows.Forms.Button();
            this.btnCloseStudentForm = new System.Windows.Forms.Button();
            this.txtstdUsernameAdminForm = new System.Windows.Forms.TextBox();
            this.lblStudentUsername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.lblAddStudent);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 75);
            this.panel1.TabIndex = 0;
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAddStudent.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.Location = new System.Drawing.Point(72, 18);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(152, 33);
            this.lblAddStudent.TabIndex = 1;
            this.lblAddStudent.Text = "Add Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(133, 88);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(108, 19);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(133, 127);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(82, 19);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Student ID";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(133, 210);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(105, 19);
            this.lblStudentEmail.TabIndex = 3;
            this.lblStudentEmail.Text = "Student Email";
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartment.Location = new System.Drawing.Point(133, 243);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(151, 19);
            this.lblStudentDepartment.TabIndex = 4;
            this.lblStudentDepartment.Text = "Student Department";
            // 
            // lblStudentSemester
            // 
            this.lblStudentSemester.AutoSize = true;
            this.lblStudentSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSemester.Location = new System.Drawing.Point(133, 288);
            this.lblStudentSemester.Name = "lblStudentSemester";
            this.lblStudentSemester.Size = new System.Drawing.Size(131, 19);
            this.lblStudentSemester.TabIndex = 5;
            this.lblStudentSemester.Text = "Student Semester";
            // 
            // lblStudentMobileNumber
            // 
            this.lblStudentMobileNumber.AutoSize = true;
            this.lblStudentMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentMobileNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMobileNumber.Location = new System.Drawing.Point(133, 326);
            this.lblStudentMobileNumber.Name = "lblStudentMobileNumber";
            this.lblStudentMobileNumber.Size = new System.Drawing.Size(176, 19);
            this.lblStudentMobileNumber.TabIndex = 6;
            this.lblStudentMobileNumber.Text = "Student Mobile Number";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(316, 87);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(192, 20);
            this.txtStudentName.TabIndex = 7;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(316, 127);
            this.txtStudentId.Multiline = true;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(192, 20);
            this.txtStudentId.TabIndex = 8;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(316, 209);
            this.txtStudentEmail.Multiline = true;
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(192, 20);
            this.txtStudentEmail.TabIndex = 9;
            // 
            // txtStudentDepartment
            // 
            this.txtStudentDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentDepartment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentDepartment.Location = new System.Drawing.Point(316, 244);
            this.txtStudentDepartment.Multiline = true;
            this.txtStudentDepartment.Name = "txtStudentDepartment";
            this.txtStudentDepartment.Size = new System.Drawing.Size(192, 20);
            this.txtStudentDepartment.TabIndex = 10;
            // 
            // txtStudentSemester
            // 
            this.txtStudentSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentSemester.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSemester.Location = new System.Drawing.Point(316, 287);
            this.txtStudentSemester.Multiline = true;
            this.txtStudentSemester.Name = "txtStudentSemester";
            this.txtStudentSemester.Size = new System.Drawing.Size(192, 20);
            this.txtStudentSemester.TabIndex = 11;
            // 
            // txtStudentMobileNumber
            // 
            this.txtStudentMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentMobileNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentMobileNumber.Location = new System.Drawing.Point(316, 326);
            this.txtStudentMobileNumber.Multiline = true;
            this.txtStudentMobileNumber.Name = "txtStudentMobileNumber";
            this.txtStudentMobileNumber.Size = new System.Drawing.Size(192, 20);
            this.txtStudentMobileNumber.TabIndex = 12;
            // 
            // btnRefreshAddStudentForm
            // 
            this.btnRefreshAddStudentForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshAddStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshAddStudentForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAddStudentForm.Location = new System.Drawing.Point(209, 376);
            this.btnRefreshAddStudentForm.Name = "btnRefreshAddStudentForm";
            this.btnRefreshAddStudentForm.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAddStudentForm.TabIndex = 13;
            this.btnRefreshAddStudentForm.Text = "Refresh";
            this.btnRefreshAddStudentForm.UseVisualStyleBackColor = true;
            this.btnRefreshAddStudentForm.Click += new System.EventHandler(this.btnRefreshAddStudentForm_Click);
            // 
            // btnSaveAddStudentForm
            // 
            this.btnSaveAddStudentForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAddStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAddStudentForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddStudentForm.Location = new System.Drawing.Point(316, 376);
            this.btnSaveAddStudentForm.Name = "btnSaveAddStudentForm";
            this.btnSaveAddStudentForm.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddStudentForm.TabIndex = 14;
            this.btnSaveAddStudentForm.Text = "Save";
            this.btnSaveAddStudentForm.UseVisualStyleBackColor = true;
            this.btnSaveAddStudentForm.Click += new System.EventHandler(this.btnSaveAddStudentForm_Click);
            // 
            // btnCloseStudentForm
            // 
            this.btnCloseStudentForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseStudentForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStudentForm.Location = new System.Drawing.Point(414, 376);
            this.btnCloseStudentForm.Name = "btnCloseStudentForm";
            this.btnCloseStudentForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseStudentForm.TabIndex = 15;
            this.btnCloseStudentForm.Text = "Close";
            this.btnCloseStudentForm.UseVisualStyleBackColor = true;
            this.btnCloseStudentForm.Click += new System.EventHandler(this.btnCloseStudentForm_Click);
            // 
            // txtstdUsernameAdminForm
            // 
            this.txtstdUsernameAdminForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstdUsernameAdminForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdUsernameAdminForm.Location = new System.Drawing.Point(316, 165);
            this.txtstdUsernameAdminForm.Multiline = true;
            this.txtstdUsernameAdminForm.Name = "txtstdUsernameAdminForm";
            this.txtstdUsernameAdminForm.Size = new System.Drawing.Size(192, 20);
            this.txtstdUsernameAdminForm.TabIndex = 17;
            // 
            // lblStudentUsername
            // 
            this.lblStudentUsername.AutoSize = true;
            this.lblStudentUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentUsername.Location = new System.Drawing.Point(133, 166);
            this.lblStudentUsername.Name = "lblStudentUsername";
            this.lblStudentUsername.Size = new System.Drawing.Size(136, 19);
            this.lblStudentUsername.TabIndex = 16;
            this.lblStudentUsername.Text = "Student Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(532, 428);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtstdUsernameAdminForm);
            this.Controls.Add(this.lblStudentUsername);
            this.Controls.Add(this.btnCloseStudentForm);
            this.Controls.Add(this.btnSaveAddStudentForm);
            this.Controls.Add(this.btnRefreshAddStudentForm);
            this.Controls.Add(this.txtStudentMobileNumber);
            this.Controls.Add(this.txtStudentSemester);
            this.Controls.Add(this.txtStudentDepartment);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentMobileNumber);
            this.Controls.Add(this.lblStudentSemester);
            this.Controls.Add(this.lblStudentDepartment);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label lblStudentSemester;
        private System.Windows.Forms.Label lblStudentMobileNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentDepartment;
        private System.Windows.Forms.TextBox txtStudentSemester;
        private System.Windows.Forms.TextBox txtStudentMobileNumber;
        private System.Windows.Forms.Button btnRefreshAddStudentForm;
        private System.Windows.Forms.Button btnSaveAddStudentForm;
        private System.Windows.Forms.Button btnCloseStudentForm;
        private System.Windows.Forms.TextBox txtstdUsernameAdminForm;
        private System.Windows.Forms.Label lblStudentUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}