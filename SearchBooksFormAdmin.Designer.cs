
namespace LibraryManagementSystem
{
    partial class SearchBooksFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBooksFormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSearchBooks = new System.Windows.Forms.DataGridView();
            this.lblBookNameSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookAuthorNameSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPublicationSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPurchasedDateSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPriceSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookQuantitySearchBooksForm = new System.Windows.Forms.Label();
            this.txtBookNameSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookAuthorNameSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookPublicationSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookPriceSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookQuantitySearchBooksForm = new System.Windows.Forms.TextBox();
            this.dtpBookPurchasedDateSearchBooksForm = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateSearchBooksForm = new System.Windows.Forms.Button();
            this.btnDeleteSearchBooksForm = new System.Windows.Forms.Button();
            this.btnCancelSearchBooksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshSearchBook = new System.Windows.Forms.Button();
            this.txtBookNameTopSearchBook = new System.Windows.Forms.TextBox();
            this.lblBookNameTopSearchBooks = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(919, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSearchBooks
            // 
            this.dgvSearchBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSearchBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBooks.Location = new System.Drawing.Point(18, 167);
            this.dgvSearchBooks.Name = "dgvSearchBooks";
            this.dgvSearchBooks.RowHeadersWidth = 51;
            this.dgvSearchBooks.Size = new System.Drawing.Size(937, 311);
            this.dgvSearchBooks.TabIndex = 4;
            this.dgvSearchBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblBookNameSearchBooksForm
            // 
            this.lblBookNameSearchBooksForm.AutoSize = true;
            this.lblBookNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameSearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameSearchBooksForm.Location = new System.Drawing.Point(52, 49);
            this.lblBookNameSearchBooksForm.Name = "lblBookNameSearchBooksForm";
            this.lblBookNameSearchBooksForm.Size = new System.Drawing.Size(88, 19);
            this.lblBookNameSearchBooksForm.TabIndex = 0;
            this.lblBookNameSearchBooksForm.Text = "Book Name";
            // 
            // lblBookAuthorNameSearchBooksForm
            // 
            this.lblBookAuthorNameSearchBooksForm.AutoSize = true;
            this.lblBookAuthorNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookAuthorNameSearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorNameSearchBooksForm.Location = new System.Drawing.Point(52, 100);
            this.lblBookAuthorNameSearchBooksForm.Name = "lblBookAuthorNameSearchBooksForm";
            this.lblBookAuthorNameSearchBooksForm.Size = new System.Drawing.Size(141, 19);
            this.lblBookAuthorNameSearchBooksForm.TabIndex = 1;
            this.lblBookAuthorNameSearchBooksForm.Text = "Book Author Name";
            // 
            // lblBookPublicationSearchBooksForm
            // 
            this.lblBookPublicationSearchBooksForm.AutoSize = true;
            this.lblBookPublicationSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPublicationSearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublicationSearchBooksForm.Location = new System.Drawing.Point(52, 148);
            this.lblBookPublicationSearchBooksForm.Name = "lblBookPublicationSearchBooksForm";
            this.lblBookPublicationSearchBooksForm.Size = new System.Drawing.Size(125, 19);
            this.lblBookPublicationSearchBooksForm.TabIndex = 2;
            this.lblBookPublicationSearchBooksForm.Text = "Book Publication";
            // 
            // lblBookPurchasedDateSearchBooksForm
            // 
            this.lblBookPurchasedDateSearchBooksForm.AutoSize = true;
            this.lblBookPurchasedDateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPurchasedDateSearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPurchasedDateSearchBooksForm.Location = new System.Drawing.Point(488, 49);
            this.lblBookPurchasedDateSearchBooksForm.Name = "lblBookPurchasedDateSearchBooksForm";
            this.lblBookPurchasedDateSearchBooksForm.Size = new System.Drawing.Size(155, 19);
            this.lblBookPurchasedDateSearchBooksForm.TabIndex = 3;
            this.lblBookPurchasedDateSearchBooksForm.Text = "Book Purchased Date";
            // 
            // lblBookPriceSearchBooksForm
            // 
            this.lblBookPriceSearchBooksForm.AutoSize = true;
            this.lblBookPriceSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPriceSearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPriceSearchBooksForm.Location = new System.Drawing.Point(488, 100);
            this.lblBookPriceSearchBooksForm.Name = "lblBookPriceSearchBooksForm";
            this.lblBookPriceSearchBooksForm.Size = new System.Drawing.Size(82, 19);
            this.lblBookPriceSearchBooksForm.TabIndex = 4;
            this.lblBookPriceSearchBooksForm.Text = "Book Price";
            // 
            // lblBookQuantitySearchBooksForm
            // 
            this.lblBookQuantitySearchBooksForm.AutoSize = true;
            this.lblBookQuantitySearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookQuantitySearchBooksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookQuantitySearchBooksForm.Location = new System.Drawing.Point(488, 148);
            this.lblBookQuantitySearchBooksForm.Name = "lblBookQuantitySearchBooksForm";
            this.lblBookQuantitySearchBooksForm.Size = new System.Drawing.Size(108, 19);
            this.lblBookQuantitySearchBooksForm.TabIndex = 5;
            this.lblBookQuantitySearchBooksForm.Text = "Book Quantity";
            // 
            // txtBookNameSearchBooksForm
            // 
            this.txtBookNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookNameSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNameSearchBooksForm.Location = new System.Drawing.Point(227, 49);
            this.txtBookNameSearchBooksForm.Multiline = true;
            this.txtBookNameSearchBooksForm.Name = "txtBookNameSearchBooksForm";
            this.txtBookNameSearchBooksForm.Size = new System.Drawing.Size(180, 20);
            this.txtBookNameSearchBooksForm.TabIndex = 6;
            // 
            // txtBookAuthorNameSearchBooksForm
            // 
            this.txtBookAuthorNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAuthorNameSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthorNameSearchBooksForm.Location = new System.Drawing.Point(227, 100);
            this.txtBookAuthorNameSearchBooksForm.Multiline = true;
            this.txtBookAuthorNameSearchBooksForm.Name = "txtBookAuthorNameSearchBooksForm";
            this.txtBookAuthorNameSearchBooksForm.Size = new System.Drawing.Size(180, 20);
            this.txtBookAuthorNameSearchBooksForm.TabIndex = 7;
            // 
            // txtBookPublicationSearchBooksForm
            // 
            this.txtBookPublicationSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPublicationSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublicationSearchBooksForm.Location = new System.Drawing.Point(227, 148);
            this.txtBookPublicationSearchBooksForm.Multiline = true;
            this.txtBookPublicationSearchBooksForm.Name = "txtBookPublicationSearchBooksForm";
            this.txtBookPublicationSearchBooksForm.Size = new System.Drawing.Size(180, 20);
            this.txtBookPublicationSearchBooksForm.TabIndex = 8;
            // 
            // txtBookPriceSearchBooksForm
            // 
            this.txtBookPriceSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPriceSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPriceSearchBooksForm.Location = new System.Drawing.Point(697, 102);
            this.txtBookPriceSearchBooksForm.Multiline = true;
            this.txtBookPriceSearchBooksForm.Name = "txtBookPriceSearchBooksForm";
            this.txtBookPriceSearchBooksForm.Size = new System.Drawing.Size(180, 20);
            this.txtBookPriceSearchBooksForm.TabIndex = 9;
            // 
            // txtBookQuantitySearchBooksForm
            // 
            this.txtBookQuantitySearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookQuantitySearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookQuantitySearchBooksForm.Location = new System.Drawing.Point(697, 150);
            this.txtBookQuantitySearchBooksForm.Multiline = true;
            this.txtBookQuantitySearchBooksForm.Name = "txtBookQuantitySearchBooksForm";
            this.txtBookQuantitySearchBooksForm.Size = new System.Drawing.Size(180, 20);
            this.txtBookQuantitySearchBooksForm.TabIndex = 10;
            // 
            // dtpBookPurchasedDateSearchBooksForm
            // 
            this.dtpBookPurchasedDateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBookPurchasedDateSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookPurchasedDateSearchBooksForm.Location = new System.Drawing.Point(697, 48);
            this.dtpBookPurchasedDateSearchBooksForm.Name = "dtpBookPurchasedDateSearchBooksForm";
            this.dtpBookPurchasedDateSearchBooksForm.Size = new System.Drawing.Size(180, 23);
            this.dtpBookPurchasedDateSearchBooksForm.TabIndex = 11;
            // 
            // btnUpdateSearchBooksForm
            // 
            this.btnUpdateSearchBooksForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSearchBooksForm.Location = new System.Drawing.Point(339, 217);
            this.btnUpdateSearchBooksForm.Name = "btnUpdateSearchBooksForm";
            this.btnUpdateSearchBooksForm.Size = new System.Drawing.Size(59, 23);
            this.btnUpdateSearchBooksForm.TabIndex = 12;
            this.btnUpdateSearchBooksForm.Text = "Update";
            this.btnUpdateSearchBooksForm.UseVisualStyleBackColor = false;
            this.btnUpdateSearchBooksForm.Click += new System.EventHandler(this.btnUpdateSearchBooksForm_Click);
            // 
            // btnDeleteSearchBooksForm
            // 
            this.btnDeleteSearchBooksForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSearchBooksForm.Location = new System.Drawing.Point(461, 217);
            this.btnDeleteSearchBooksForm.Name = "btnDeleteSearchBooksForm";
            this.btnDeleteSearchBooksForm.Size = new System.Drawing.Size(59, 23);
            this.btnDeleteSearchBooksForm.TabIndex = 13;
            this.btnDeleteSearchBooksForm.Text = "Delete";
            this.btnDeleteSearchBooksForm.UseVisualStyleBackColor = false;
            this.btnDeleteSearchBooksForm.Click += new System.EventHandler(this.btnDeleteSearchBooksForm_Click);
            // 
            // btnCancelSearchBooksForm
            // 
            this.btnCancelSearchBooksForm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSearchBooksForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearchBooksForm.Location = new System.Drawing.Point(587, 217);
            this.btnCancelSearchBooksForm.Name = "btnCancelSearchBooksForm";
            this.btnCancelSearchBooksForm.Size = new System.Drawing.Size(59, 23);
            this.btnCancelSearchBooksForm.TabIndex = 14;
            this.btnCancelSearchBooksForm.Text = "Cancel";
            this.btnCancelSearchBooksForm.UseVisualStyleBackColor = false;
            this.btnCancelSearchBooksForm.Click += new System.EventHandler(this.btnCancelSearchBooksForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.btnCancelSearchBooksForm);
            this.panel2.Controls.Add(this.btnDeleteSearchBooksForm);
            this.panel2.Controls.Add(this.btnUpdateSearchBooksForm);
            this.panel2.Controls.Add(this.dtpBookPurchasedDateSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookQuantitySearchBooksForm);
            this.panel2.Controls.Add(this.txtBookPriceSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookPublicationSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookAuthorNameSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookNameSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookQuantitySearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPriceSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPurchasedDateSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPublicationSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookAuthorNameSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookNameSearchBooksForm);
            this.panel2.Location = new System.Drawing.Point(18, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 252);
            this.panel2.TabIndex = 5;
            // 
            // btnRefreshSearchBook
            // 
            this.btnRefreshSearchBook.BackColor = System.Drawing.Color.LightGray;
            this.btnRefreshSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshSearchBook.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSearchBook.Location = new System.Drawing.Point(588, 125);
            this.btnRefreshSearchBook.Name = "btnRefreshSearchBook";
            this.btnRefreshSearchBook.Size = new System.Drawing.Size(60, 23);
            this.btnRefreshSearchBook.TabIndex = 8;
            this.btnRefreshSearchBook.Text = "Refresh";
            this.btnRefreshSearchBook.UseVisualStyleBackColor = false;
            this.btnRefreshSearchBook.Click += new System.EventHandler(this.btnRefreshSearchBook_Click);
            // 
            // txtBookNameTopSearchBook
            // 
            this.txtBookNameTopSearchBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookNameTopSearchBook.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNameTopSearchBook.Location = new System.Drawing.Point(406, 128);
            this.txtBookNameTopSearchBook.Multiline = true;
            this.txtBookNameTopSearchBook.Name = "txtBookNameTopSearchBook";
            this.txtBookNameTopSearchBook.Size = new System.Drawing.Size(150, 20);
            this.txtBookNameTopSearchBook.TabIndex = 7;
            this.txtBookNameTopSearchBook.TextChanged += new System.EventHandler(this.txtBookNameTopSearchBook_TextChanged);
            // 
            // lblBookNameTopSearchBooks
            // 
            this.lblBookNameTopSearchBooks.AutoSize = true;
            this.lblBookNameTopSearchBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameTopSearchBooks.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameTopSearchBooks.Location = new System.Drawing.Point(299, 128);
            this.lblBookNameTopSearchBooks.Name = "lblBookNameTopSearchBooks";
            this.lblBookNameTopSearchBooks.Size = new System.Drawing.Size(101, 23);
            this.lblBookNameTopSearchBooks.TabIndex = 6;
            this.lblBookNameTopSearchBooks.Text = "Book Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // SearchBooksFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRefreshSearchBook);
            this.Controls.Add(this.txtBookNameTopSearchBook);
            this.Controls.Add(this.lblBookNameTopSearchBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSearchBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchBooksFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBooksForm";
            this.Load += new System.EventHandler(this.SearchBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchBooks;
        private System.Windows.Forms.Label lblBookNameSearchBooksForm;
        private System.Windows.Forms.Label lblBookAuthorNameSearchBooksForm;
        private System.Windows.Forms.Label lblBookPublicationSearchBooksForm;
        private System.Windows.Forms.Label lblBookPurchasedDateSearchBooksForm;
        private System.Windows.Forms.Label lblBookPriceSearchBooksForm;
        private System.Windows.Forms.Label lblBookQuantitySearchBooksForm;
        private System.Windows.Forms.TextBox txtBookNameSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookAuthorNameSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookPublicationSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookPriceSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookQuantitySearchBooksForm;
        private System.Windows.Forms.DateTimePicker dtpBookPurchasedDateSearchBooksForm;
        private System.Windows.Forms.Button btnUpdateSearchBooksForm;
        private System.Windows.Forms.Button btnDeleteSearchBooksForm;
        private System.Windows.Forms.Button btnCancelSearchBooksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshSearchBook;
        private System.Windows.Forms.TextBox txtBookNameTopSearchBook;
        private System.Windows.Forms.Label lblBookNameTopSearchBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}