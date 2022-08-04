
namespace LibraryManagementSystem
{
    partial class ReturnBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooksForm));
            this.btnExitReturnBooksForm = new System.Windows.Forms.Button();
            this.btnRefreshReturnBooksForm = new System.Windows.Forms.Button();
            this.btnSearchStudentReturnBooksForm = new System.Windows.Forms.Button();
            this.txtStudentIdReturnBooksForm = new System.Windows.Forms.TextBox();
            this.lblStudentIdReturnBooksForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvReturnBooksForm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookIssueDateReturnForm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturnBooksForm = new System.Windows.Forms.Button();
            this.dtpBookReturnDateReturnBooksForm = new System.Windows.Forms.DateTimePicker();
            this.lblBookReturnDateReturnBooksForm = new System.Windows.Forms.Label();
            this.txtBooksNameReturnBooksForm = new System.Windows.Forms.TextBox();
            this.lblBookReturnBooksForm = new System.Windows.Forms.Label();
            this.lblBookNameReturnBooksForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitReturnBooksForm
            // 
            this.btnExitReturnBooksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExitReturnBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitReturnBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitReturnBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitReturnBooksForm.Location = new System.Drawing.Point(174, 293);
            this.btnExitReturnBooksForm.Name = "btnExitReturnBooksForm";
            this.btnExitReturnBooksForm.Size = new System.Drawing.Size(72, 33);
            this.btnExitReturnBooksForm.TabIndex = 4;
            this.btnExitReturnBooksForm.Text = "Exit";
            this.btnExitReturnBooksForm.UseVisualStyleBackColor = false;
            this.btnExitReturnBooksForm.Click += new System.EventHandler(this.btnExitReturnBooksForm_Click);
            // 
            // btnRefreshReturnBooksForm
            // 
            this.btnRefreshReturnBooksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefreshReturnBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshReturnBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshReturnBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshReturnBooksForm.Location = new System.Drawing.Point(36, 293);
            this.btnRefreshReturnBooksForm.Name = "btnRefreshReturnBooksForm";
            this.btnRefreshReturnBooksForm.Size = new System.Drawing.Size(72, 33);
            this.btnRefreshReturnBooksForm.TabIndex = 3;
            this.btnRefreshReturnBooksForm.Text = "Refresh";
            this.btnRefreshReturnBooksForm.UseVisualStyleBackColor = false;
            this.btnRefreshReturnBooksForm.Click += new System.EventHandler(this.btnRefreshReturnBooksForm_Click);
            // 
            // btnSearchStudentReturnBooksForm
            // 
            this.btnSearchStudentReturnBooksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearchStudentReturnBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudentReturnBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStudentReturnBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentReturnBooksForm.Location = new System.Drawing.Point(91, 223);
            this.btnSearchStudentReturnBooksForm.Name = "btnSearchStudentReturnBooksForm";
            this.btnSearchStudentReturnBooksForm.Size = new System.Drawing.Size(93, 40);
            this.btnSearchStudentReturnBooksForm.TabIndex = 2;
            this.btnSearchStudentReturnBooksForm.Text = "Search Student";
            this.btnSearchStudentReturnBooksForm.UseVisualStyleBackColor = false;
            this.btnSearchStudentReturnBooksForm.Click += new System.EventHandler(this.btnSearchStudentReturnBooksForm_Click);
            // 
            // txtStudentIdReturnBooksForm
            // 
            this.txtStudentIdReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentIdReturnBooksForm.Location = new System.Drawing.Point(91, 161);
            this.txtStudentIdReturnBooksForm.Multiline = true;
            this.txtStudentIdReturnBooksForm.Name = "txtStudentIdReturnBooksForm";
            this.txtStudentIdReturnBooksForm.Size = new System.Drawing.Size(155, 20);
            this.txtStudentIdReturnBooksForm.TabIndex = 2;
            this.txtStudentIdReturnBooksForm.TextChanged += new System.EventHandler(this.txtStudentIdReturnBooksForm_TextChanged);
            // 
            // lblStudentIdReturnBooksForm
            // 
            this.lblStudentIdReturnBooksForm.AutoSize = true;
            this.lblStudentIdReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentIdReturnBooksForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIdReturnBooksForm.Location = new System.Drawing.Point(12, 160);
            this.lblStudentIdReturnBooksForm.Name = "lblStudentIdReturnBooksForm";
            this.lblStudentIdReturnBooksForm.Size = new System.Drawing.Size(72, 18);
            this.lblStudentIdReturnBooksForm.TabIndex = 2;
            this.lblStudentIdReturnBooksForm.Text = "Student Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnExitReturnBooksForm);
            this.panel2.Controls.Add(this.btnRefreshReturnBooksForm);
            this.panel2.Controls.Add(this.btnSearchStudentReturnBooksForm);
            this.panel2.Controls.Add(this.txtStudentIdReturnBooksForm);
            this.panel2.Controls.Add(this.lblStudentIdReturnBooksForm);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 368);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // dgvReturnBooksForm
            // 
            this.dgvReturnBooksForm.BackgroundColor = System.Drawing.Color.Olive;
            this.dgvReturnBooksForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBooksForm.Location = new System.Drawing.Point(277, 12);
            this.dgvReturnBooksForm.Name = "dgvReturnBooksForm";
            this.dgvReturnBooksForm.RowHeadersWidth = 51;
            this.dgvReturnBooksForm.Size = new System.Drawing.Size(630, 368);
            this.dgvReturnBooksForm.TabIndex = 3;
            this.dgvReturnBooksForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBooksForm_CellClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBookIssueDateReturnForm);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnReturnBooksForm);
            this.panel1.Controls.Add(this.dtpBookReturnDateReturnBooksForm);
            this.panel1.Controls.Add(this.lblBookReturnDateReturnBooksForm);
            this.panel1.Controls.Add(this.txtBooksNameReturnBooksForm);
            this.panel1.Controls.Add(this.lblBookReturnBooksForm);
            this.panel1.Controls.Add(this.lblBookNameReturnBooksForm);
            this.panel1.Location = new System.Drawing.Point(12, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 195);
            this.panel1.TabIndex = 4;
            // 
            // txtBookIssueDateReturnForm
            // 
            this.txtBookIssueDateReturnForm.Location = new System.Drawing.Point(468, 63);
            this.txtBookIssueDateReturnForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookIssueDateReturnForm.Name = "txtBookIssueDateReturnForm";
            this.txtBookIssueDateReturnForm.Size = new System.Drawing.Size(192, 20);
            this.txtBookIssueDateReturnForm.TabIndex = 39;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(537, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 30);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturnBooksForm
            // 
            this.btnReturnBooksForm.BackColor = System.Drawing.Color.Peru;
            this.btnReturnBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooksForm.Location = new System.Drawing.Point(397, 156);
            this.btnReturnBooksForm.Name = "btnReturnBooksForm";
            this.btnReturnBooksForm.Size = new System.Drawing.Size(58, 30);
            this.btnReturnBooksForm.TabIndex = 37;
            this.btnReturnBooksForm.Text = "Return";
            this.btnReturnBooksForm.UseVisualStyleBackColor = false;
            this.btnReturnBooksForm.Click += new System.EventHandler(this.btnReturnBooksForm_Click);
            // 
            // dtpBookReturnDateReturnBooksForm
            // 
            this.dtpBookReturnDateReturnBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBookReturnDateReturnBooksForm.Location = new System.Drawing.Point(468, 108);
            this.dtpBookReturnDateReturnBooksForm.Name = "dtpBookReturnDateReturnBooksForm";
            this.dtpBookReturnDateReturnBooksForm.Size = new System.Drawing.Size(192, 20);
            this.dtpBookReturnDateReturnBooksForm.TabIndex = 36;
            // 
            // lblBookReturnDateReturnBooksForm
            // 
            this.lblBookReturnDateReturnBooksForm.AutoSize = true;
            this.lblBookReturnDateReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookReturnDateReturnBooksForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReturnDateReturnBooksForm.Location = new System.Drawing.Point(303, 108);
            this.lblBookReturnDateReturnBooksForm.Name = "lblBookReturnDateReturnBooksForm";
            this.lblBookReturnDateReturnBooksForm.Size = new System.Drawing.Size(116, 18);
            this.lblBookReturnDateReturnBooksForm.TabIndex = 35;
            this.lblBookReturnDateReturnBooksForm.Text = "Book Return Date";
            // 
            // txtBooksNameReturnBooksForm
            // 
            this.txtBooksNameReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBooksNameReturnBooksForm.Location = new System.Drawing.Point(468, 24);
            this.txtBooksNameReturnBooksForm.Multiline = true;
            this.txtBooksNameReturnBooksForm.Name = "txtBooksNameReturnBooksForm";
            this.txtBooksNameReturnBooksForm.Size = new System.Drawing.Size(192, 20);
            this.txtBooksNameReturnBooksForm.TabIndex = 33;
            // 
            // lblBookReturnBooksForm
            // 
            this.lblBookReturnBooksForm.AutoSize = true;
            this.lblBookReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookReturnBooksForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReturnBooksForm.Location = new System.Drawing.Point(303, 63);
            this.lblBookReturnBooksForm.Name = "lblBookReturnBooksForm";
            this.lblBookReturnBooksForm.Size = new System.Drawing.Size(106, 18);
            this.lblBookReturnBooksForm.TabIndex = 32;
            this.lblBookReturnBooksForm.Text = "Book Issue Date";
            // 
            // lblBookNameReturnBooksForm
            // 
            this.lblBookNameReturnBooksForm.AutoSize = true;
            this.lblBookNameReturnBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameReturnBooksForm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameReturnBooksForm.Location = new System.Drawing.Point(303, 24);
            this.lblBookNameReturnBooksForm.Name = "lblBookNameReturnBooksForm";
            this.lblBookNameReturnBooksForm.Size = new System.Drawing.Size(79, 18);
            this.lblBookNameReturnBooksForm.TabIndex = 31;
            this.lblBookNameReturnBooksForm.Text = "Book Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(924, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReturnBooksForm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBooksForm";
            this.Load += new System.EventHandler(this.ReturnBooksForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitReturnBooksForm;
        private System.Windows.Forms.Button btnRefreshReturnBooksForm;
        private System.Windows.Forms.Button btnSearchStudentReturnBooksForm;
        private System.Windows.Forms.TextBox txtStudentIdReturnBooksForm;
        private System.Windows.Forms.Label lblStudentIdReturnBooksForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReturnBooksForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBooksNameReturnBooksForm;
        private System.Windows.Forms.Label lblBookReturnBooksForm;
        private System.Windows.Forms.Label lblBookNameReturnBooksForm;
        private System.Windows.Forms.DateTimePicker dtpBookReturnDateReturnBooksForm;
        private System.Windows.Forms.Label lblBookReturnDateReturnBooksForm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturnBooksForm;
        private System.Windows.Forms.TextBox txtBookIssueDateReturnForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}