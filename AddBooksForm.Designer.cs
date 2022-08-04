
namespace LibraryManagementSystem
{
    partial class AddBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddBooks = new System.Windows.Forms.Label();
            this.pictureBoxAddBooks = new System.Windows.Forms.PictureBox();
            this.lblBookAuthorName = new System.Windows.Forms.Label();
            this.lblBookPublication = new System.Windows.Forms.Label();
            this.lblBookPurchaseDate = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.txtBookAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.dtpBookPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnCancelAddBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.lblAddBooks);
            this.panel1.Controls.Add(this.pictureBoxAddBooks);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 91);
            this.panel1.TabIndex = 0;
            // 
            // lblAddBooks
            // 
            this.lblAddBooks.AutoSize = true;
            this.lblAddBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAddBooks.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooks.Location = new System.Drawing.Point(100, 19);
            this.lblAddBooks.Name = "lblAddBooks";
            this.lblAddBooks.Size = new System.Drawing.Size(146, 36);
            this.lblAddBooks.TabIndex = 1;
            this.lblAddBooks.Text = "Add Books";
            this.lblAddBooks.Click += new System.EventHandler(this.lblAddBooks_Click);
            // 
            // pictureBoxAddBooks
            // 
            this.pictureBoxAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddBooks.Image")));
            this.pictureBoxAddBooks.Location = new System.Drawing.Point(389, 0);
            this.pictureBoxAddBooks.Name = "pictureBoxAddBooks";
            this.pictureBoxAddBooks.Size = new System.Drawing.Size(111, 91);
            this.pictureBoxAddBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddBooks.TabIndex = 0;
            this.pictureBoxAddBooks.TabStop = false;
            // 
            // lblBookAuthorName
            // 
            this.lblBookAuthorName.AutoSize = true;
            this.lblBookAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookAuthorName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorName.Location = new System.Drawing.Point(121, 86);
            this.lblBookAuthorName.Name = "lblBookAuthorName";
            this.lblBookAuthorName.Size = new System.Drawing.Size(125, 18);
            this.lblBookAuthorName.TabIndex = 2;
            this.lblBookAuthorName.Text = "Book Author Name";
            // 
            // lblBookPublication
            // 
            this.lblBookPublication.AutoSize = true;
            this.lblBookPublication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPublication.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublication.Location = new System.Drawing.Point(121, 125);
            this.lblBookPublication.Name = "lblBookPublication";
            this.lblBookPublication.Size = new System.Drawing.Size(112, 18);
            this.lblBookPublication.TabIndex = 3;
            this.lblBookPublication.Text = "Book Publication";
            // 
            // lblBookPurchaseDate
            // 
            this.lblBookPurchaseDate.AutoSize = true;
            this.lblBookPurchaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookPurchaseDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPurchaseDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPurchaseDate.Location = new System.Drawing.Point(121, 162);
            this.lblBookPurchaseDate.Name = "lblBookPurchaseDate";
            this.lblBookPurchaseDate.Size = new System.Drawing.Size(130, 18);
            this.lblBookPurchaseDate.TabIndex = 4;
            this.lblBookPurchaseDate.Text = "Book Purchase Date";
            this.lblBookPurchaseDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.Location = new System.Drawing.Point(121, 208);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(73, 18);
            this.lblBookPrice.TabIndex = 5;
            this.lblBookPrice.Text = "Book Price";
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookQuantity.Location = new System.Drawing.Point(121, 245);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(96, 18);
            this.lblBookQuantity.TabIndex = 6;
            this.lblBookQuantity.Text = "Book Quantity";
            // 
            // txtBookAuthorName
            // 
            this.txtBookAuthorName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthorName.Location = new System.Drawing.Point(257, 85);
            this.txtBookAuthorName.Multiline = true;
            this.txtBookAuthorName.Name = "txtBookAuthorName";
            this.txtBookAuthorName.Size = new System.Drawing.Size(212, 19);
            this.txtBookAuthorName.TabIndex = 8;
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublication.Location = new System.Drawing.Point(257, 125);
            this.txtBookPublication.Multiline = true;
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(212, 19);
            this.txtBookPublication.TabIndex = 9;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookQuantity.Location = new System.Drawing.Point(257, 245);
            this.txtBookQuantity.Multiline = true;
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(212, 19);
            this.txtBookQuantity.TabIndex = 11;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPrice.Location = new System.Drawing.Point(257, 207);
            this.txtBookPrice.Multiline = true;
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(212, 19);
            this.txtBookPrice.TabIndex = 10;
            // 
            // dtpBookPurchaseDate
            // 
            this.dtpBookPurchaseDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookPurchaseDate.Location = new System.Drawing.Point(257, 162);
            this.dtpBookPurchaseDate.Name = "dtpBookPurchaseDate";
            this.dtpBookPurchaseDate.Size = new System.Drawing.Size(212, 23);
            this.dtpBookPurchaseDate.TabIndex = 12;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(121, 44);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(79, 18);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(257, 43);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(212, 19);
            this.txtBookName.TabIndex = 7;
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBooks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddBooks.Location = new System.Drawing.Point(257, 308);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooks.TabIndex = 13;
            this.btnAddBooks.Text = "Add";
            this.btnAddBooks.UseVisualStyleBackColor = false;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnCancelAddBooks
            // 
            this.btnCancelAddBooks.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAddBooks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddBooks.Location = new System.Drawing.Point(377, 308);
            this.btnCancelAddBooks.Name = "btnCancelAddBooks";
            this.btnCancelAddBooks.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddBooks.TabIndex = 14;
            this.btnCancelAddBooks.Text = "Cancel";
            this.btnCancelAddBooks.UseVisualStyleBackColor = false;
            this.btnCancelAddBooks.Click += new System.EventHandler(this.btnCancelAddBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblBookQuantity);
            this.panel2.Controls.Add(this.txtBookQuantity);
            this.panel2.Controls.Add(this.lblBookPrice);
            this.panel2.Controls.Add(this.dtpBookPurchaseDate);
            this.panel2.Controls.Add(this.lblBookPurchaseDate);
            this.panel2.Controls.Add(this.txtBookPrice);
            this.panel2.Controls.Add(this.lblBookPublication);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblBookAuthorName);
            this.panel2.Controls.Add(this.btnCancelAddBooks);
            this.panel2.Controls.Add(this.btnAddBooks);
            this.panel2.Controls.Add(this.txtBookPublication);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtBookAuthorName);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 379);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 472);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AddBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooksForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAddBooks;
        private System.Windows.Forms.Label lblAddBooks;
        private System.Windows.Forms.Label lblBookAuthorName;
        private System.Windows.Forms.Label lblBookPublication;
        private System.Windows.Forms.Label lblBookPurchaseDate;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.TextBox txtBookAuthorName;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.DateTimePicker dtpBookPurchaseDate;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnCancelAddBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}