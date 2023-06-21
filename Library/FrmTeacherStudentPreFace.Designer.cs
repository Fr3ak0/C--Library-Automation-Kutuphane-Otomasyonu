namespace Kutuphane_Proje
{
    partial class FrmTeacherStudentPreFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacherStudentPreFace));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texbBookIdMy = new System.Windows.Forms.TextBox();
            this.texbStdNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bReturnBookT = new System.Windows.Forms.Button();
            this.dataMybooks = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneProjeDataSet6 = new Kutuphane_Proje.KutuphaneProjeDataSet6();
            this.bSearchCategory = new System.Windows.Forms.Button();
            this.bSearchBookName = new System.Windows.Forms.Button();
            this.bSearchAuthor = new System.Windows.Forms.Button();
            this.dateReceipt = new System.Windows.Forms.DateTimePicker();
            this.texbStudenNum = new System.Windows.Forms.TextBox();
            this.texbBookId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bgetthebooks = new System.Windows.Forms.Button();
            this.texbAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texbCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbl_BooksTableAdapter = new Kutuphane_Proje.KutuphaneProjeDataSet6TableAdapters.Tbl_BooksTableAdapter();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.texbStartsW = new System.Windows.Forms.TextBox();
            this.bStratsW = new System.Windows.Forms.Button();
            this.dataNotification = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Main Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1183, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // texbBookIdMy
            // 
            this.texbBookIdMy.Location = new System.Drawing.Point(895, 161);
            this.texbBookIdMy.Name = "texbBookIdMy";
            this.texbBookIdMy.Size = new System.Drawing.Size(209, 20);
            this.texbBookIdMy.TabIndex = 56;
            // 
            // texbStdNum
            // 
            this.texbStdNum.Location = new System.Drawing.Point(895, 205);
            this.texbStdNum.Name = "texbStdNum";
            this.texbStdNum.Size = new System.Drawing.Size(209, 20);
            this.texbStdNum.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(728, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "Student Number :";
            // 
            // bReturnBookT
            // 
            this.bReturnBookT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bReturnBookT.Location = new System.Drawing.Point(1130, 195);
            this.bReturnBookT.Name = "bReturnBookT";
            this.bReturnBookT.Size = new System.Drawing.Size(128, 30);
            this.bReturnBookT.TabIndex = 53;
            this.bReturnBookT.Text = "Return The Book";
            this.bReturnBookT.UseVisualStyleBackColor = true;
            this.bReturnBookT.Click += new System.EventHandler(this.bReturnBookT_Click);
            // 
            // dataMybooks
            // 
            this.dataMybooks.BackgroundColor = System.Drawing.Color.White;
            this.dataMybooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMybooks.Location = new System.Drawing.Point(732, 239);
            this.dataMybooks.Name = "dataMybooks";
            this.dataMybooks.Size = new System.Drawing.Size(581, 468);
            this.dataMybooks.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(725, 721);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 40);
            this.label10.TabIndex = 51;
            this.label10.Text = "Notifications";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookPageDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookCountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblBooksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(660, 468);
            this.dataGridView2.TabIndex = 32;
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
            this.tblBooksBindingSource.DataSource = this.kutuphaneProjeDataSet6;
            // 
            // kutuphaneProjeDataSet6
            // 
            this.kutuphaneProjeDataSet6.DataSetName = "KutuphaneProjeDataSet6";
            this.kutuphaneProjeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bSearchCategory
            // 
            this.bSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchCategory.Location = new System.Drawing.Point(274, 182);
            this.bSearchCategory.Name = "bSearchCategory";
            this.bSearchCategory.Size = new System.Drawing.Size(59, 21);
            this.bSearchCategory.TabIndex = 50;
            this.bSearchCategory.Text = "Search";
            this.bSearchCategory.UseVisualStyleBackColor = true;
            this.bSearchCategory.Click += new System.EventHandler(this.bSearchCategory_Click_1);
            // 
            // bSearchBookName
            // 
            this.bSearchBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchBookName.Location = new System.Drawing.Point(274, 156);
            this.bSearchBookName.Name = "bSearchBookName";
            this.bSearchBookName.Size = new System.Drawing.Size(59, 21);
            this.bSearchBookName.TabIndex = 49;
            this.bSearchBookName.Text = "Search";
            this.bSearchBookName.UseVisualStyleBackColor = true;
            this.bSearchBookName.Click += new System.EventHandler(this.bSearchBookName_Click);
            // 
            // bSearchAuthor
            // 
            this.bSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearchAuthor.Location = new System.Drawing.Point(606, 160);
            this.bSearchAuthor.Name = "bSearchAuthor";
            this.bSearchAuthor.Size = new System.Drawing.Size(74, 21);
            this.bSearchAuthor.TabIndex = 48;
            this.bSearchAuthor.Text = "Search";
            this.bSearchAuthor.UseVisualStyleBackColor = true;
            this.bSearchAuthor.Click += new System.EventHandler(this.bSearchAuthor_Click_1);
            // 
            // dateReceipt
            // 
            this.dateReceipt.Location = new System.Drawing.Point(474, 736);
            this.dateReceipt.Name = "dateReceipt";
            this.dateReceipt.Size = new System.Drawing.Size(200, 20);
            this.dateReceipt.TabIndex = 46;
            // 
            // texbStudenNum
            // 
            this.texbStudenNum.Location = new System.Drawing.Point(155, 713);
            this.texbStudenNum.Name = "texbStudenNum";
            this.texbStudenNum.Size = new System.Drawing.Size(182, 20);
            this.texbStudenNum.TabIndex = 45;
            // 
            // texbBookId
            // 
            this.texbBookId.Location = new System.Drawing.Point(439, 713);
            this.texbBookId.Name = "texbBookId";
            this.texbBookId.Size = new System.Drawing.Size(182, 20);
            this.texbBookId.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(343, 736);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Date Of Receipt: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(362, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Book Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Student Number: ";
            // 
            // bgetthebooks
            // 
            this.bgetthebooks.Cursor = System.Windows.Forms.Cursors.Default;
            this.bgetthebooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bgetthebooks.Location = new System.Drawing.Point(220, 764);
            this.bgetthebooks.Name = "bgetthebooks";
            this.bgetthebooks.Size = new System.Drawing.Size(229, 27);
            this.bgetthebooks.TabIndex = 40;
            this.bgetthebooks.Text = "Get the choosen books";
            this.bgetthebooks.UseVisualStyleBackColor = true;
            this.bgetthebooks.Click += new System.EventHandler(this.bgetthebooks_Click);
            // 
            // texbAuthor
            // 
            this.texbAuthor.Location = new System.Drawing.Point(490, 161);
            this.texbAuthor.Name = "texbAuthor";
            this.texbAuthor.Size = new System.Drawing.Size(110, 20);
            this.texbAuthor.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(348, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Author Name :";
            // 
            // texbCategory
            // 
            this.texbCategory.Location = new System.Drawing.Point(158, 183);
            this.texbCategory.Name = "texbCategory";
            this.texbCategory.Size = new System.Drawing.Size(110, 20);
            this.texbCategory.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Category :";
            // 
            // texbBookName
            // 
            this.texbBookName.Location = new System.Drawing.Point(158, 157);
            this.texbBookName.Name = "texbBookName";
            this.texbBookName.Size = new System.Drawing.Size(110, 20);
            this.texbBookName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Book Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(9, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 40);
            this.label11.TabIndex = 33;
            this.label11.Text = "List Books";
            // 
            // tbl_BooksTableAdapter
            // 
            this.tbl_BooksTableAdapter.ClearBeforeFill = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(38, 738);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 18);
            this.label18.TabIndex = 41;
            this.label18.Text = "Student Mail: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 736);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(808, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Book Id:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(352, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 28);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "Don\'t show non-existent books ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 809);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 119);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Informations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(223, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Null Null";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(288, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Null Null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(30, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Email or Student No :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(24, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name Surname :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(373, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 24);
            this.label16.TabIndex = 35;
            this.label16.Text = "Starts With :";
            // 
            // texbStartsW
            // 
            this.texbStartsW.Location = new System.Drawing.Point(490, 187);
            this.texbStartsW.Name = "texbStartsW";
            this.texbStartsW.Size = new System.Drawing.Size(110, 20);
            this.texbStartsW.TabIndex = 39;
            // 
            // bStratsW
            // 
            this.bStratsW.Location = new System.Drawing.Point(605, 187);
            this.bStratsW.Name = "bStratsW";
            this.bStratsW.Size = new System.Drawing.Size(75, 23);
            this.bStratsW.TabIndex = 61;
            this.bStratsW.Text = "Search";
            this.bStratsW.UseVisualStyleBackColor = true;
            this.bStratsW.Click += new System.EventHandler(this.bStratsW_Click);
            // 
            // dataNotification
            // 
            this.dataNotification.BackgroundColor = System.Drawing.Color.White;
            this.dataNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotification.Location = new System.Drawing.Point(732, 764);
            this.dataNotification.Name = "dataNotification";
            this.dataNotification.Size = new System.Drawing.Size(581, 164);
            this.dataNotification.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(725, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 40);
            this.label17.TabIndex = 33;
            this.label17.Text = "My Books";
            // 
            // FrmTeacherStudentPreFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1329, 940);
            this.Controls.Add(this.dataNotification);
            this.Controls.Add(this.bStratsW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.texbBookIdMy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.texbStdNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bReturnBookT);
            this.Controls.Add(this.dataMybooks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bSearchCategory);
            this.Controls.Add(this.bSearchBookName);
            this.Controls.Add(this.bSearchAuthor);
            this.Controls.Add(this.dateReceipt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.texbStudenNum);
            this.Controls.Add(this.texbBookId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bgetthebooks);
            this.Controls.Add(this.texbStartsW);
            this.Controls.Add(this.texbAuthor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texbBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTeacherStudentPreFace";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.FrmTeacherStudentPreFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMybooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneProjeDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox texbBookIdMy;
        private System.Windows.Forms.TextBox texbStdNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bReturnBookT;
        private System.Windows.Forms.DataGridView dataMybooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bSearchCategory;
        private System.Windows.Forms.Button bSearchBookName;
        private System.Windows.Forms.Button bSearchAuthor;
        private System.Windows.Forms.DateTimePicker dateReceipt;
        private System.Windows.Forms.TextBox texbStudenNum;
        private System.Windows.Forms.TextBox texbBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bgetthebooks;
        private System.Windows.Forms.TextBox texbAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private KutuphaneProjeDataSet6 kutuphaneProjeDataSet6;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private KutuphaneProjeDataSet6TableAdapters.Tbl_BooksTableAdapter tbl_BooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox texbStartsW;
        private System.Windows.Forms.Button bStratsW;
        private System.Windows.Forms.DataGridView dataNotification;
        private System.Windows.Forms.Label label17;
    }
}