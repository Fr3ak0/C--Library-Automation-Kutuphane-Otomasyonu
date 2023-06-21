namespace Kutuphane_Proje
{
    partial class FrmFollowEscrowedBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFollowEscrowedBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblReturnedBooks2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet10 = new Kutuphane_Proje.KutuphaneProjeDataSet10();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texbStudentNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texbBookId = new System.Windows.Forms.TextBox();
            this.bGetBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbl_ReturnedBooks2TableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet10TableAdapters.Tbl_ReturnedBooks2TableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.texbStudentMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Back = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGivenBooksStudent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet12 = new Kutuphane_Proje.KutuphaneProjeDataSet12();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.texbstdnum = new System.Windows.Forms.TextBox();
            this.texbstdmail = new System.Windows.Forms.TextBox();
            this.texbid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_GivenBooksStudent1TableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet12TableAdapters.Tbl_GivenBooksStudent1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnedBooks2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGivenBooksStudent1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Returned Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bookNameDataGridViewTextBoxColumn,
            this.StudentMail,
            this.StudentNumber,
            this.dateOfIssueDataGridViewTextBoxColumn,
            this.dateOfBackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblReturnedBooks2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 371);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // StudentMail
            // 
            this.StudentMail.DataPropertyName = "StudentMail";
            this.StudentMail.HeaderText = "StudentMail";
            this.StudentMail.Name = "StudentMail";
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.HeaderText = "StudentNumber";
            this.StudentNumber.Name = "StudentNumber";
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            // 
            // dateOfBackDataGridViewTextBoxColumn
            // 
            this.dateOfBackDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Back";
            this.dateOfBackDataGridViewTextBoxColumn.HeaderText = "Date_Of_Back";
            this.dateOfBackDataGridViewTextBoxColumn.Name = "dateOfBackDataGridViewTextBoxColumn";
            // 
            // tblReturnedBooks2BindingSource
            // 
            this.tblReturnedBooks2BindingSource.DataMember = "Tbl_ReturnedBooks2";
            this.tblReturnedBooks2BindingSource.DataSource = this.kutuphaneProjeDataSet10;
            // 
            // kutuphaneProjeDataSet10
            // 
            this.kutuphaneProjeDataSet10.DataSetName = "KutuphaneProjeDataSet10";
            this.kutuphaneProjeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(874, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Get The Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(756, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Number : ";
            // 
            // texbStudentNum
            // 
            this.texbStudentNum.Location = new System.Drawing.Point(968, 132);
            this.texbStudentNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbStudentNum.Name = "texbStudentNum";
            this.texbStudentNum.Size = new System.Drawing.Size(168, 20);
            this.texbStudentNum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(849, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Book id : ";
            // 
            // texbBookId
            // 
            this.texbBookId.Location = new System.Drawing.Point(968, 210);
            this.texbBookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbBookId.Name = "texbBookId";
            this.texbBookId.Size = new System.Drawing.Size(168, 20);
            this.texbBookId.TabIndex = 3;
            // 
            // bGetBook
            // 
            this.bGetBook.Location = new System.Drawing.Point(880, 357);
            this.bGetBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bGetBook.Name = "bGetBook";
            this.bGetBook.Size = new System.Drawing.Size(224, 32);
            this.bGetBook.TabIndex = 4;
            this.bGetBook.Text = "Get The Book";
            this.bGetBook.UseVisualStyleBackColor = true;
            this.bGetBook.Click += new System.EventHandler(this.bGetBook_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "8680038_arrow_go_back_fill_icon.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 58);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "103401_add_book_sans_icon.png");
            this.ımageList1.Images.SetKeyName(1, "103404_book_sans_remove_icon.png");
            this.ımageList1.Images.SetKeyName(2, "8680038_arrow_go_back_fill_icon.png");
            this.ımageList1.Images.SetKeyName(3, "10131994_book_plus_line_icon.png");
            this.ımageList1.Images.SetKeyName(4, "6590491_and_book_delete_education_learning_icon.png");
            // 
            // tbl_ReturnedBooks2TableAdapter
            // 
            this.tbl_ReturnedBooks2TableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(798, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Student Mail : ";
            // 
            // texbStudentMail
            // 
            this.texbStudentMail.Location = new System.Drawing.Point(968, 171);
            this.texbStudentMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbStudentMail.Name = "texbStudentMail";
            this.texbStudentMail.Size = new System.Drawing.Size(168, 20);
            this.texbStudentMail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(219, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Given Books";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.bookNameDataGridViewTextBoxColumn1,
            this.bookPageDataGridViewTextBoxColumn,
            this.bookCategoryDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.StudentNumber1,
            this.StudentMail1,
            this.dateOfIssueDataGridViewTextBoxColumn1,
            this.Date_Of_Back});
            this.dataGridView2.DataSource = this.tblGivenBooksStudent1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 535);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(940, 371);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "id";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn1
            // 
            this.bookNameDataGridViewTextBoxColumn1.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn1.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn1.Name = "bookNameDataGridViewTextBoxColumn1";
            // 
            // bookPageDataGridViewTextBoxColumn
            // 
            this.bookPageDataGridViewTextBoxColumn.DataPropertyName = "Book_Page";
            this.bookPageDataGridViewTextBoxColumn.HeaderText = "Book_Page";
            this.bookPageDataGridViewTextBoxColumn.Name = "bookPageDataGridViewTextBoxColumn";
            // 
            // bookCategoryDataGridViewTextBoxColumn
            // 
            this.bookCategoryDataGridViewTextBoxColumn.DataPropertyName = "Book_Category";
            this.bookCategoryDataGridViewTextBoxColumn.HeaderText = "Book_Category";
            this.bookCategoryDataGridViewTextBoxColumn.Name = "bookCategoryDataGridViewTextBoxColumn";
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "Book_Author";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "Book_Author";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            // 
            // StudentNumber1
            // 
            this.StudentNumber1.DataPropertyName = "StudentNumber";
            this.StudentNumber1.HeaderText = "StudentNumber";
            this.StudentNumber1.Name = "StudentNumber1";
            // 
            // StudentMail1
            // 
            this.StudentMail1.DataPropertyName = "StudentMail";
            this.StudentMail1.HeaderText = "StudentMail";
            this.StudentMail1.Name = "StudentMail1";
            // 
            // dateOfIssueDataGridViewTextBoxColumn1
            // 
            this.dateOfIssueDataGridViewTextBoxColumn1.DataPropertyName = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn1.HeaderText = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn1.Name = "dateOfIssueDataGridViewTextBoxColumn1";
            // 
            // Date_Of_Back
            // 
            this.Date_Of_Back.DataPropertyName = "Date_Of_Back";
            this.Date_Of_Back.HeaderText = "Date_Of_Back";
            this.Date_Of_Back.Name = "Date_Of_Back";
            // 
            // tblGivenBooksStudent1BindingSource
            // 
            this.tblGivenBooksStudent1BindingSource.DataMember = "Tbl_GivenBooksStudent1";
            this.tblGivenBooksStudent1BindingSource.DataSource = this.kutuphaneProjeDataSet12;
            // 
            // kutuphaneProjeDataSet12
            // 
            this.kutuphaneProjeDataSet12.DataSetName = "KutuphaneProjeDataSet12";
            this.kutuphaneProjeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(990, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Extend the return period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(958, 620);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Student Number : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1000, 659);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Student Mail : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(992, 747);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date Of Back : ";
            // 
            // texbstdnum
            // 
            this.texbstdnum.Location = new System.Drawing.Point(1170, 630);
            this.texbstdnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbstdnum.Name = "texbstdnum";
            this.texbstdnum.Size = new System.Drawing.Size(168, 20);
            this.texbstdnum.TabIndex = 3;
            // 
            // texbstdmail
            // 
            this.texbstdmail.Location = new System.Drawing.Point(1170, 669);
            this.texbstdmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbstdmail.Name = "texbstdmail";
            this.texbstdmail.Size = new System.Drawing.Size(168, 20);
            this.texbstdmail.TabIndex = 3;
            // 
            // texbid
            // 
            this.texbid.Location = new System.Drawing.Point(1170, 709);
            this.texbid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texbid.Name = "texbid";
            this.texbid.Size = new System.Drawing.Size(168, 20);
            this.texbid.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1051, 700);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Book id : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1160, 752);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1130, 839);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_GivenBooksStudent1TableAdapter
            // 
            this.tbl_GivenBooksStudent1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmFollowEscrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bGetBook);
            this.Controls.Add(this.texbid);
            this.Controls.Add(this.texbBookId);
            this.Controls.Add(this.texbstdmail);
            this.Controls.Add(this.texbStudentMail);
            this.Controls.Add(this.texbstdnum);
            this.Controls.Add(this.texbStudentNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmFollowEscrowedBooks";
            this.Text = "Follow Escrowed Books";
            this.Load += new System.EventHandler(this.FrmFollowEscrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnedBooks2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGivenBooksStudent1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texbStudentNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbBookId;
        private System.Windows.Forms.Button bGetBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private KutuphaneProjeDataSet10 kutuphaneProjeDataSet10;
        private System.Windows.Forms.BindingSource tblReturnedBooks2BindingSource;
        private KutuphaneProjeDataSet10TableAdapters.Tbl_ReturnedBooks2TableAdapter tbl_ReturnedBooks2TableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texbStudentMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBackDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texbstdnum;
        private System.Windows.Forms.TextBox texbstdmail;
        private System.Windows.Forms.TextBox texbid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private KutuphaneProjeDataSet12 kutuphaneProjeDataSet12;
        private System.Windows.Forms.BindingSource tblGivenBooksStudent1BindingSource;
        private KutuphaneProjeDataSet12TableAdapters.Tbl_GivenBooksStudent1TableAdapter tbl_GivenBooksStudent1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Back;
    }
}