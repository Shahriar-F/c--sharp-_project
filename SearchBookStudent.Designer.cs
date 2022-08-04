
namespace LibraryManagementSystem
{
    partial class SearchBookStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSearchBooksForStudent = new System.Windows.Forms.DataGridView();
            this.btnRefreshSearchBookForStudent = new System.Windows.Forms.Button();
            this.txtBookNameTopSearchBookForStudent = new System.Windows.Forms.TextBox();
            this.lblBookNameTopSearchBooksForStudent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooksForStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 114);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(943, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(812, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSearchBooksForStudent
            // 
            this.dgvSearchBooksForStudent.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSearchBooksForStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBooksForStudent.Location = new System.Drawing.Point(2, 166);
            this.dgvSearchBooksForStudent.Name = "dgvSearchBooksForStudent";
            this.dgvSearchBooksForStudent.RowHeadersWidth = 51;
            this.dgvSearchBooksForStudent.Size = new System.Drawing.Size(1001, 344);
            this.dgvSearchBooksForStudent.TabIndex = 16;
            this.dgvSearchBooksForStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchBooksForStudent_CellContentClick);
            // 
            // btnRefreshSearchBookForStudent
            // 
            this.btnRefreshSearchBookForStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefreshSearchBookForStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSearchBookForStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshSearchBookForStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSearchBookForStudent.Location = new System.Drawing.Point(541, 125);
            this.btnRefreshSearchBookForStudent.Name = "btnRefreshSearchBookForStudent";
            this.btnRefreshSearchBookForStudent.Size = new System.Drawing.Size(76, 23);
            this.btnRefreshSearchBookForStudent.TabIndex = 15;
            this.btnRefreshSearchBookForStudent.Text = "Refresh";
            this.btnRefreshSearchBookForStudent.UseVisualStyleBackColor = false;
            this.btnRefreshSearchBookForStudent.Click += new System.EventHandler(this.btnRefreshSearchBookForStudent_Click);
            // 
            // txtBookNameTopSearchBookForStudent
            // 
            this.txtBookNameTopSearchBookForStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookNameTopSearchBookForStudent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNameTopSearchBookForStudent.Location = new System.Drawing.Point(374, 128);
            this.txtBookNameTopSearchBookForStudent.Multiline = true;
            this.txtBookNameTopSearchBookForStudent.Name = "txtBookNameTopSearchBookForStudent";
            this.txtBookNameTopSearchBookForStudent.Size = new System.Drawing.Size(150, 20);
            this.txtBookNameTopSearchBookForStudent.TabIndex = 14;
            this.txtBookNameTopSearchBookForStudent.TextChanged += new System.EventHandler(this.txtBookNameTopSearchBookForStudent_TextChanged);
            // 
            // lblBookNameTopSearchBooksForStudent
            // 
            this.lblBookNameTopSearchBooksForStudent.AutoSize = true;
            this.lblBookNameTopSearchBooksForStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameTopSearchBooksForStudent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameTopSearchBooksForStudent.Location = new System.Drawing.Point(268, 128);
            this.lblBookNameTopSearchBooksForStudent.Name = "lblBookNameTopSearchBooksForStudent";
            this.lblBookNameTopSearchBooksForStudent.Size = new System.Drawing.Size(101, 23);
            this.lblBookNameTopSearchBooksForStudent.TabIndex = 13;
            this.lblBookNameTopSearchBooksForStudent.Text = "Book Name";
            // 
            // SearchBookStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(975, 513);
            this.Controls.Add(this.dgvSearchBooksForStudent);
            this.Controls.Add(this.btnRefreshSearchBookForStudent);
            this.Controls.Add(this.txtBookNameTopSearchBookForStudent);
            this.Controls.Add(this.lblBookNameTopSearchBooksForStudent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchBookStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBook";
            this.Load += new System.EventHandler(this.SearchBookStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooksForStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSearchBooksForStudent;
        private System.Windows.Forms.Button btnRefreshSearchBookForStudent;
        private System.Windows.Forms.TextBox txtBookNameTopSearchBookForStudent;
        private System.Windows.Forms.Label lblBookNameTopSearchBooksForStudent;
        private System.Windows.Forms.Button button1;
    }
}