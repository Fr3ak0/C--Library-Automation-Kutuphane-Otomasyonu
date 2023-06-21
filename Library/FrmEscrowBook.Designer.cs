namespace Kutuphane_Proje
{
    partial class FrmEscrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscrowBook));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet7 = new Kutuphane_Proje.KutuphaneProjeDataSet7();
            this.bSearchBookId = new System.Windows.Forms.Button();
            this.tbBookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet8 = new Kutuphane_Proje.KutuphaneProjeDataSet8();
            this.bSearchStudentNum = new System.Windows.Forms.Button();
            this.tbStudentNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRequestedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet9 = new Kutuphane_Proje.KutuphaneProjeDataSet9();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.tbl_BooksTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet7TableAdapters.Tbl_BooksTableAdapter();
            this.tbl_StudentsTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet8TableAdapters.Tbl_StudentsTableAdapter();
            this.tbl_RequestedBooksTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet9TableAdapters.Tbl_RequestedBooksTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.texbStudentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.texbBookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.texRequestId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texbStudentMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bDecline = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet7)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bSearchBookId);
            this.groupBox1.Controls.Add(this.tbBookid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookPageDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBooksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 310);
            this.dataGridView1.TabIndex = 3;
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
            this.tblBooksBindingSource.DataSource = this.kutuphaneProjeDataSet7;
            // 
            // kutuphaneProjeDataSet7
            // 
            this.kutuphaneProjeDataSet7.DataSetName = "KutuphaneProjeDataSet7";
            this.kutuphaneProjeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSearchBookId
            // 
            this.bSearchBookId.Location = new System.Drawing.Point(337, 20);
            this.bSearchBookId.Name = "bSearchBookId";
            this.bSearchBookId.Size = new System.Drawing.Size(83, 29);
            this.bSearchBookId.TabIndex = 2;
            this.bSearchBookId.Text = "Search";
            this.bSearchBookId.UseVisualStyleBackColor = true;
            this.bSearchBookId.Click += new System.EventHandler(this.bSearchBookId_Click);
            // 
            // tbBookid
            // 
            this.tbBookid.Location = new System.Drawing.Point(157, 20);
            this.tbBookid.Name = "tbBookid";
            this.tbBookid.Size = new System.Drawing.Size(144, 22);
            this.tbBookid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(480, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escrow Books";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.bSearchStudentNum);
            this.groupBox2.Controls.Add(this.tbStudentNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(33, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 371);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentMailDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.studentPasswordDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblStudentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(648, 310);
            this.dataGridView2.TabIndex = 3;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "Studentid";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "Studentid";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentMailDataGridViewTextBoxColumn
            // 
            this.studentMailDataGridViewTextBoxColumn.DataPropertyName = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.HeaderText = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.Name = "studentMailDataGridViewTextBoxColumn";
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // studentPasswordDataGridViewTextBoxColumn
            // 
            this.studentPasswordDataGridViewTextBoxColumn.DataPropertyName = "StudentPassword";
            this.studentPasswordDataGridViewTextBoxColumn.HeaderText = "StudentPassword";
            this.studentPasswordDataGridViewTextBoxColumn.Name = "studentPasswordDataGridViewTextBoxColumn";
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "Tbl_Students";
            this.tblStudentsBindingSource.DataSource = this.kutuphaneProjeDataSet8;
            // 
            // kutuphaneProjeDataSet8
            // 
            this.kutuphaneProjeDataSet8.DataSetName = "KutuphaneProjeDataSet8";
            this.kutuphaneProjeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSearchStudentNum
            // 
            this.bSearchStudentNum.Location = new System.Drawing.Point(337, 20);
            this.bSearchStudentNum.Name = "bSearchStudentNum";
            this.bSearchStudentNum.Size = new System.Drawing.Size(83, 29);
            this.bSearchStudentNum.TabIndex = 2;
            this.bSearchStudentNum.Text = "Search";
            this.bSearchStudentNum.UseVisualStyleBackColor = true;
            this.bSearchStudentNum.Click += new System.EventHandler(this.bSearchStudentNum_Click);
            // 
            // tbStudentNum
            // 
            this.tbStudentNum.Location = new System.Drawing.Point(170, 20);
            this.tbStudentNum.Name = "tbStudentNum";
            this.tbStudentNum.Size = new System.Drawing.Size(144, 22);
            this.tbStudentNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(875, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Requested Books";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Book_Id,
            this.StudentNumber,
            this.StudentMail,
            this.dateOfReceiptDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblRequestedBooksBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(711, 185);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(532, 433);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Book_Id
            // 
            this.Book_Id.DataPropertyName = "Book_Id";
            this.Book_Id.HeaderText = "Book_Id";
            this.Book_Id.Name = "Book_Id";
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.HeaderText = "StudentNumber";
            this.StudentNumber.Name = "StudentNumber";
            // 
            // StudentMail
            // 
            this.StudentMail.DataPropertyName = "StudentMail";
            this.StudentMail.HeaderText = "StudentMail";
            this.StudentMail.Name = "StudentMail";
            // 
            // dateOfReceiptDataGridViewTextBoxColumn
            // 
            this.dateOfReceiptDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Receipt";
            this.dateOfReceiptDataGridViewTextBoxColumn.HeaderText = "Date_Of_Receipt";
            this.dateOfReceiptDataGridViewTextBoxColumn.Name = "dateOfReceiptDataGridViewTextBoxColumn";
            // 
            // tblRequestedBooksBindingSource
            // 
            this.tblRequestedBooksBindingSource.DataMember = "Tbl_RequestedBooks";
            this.tblRequestedBooksBindingSource.DataSource = this.kutuphaneProjeDataSet9;
            // 
            // kutuphaneProjeDataSet9
            // 
            this.kutuphaneProjeDataSet9.DataSetName = "KutuphaneProjeDataSet9";
            this.kutuphaneProjeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(787, 761);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Of Give :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(916, 765);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(806, 825);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Escrow Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbl_BooksTableAdapter
            // 
            this.tbl_BooksTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_StudentsTableAdapter
            // 
            this.tbl_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RequestedBooksTableAdapter
            // 
            this.tbl_RequestedBooksTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(754, 705);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Number :";
            // 
            // texbStudentNo
            // 
            this.texbStudentNo.Location = new System.Drawing.Point(916, 709);
            this.texbStudentNo.Name = "texbStudentNo";
            this.texbStudentNo.Size = new System.Drawing.Size(200, 20);
            this.texbStudentNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(829, 680);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book Id :";
            // 
            // texbBookId
            // 
            this.texbBookId.Location = new System.Drawing.Point(916, 683);
            this.texbBookId.Name = "texbBookId";
            this.texbBookId.Size = new System.Drawing.Size(200, 20);
            this.texbBookId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(802, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Request Id :";
            // 
            // texRequestId
            // 
            this.texRequestId.Location = new System.Drawing.Point(916, 657);
            this.texRequestId.Name = "texRequestId";
            this.texRequestId.Size = new System.Drawing.Size(200, 20);
            this.texRequestId.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(789, 731);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Student Mail :";
            // 
            // texbStudentMail
            // 
            this.texbStudentMail.Location = new System.Drawing.Point(916, 735);
            this.texbStudentMail.Name = "texbStudentMail";
            this.texbStudentMail.Size = new System.Drawing.Size(200, 20);
            this.texbStudentMail.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "8680038_arrow_go_back_fill_icon.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 61);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "8680038_arrow_go_back_fill_icon.png");
            this.ımageList1.Images.SetKeyName(1, "8680038_arrow_go_back_fill_icon.png");
            // 
            // bDecline
            // 
            this.bDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bDecline.Location = new System.Drawing.Point(1014, 825);
            this.bDecline.Name = "bDecline";
            this.bDecline.Size = new System.Drawing.Size(191, 33);
            this.bDecline.TabIndex = 14;
            this.bDecline.Text = "Decline";
            this.bDecline.UseVisualStyleBackColor = false;
            this.bDecline.Click += new System.EventHandler(this.bDecline_Click_1);
            // 
            // FrmEscrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1251, 909);
            this.Controls.Add(this.bDecline);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texRequestId);
            this.Controls.Add(this.texbBookId);
            this.Controls.Add(this.texbStudentMail);
            this.Controls.Add(this.texbStudentNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEscrowBook";
            this.Text = "Escrow Book";
            this.Load += new System.EventHandler(this.FrmEscrowBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bSearchBookId;
        private System.Windows.Forms.TextBox tbBookid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bSearchStudentNum;
        private System.Windows.Forms.TextBox tbStudentNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private KutuphaneProjeDataSet7 kutuphaneProjeDataSet7;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private KutuphaneProjeDataSet7TableAdapters.Tbl_BooksTableAdapter tbl_BooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountDataGridViewTextBoxColumn;
        private KutuphaneProjeDataSet8 kutuphaneProjeDataSet8;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private KutuphaneProjeDataSet8TableAdapters.Tbl_StudentsTableAdapter tbl_StudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPasswordDataGridViewTextBoxColumn;
        private KutuphaneProjeDataSet9 kutuphaneProjeDataSet9;
        private System.Windows.Forms.BindingSource tblRequestedBooksBindingSource;
        private KutuphaneProjeDataSet9TableAdapters.Tbl_RequestedBooksTableAdapter tbl_RequestedBooksTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texbStudentNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texbBookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texRequestId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texbStudentMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReceiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bDecline;
    }
}