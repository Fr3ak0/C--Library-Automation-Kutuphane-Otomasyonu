namespace Kutuphane_Proje
{
    partial class FrmTeacherMainFace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacherMainFace));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTT = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet5 = new Kutuphane_Proje.KutuphaneProjeDataSet5();
            this.label5 = new System.Windows.Forms.Label();
            this.bSearchAuthor = new System.Windows.Forms.Button();
            this.bSearchCate = new System.Windows.Forms.Button();
            this.bSearchBookName = new System.Windows.Forms.Button();
            this.texbAuthornameT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texbCategoryT = new System.Windows.Forms.TextBox();
            this.texbNameBookT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texbBookIdT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bReturnBookT = new System.Windows.Forms.Button();
            this.dataMybooks = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbl_BooksTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet5TableAdapters.Tbl_BooksTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textbBookId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textbYourEmail = new System.Windows.Forms.TextBox();
            this.bGetTheBook = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bStratsW = new System.Windows.Forms.Button();
            this.texbStartsW = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1205, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher Main Page";
            // 
            // dataGridViewTT
            // 
            this.dataGridViewTT.AutoGenerateColumns = false;
            this.dataGridViewTT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookPageDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookCountDataGridViewTextBoxColumn});
            this.dataGridViewTT.DataSource = this.tblBooksBindingSource;
            this.dataGridViewTT.Location = new System.Drawing.Point(12, 189);
            this.dataGridViewTT.Name = "dataGridViewTT";
            this.dataGridViewTT.Size = new System.Drawing.Size(669, 460);
            this.dataGridViewTT.TabIndex = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // bookPageDataGridViewTextBoxColumn
            // 
            this.bookPageDataGridViewTextBoxColumn.DataPropertyName = "Book_Page";
            this.bookPageDataGridViewTextBoxColumn.HeaderText = "Book_Page";
            this.bookPageDataGridViewTextBoxColumn.Name = "bookPageDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "Book_Author";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "Book_Author";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            // 
            // bookCountDataGridViewTextBoxColumn
            // 
            this.bookCountDataGridViewTextBoxColumn.DataPropertyName = "Book_Count";
            this.bookCountDataGridViewTextBoxColumn.HeaderText = "Book_Count";
            this.bookCountDataGridViewTextBoxColumn.Name = "bookCountDataGridViewTextBoxColumn";
            // 
            // tblBooksBindingSource
            // 
            this.tblBooksBindingSource.DataMember = "Tbl_Books";
            this.tblBooksBindingSource.DataSource = this.kutuphaneProjeDataSet5;
            // 
            // kutuphaneProjeDataSet5
            // 
            this.kutuphaneProjeDataSet5.DataSetName = "KutuphaneProjeDataSet5";
            this.kutuphaneProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Book Name :";
            // 
            // bSearchAuthor
            // 
            this.bSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchAuthor.Location = new System.Drawing.Point(606, 133);
            this.bSearchAuthor.Name = "bSearchAuthor";
            this.bSearchAuthor.Size = new System.Drawing.Size(75, 20);
            this.bSearchAuthor.TabIndex = 36;
            this.bSearchAuthor.Text = "Search";
            this.bSearchAuthor.UseVisualStyleBackColor = true;
            this.bSearchAuthor.Click += new System.EventHandler(this.bSearchAuthor_Click);
            // 
            // bSearchCate
            // 
            this.bSearchCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchCate.Location = new System.Drawing.Point(252, 160);
            this.bSearchCate.Name = "bSearchCate";
            this.bSearchCate.Size = new System.Drawing.Size(75, 20);
            this.bSearchCate.TabIndex = 37;
            this.bSearchCate.Text = "Search";
            this.bSearchCate.UseVisualStyleBackColor = true;
            this.bSearchCate.Click += new System.EventHandler(this.bSearchCate_Click);
            // 
            // bSearchBookName
            // 
            this.bSearchBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchBookName.Location = new System.Drawing.Point(252, 133);
            this.bSearchBookName.Name = "bSearchBookName";
            this.bSearchBookName.Size = new System.Drawing.Size(75, 20);
            this.bSearchBookName.TabIndex = 38;
            this.bSearchBookName.Text = "Search";
            this.bSearchBookName.UseVisualStyleBackColor = true;
            this.bSearchBookName.Click += new System.EventHandler(this.bSearchBookName_Click);
            // 
            // texbAuthornameT
            // 
            this.texbAuthornameT.Location = new System.Drawing.Point(475, 132);
            this.texbAuthornameT.Name = "texbAuthornameT";
            this.texbAuthornameT.Size = new System.Drawing.Size(110, 20);
            this.texbAuthornameT.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(333, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Author Name :";
            // 
            // texbCategoryT
            // 
            this.texbCategoryT.Location = new System.Drawing.Point(136, 159);
            this.texbCategoryT.Name = "texbCategoryT";
            this.texbCategoryT.Size = new System.Drawing.Size(110, 20);
            this.texbCategoryT.TabIndex = 34;
            // 
            // texbNameBookT
            // 
            this.texbNameBookT.Location = new System.Drawing.Point(136, 133);
            this.texbNameBookT.Name = "texbNameBookT";
            this.texbNameBookT.Size = new System.Drawing.Size(110, 20);
            this.texbNameBookT.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 40);
            this.label9.TabIndex = 31;
            this.label9.Text = "List Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Category  :";
            // 
            // texbBookIdT
            // 
            this.texbBookIdT.Location = new System.Drawing.Point(802, 134);
            this.texbBookIdT.Name = "texbBookIdT";
            this.texbBookIdT.Size = new System.Drawing.Size(209, 20);
            this.texbBookIdT.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(766, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Id:";
            // 
            // bReturnBookT
            // 
            this.bReturnBookT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bReturnBookT.Location = new System.Drawing.Point(1029, 123);
            this.bReturnBookT.Name = "bReturnBookT";
            this.bReturnBookT.Size = new System.Drawing.Size(138, 31);
            this.bReturnBookT.TabIndex = 43;
            this.bReturnBookT.Text = "Return The Book";
            this.bReturnBookT.UseVisualStyleBackColor = true;
            this.bReturnBookT.Click += new System.EventHandler(this.bReturnBookT_Click);
            // 
            // dataMybooks
            // 
            this.dataMybooks.BackgroundColor = System.Drawing.Color.White;
            this.dataMybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMybooks.Location = new System.Drawing.Point(724, 189);
            this.dataMybooks.Name = "dataMybooks";
            this.dataMybooks.Size = new System.Drawing.Size(572, 460);
            this.dataMybooks.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(717, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 40);
            this.label6.TabIndex = 41;
            this.label6.Text = "My Books";
            // 
            // tbl_BooksTableAdapter
            // 
            this.tbl_BooksTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 708);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 199);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Informations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(205, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(205, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Null Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(113, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name Surname :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 666);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "Book Id :";
            // 
            // textbBookId
            // 
            this.textbBookId.Location = new System.Drawing.Point(92, 670);
            this.textbBookId.Name = "textbBookId";
            this.textbBookId.Size = new System.Drawing.Size(138, 20);
            this.textbBookId.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(259, 666);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 24);
            this.label13.TabIndex = 47;
            this.label13.Text = "Your E-mail :";
            // 
            // textbYourEmail
            // 
            this.textbYourEmail.Location = new System.Drawing.Point(372, 670);
            this.textbYourEmail.Name = "textbYourEmail";
            this.textbYourEmail.Size = new System.Drawing.Size(138, 20);
            this.textbYourEmail.TabIndex = 48;
            // 
            // bGetTheBook
            // 
            this.bGetTheBook.Location = new System.Drawing.Point(542, 666);
            this.bGetTheBook.Name = "bGetTheBook";
            this.bGetTheBook.Size = new System.Drawing.Size(139, 28);
            this.bGetTheBook.TabIndex = 49;
            this.bGetTheBook.Text = "Get The Book";
            this.bGetTheBook.UseVisualStyleBackColor = true;
            this.bGetTheBook.Click += new System.EventHandler(this.bGetTheBook_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(337, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 28);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "Don\'t show non-existent books ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bStratsW
            // 
            this.bStratsW.Location = new System.Drawing.Point(606, 159);
            this.bStratsW.Name = "bStratsW";
            this.bStratsW.Size = new System.Drawing.Size(75, 23);
            this.bStratsW.TabIndex = 64;
            this.bStratsW.Text = "Search";
            this.bStratsW.UseVisualStyleBackColor = true;
            this.bStratsW.Click += new System.EventHandler(this.bStratsW_Click);
            // 
            // texbStartsW
            // 
            this.texbStartsW.Location = new System.Drawing.Point(475, 159);
            this.texbStartsW.Name = "texbStartsW";
            this.texbStartsW.Size = new System.Drawing.Size(110, 20);
            this.texbStartsW.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(358, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 24);
            this.label16.TabIndex = 62;
            this.label16.Text = "Starts With :";
            // 
            // FrmTeacherMainFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1329, 919);
            this.Controls.Add(this.bStratsW);
            this.Controls.Add(this.texbStartsW);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bGetTheBook);
            this.Controls.Add(this.textbYourEmail);
            this.Controls.Add(this.textbBookId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.texbBookIdT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bReturnBookT);
            this.Controls.Add(this.dataMybooks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bSearchAuthor);
            this.Controls.Add(this.bSearchCate);
            this.Controls.Add(this.bSearchBookName);
            this.Controls.Add(this.texbAuthornameT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.texbCategoryT);
            this.Controls.Add(this.texbNameBookT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTeacherMainFace";
            this.Text = "Teacher Panel";
            this.Load += new System.EventHandler(this.FrmTeacherMainFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSearchAuthor;
        private System.Windows.Forms.Button bSearchCate;
        private System.Windows.Forms.Button bSearchBookName;
        private System.Windows.Forms.TextBox texbAuthornameT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texbCategoryT;
        private System.Windows.Forms.TextBox texbNameBookT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbBookIdT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bReturnBookT;
        private System.Windows.Forms.DataGridView dataMybooks;
        private System.Windows.Forms.Label label6;
        private KutuphaneProjeDataSet5 kutuphaneProjeDataSet5;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private KutuphaneProjeDataSet5TableAdapters.Tbl_BooksTableAdapter tbl_BooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbBookId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbYourEmail;
        private System.Windows.Forms.Button bGetTheBook;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bStratsW;
        private System.Windows.Forms.TextBox texbStartsW;
        private System.Windows.Forms.Label label16;
    }
}