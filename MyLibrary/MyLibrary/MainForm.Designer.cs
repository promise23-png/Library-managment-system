namespace MyLibrary
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilterBooks = new System.Windows.Forms.Button();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.tabBorrowers = new System.Windows.Forms.TabPage();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOverdueBooks = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.btnEditBorrower = new System.Windows.Forms.Button();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabBorrowers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBooks.Controls.Add(this.groupBox1);
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.btnEditBook);
            this.tabBooks.Controls.Add(this.btnDeleteBook);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(826, 451);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnResetFilter);
            this.groupBox1.Controls.Add(this.btnFilterBooks);
            this.groupBox1.Controls.Add(this.txtYearTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYearFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAuthorFilter);
            this.groupBox1.Controls.Add(this.lblFilter);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Books";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnResetFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.Location = new System.Drawing.Point(708, 19);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(100, 30);
            this.btnResetFilter.TabIndex = 11;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFilterBooks
            // 
            this.btnFilterBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnFilterBooks.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnFilterBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFilterBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFilterBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterBooks.ForeColor = System.Drawing.Color.White;
            this.btnFilterBooks.Location = new System.Drawing.Point(602, 19);
            this.btnFilterBooks.Name = "btnFilterBooks";
            this.btnFilterBooks.Size = new System.Drawing.Size(100, 30);
            this.btnFilterBooks.TabIndex = 10;
            this.btnFilterBooks.Text = "Filter";
            this.btnFilterBooks.UseVisualStyleBackColor = false;
            this.btnFilterBooks.Click += new System.EventHandler(this.btnFilterBooks_Click);
            // 
            // txtYearTo
            // 
            this.txtYearTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearTo.Location = new System.Drawing.Point(490, 22);
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(60, 23);
            this.txtYearTo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year To:";
            // 
            // txtYearFrom
            // 
            this.txtYearFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearFrom.Location = new System.Drawing.Point(371, 22);
            this.txtYearFrom.Name = "txtYearFrom";
            this.txtYearFrom.Size = new System.Drawing.Size(60, 23);
            this.txtYearFrom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year From:";
            // 
            // txtAuthorFilter
            // 
            this.txtAuthorFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorFilter.Location = new System.Drawing.Point(102, 22);
            this.txtAuthorFilter.Name = "txtAuthorFilter";
            this.txtAuthorFilter.Size = new System.Drawing.Size(196, 23);
            this.txtAuthorFilter.TabIndex = 5;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(6, 25);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(90, 15);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter by Author:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvBooks.Location = new System.Drawing.Point(6, 72);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(814, 340);
            this.dgvBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(6, 418);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 30);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnEditBook.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEditBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ForeColor = System.Drawing.Color.White;
            this.btnEditBook.Location = new System.Drawing.Point(132, 418);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(120, 30);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteBook.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDeleteBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(258, 418);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // tabBorrowers
            // 
            this.tabBorrowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBorrowers.Controls.Add(this.dgvBorrowers);
            this.tabBorrowers.Controls.Add(this.groupBox2);
            this.tabBorrowers.Location = new System.Drawing.Point(4, 22);
            this.tabBorrowers.Name = "tabBorrowers";
            this.tabBorrowers.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrowers.Size = new System.Drawing.Size(826, 451);
            this.tabBorrowers.TabIndex = 1;
            this.tabBorrowers.Text = "Borrowers Management";
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.AllowUserToAddRows = false;
            this.dgvBorrowers.AllowUserToDeleteRows = false;
            this.dgvBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowers.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvBorrowers.Location = new System.Drawing.Point(6, 6);
            this.dgvBorrowers.MultiSelect = false;
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.ReadOnly = true;
            this.dgvBorrowers.RowHeadersVisible = false;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(814, 340);
            this.dgvBorrowers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnOverdueBooks);
            this.groupBox2.Controls.Add(this.btnReturnBook);
            this.groupBox2.Controls.Add(this.btnIssueBook);
            this.groupBox2.Controls.Add(this.btnDeleteBorrower);
            this.groupBox2.Controls.Add(this.btnEditBorrower);
            this.groupBox2.Controls.Add(this.btnAddBorrower);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnOverdueBooks
            // 
            this.btnOverdueBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOverdueBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnOverdueBooks.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOverdueBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOverdueBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOverdueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdueBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverdueBooks.ForeColor = System.Drawing.Color.White;
            this.btnOverdueBooks.Location = new System.Drawing.Point(648, 19);
            this.btnOverdueBooks.Name = "btnOverdueBooks";
            this.btnOverdueBooks.Size = new System.Drawing.Size(160, 30);
            this.btnOverdueBooks.TabIndex = 6;
            this.btnOverdueBooks.Text = "View Overdue Books";
            this.btnOverdueBooks.UseVisualStyleBackColor = false;
            this.btnOverdueBooks.Click += new System.EventHandler(this.btnOverdueBooks_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(432, 19);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(120, 30);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnIssueBook.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnIssueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(306, 19);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(120, 30);
            this.btnIssueBook.TabIndex = 4;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteBorrower.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDeleteBorrower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBorrower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBorrower.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBorrower.Location = new System.Drawing.Point(180, 19);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteBorrower.TabIndex = 3;
            this.btnDeleteBorrower.Text = "Delete Borrower";
            this.btnDeleteBorrower.UseVisualStyleBackColor = false;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDeleteBorrower_Click);
            // 
            // btnEditBorrower
            // 
            this.btnEditBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnEditBorrower.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEditBorrower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBorrower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBorrower.ForeColor = System.Drawing.Color.White;
            this.btnEditBorrower.Location = new System.Drawing.Point(90, 19);
            this.btnEditBorrower.Name = "btnEditBorrower";
            this.btnEditBorrower.Size = new System.Drawing.Size(84, 30);
            this.btnEditBorrower.TabIndex = 2;
            this.btnEditBorrower.Text = "Edit";
            this.btnEditBorrower.UseVisualStyleBackColor = false;
            this.btnEditBorrower.Click += new System.EventHandler(this.btnEditBorrower_Click);
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnAddBorrower.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddBorrower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBorrower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrower.ForeColor = System.Drawing.Color.White;
            this.btnAddBorrower.Location = new System.Drawing.Point(6, 19);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(78, 30);
            this.btnAddBorrower.TabIndex = 1;
            this.btnAddBorrower.Text = "Add";
            this.btnAddBorrower.UseVisualStyleBackColor = false;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overdueBooksToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // overdueBooksToolStripMenuItem
            // 
            this.overdueBooksToolStripMenuItem.Name = "overdueBooksToolStripMenuItem";
            this.overdueBooksToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.overdueBooksToolStripMenuItem.Text = "Overdue Books";
            this.overdueBooksToolStripMenuItem.Click += new System.EventHandler(this.btnOverdueBooks_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 17);
            this.lblStatus.Text = "Ready to use";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 562);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLibrary - Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TabPage tabBorrowers;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.Button btnEditBorrower;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAuthorFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterBooks;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnOverdueBooks;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overdueBooksToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}