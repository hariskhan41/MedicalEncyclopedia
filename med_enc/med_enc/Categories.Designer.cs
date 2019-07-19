namespace med_enc
{
    partial class Categories
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
            this.TaskbarPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فائلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انتظامیامورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بیماریوںکیتفصیلاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رپورٹسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmptyPanel = new System.Windows.Forms.Panel();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet = new med_enc.MedDbDataSet();
            this.categoryTableAdapter = new med_enc.MedDbDataSetTableAdapters.CategoryTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_CategoryDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.txt_CategoryDetails = new System.Windows.Forms.TextBox();
            this.cmb_CategoryHeadName = new System.Windows.Forms.ComboBox();
            this.btn_SaveCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskbarPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.Controls.Add(this.menuStrip1);
            this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskbarPanel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(878, 40);
            this.TaskbarPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فائلToolStripMenuItem,
            this.انتظامیامورToolStripMenuItem,
            this.بیماریوںکیتفصیلاتToolStripMenuItem,
            this.رپورٹسToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(878, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuBar";
            // 
            // فائلToolStripMenuItem
            // 
            this.فائلToolStripMenuItem.Name = "فائلToolStripMenuItem";
            this.فائلToolStripMenuItem.Size = new System.Drawing.Size(38, 26);
            this.فائلToolStripMenuItem.Text = "فائل";
            // 
            // انتظامیامورToolStripMenuItem
            // 
            this.انتظامیامورToolStripMenuItem.Name = "انتظامیامورToolStripMenuItem";
            this.انتظامیامورToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.انتظامیامورToolStripMenuItem.Text = "انتظامی امور";
            // 
            // بیماریوںکیتفصیلاتToolStripMenuItem
            // 
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Name = "بیماریوںکیتفصیلاتToolStripMenuItem";
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Text = "بیماریوں کی تفصیلات";
            // 
            // رپورٹسToolStripMenuItem
            // 
            this.رپورٹسToolStripMenuItem.Name = "رپورٹسToolStripMenuItem";
            this.رپورٹسToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.رپورٹسToolStripMenuItem.Text = "رپورٹس";
            // 
            // EmptyPanel
            // 
            this.EmptyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmptyPanel.Location = new System.Drawing.Point(789, 40);
            this.EmptyPanel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.EmptyPanel.Name = "EmptyPanel";
            this.EmptyPanel.Size = new System.Drawing.Size(89, 601);
            this.EmptyPanel.TabIndex = 3;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.medDbDataSet;
            // 
            // medDbDataSet
            // 
            this.medDbDataSet.DataSetName = "MedDbDataSet";
            this.medDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_CategoryDetails, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_CategoryName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_CategoryDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_CategoryHeadName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveCategory, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 595);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dgv_CategoryDetails
            // 
            this.dgv_CategoryDetails.AutoGenerateColumns = false;
            this.dgv_CategoryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CategoryDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_CategoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn,
            this.HeadName,
            this.Edit,
            this.Delete,
            this.Id});
            this.dgv_CategoryDetails.DataSource = this.categoryBindingSource;
            this.dgv_CategoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CategoryDetails.Location = new System.Drawing.Point(3, 186);
            this.dgv_CategoryDetails.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgv_CategoryDetails.Name = "dgv_CategoryDetails";
            this.dgv_CategoryDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_CategoryDetails.Size = new System.Drawing.Size(631, 403);
            this.dgv_CategoryDetails.TabIndex = 5;
            this.dgv_CategoryDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "کیٹیگری کا نام";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "کیٹیگری کا ہیڈ نام";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "کیٹیگری کی تفصیلات";
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CategoryName.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryName.Location = new System.Drawing.Point(419, 6);
            this.txt_CategoryName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_CategoryName.Multiline = true;
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CategoryName.Size = new System.Drawing.Size(215, 35);
            this.txt_CategoryName.TabIndex = 3;
            // 
            // txt_CategoryDetails
            // 
            this.txt_CategoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CategoryDetails.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoryDetails.Location = new System.Drawing.Point(419, 95);
            this.txt_CategoryDetails.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_CategoryDetails.Multiline = true;
            this.txt_CategoryDetails.Name = "txt_CategoryDetails";
            this.txt_CategoryDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CategoryDetails.Size = new System.Drawing.Size(215, 32);
            this.txt_CategoryDetails.TabIndex = 4;
            // 
            // cmb_CategoryHeadName
            // 
            this.cmb_CategoryHeadName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_CategoryHeadName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_CategoryHeadName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_CategoryHeadName.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CategoryHeadName.FormattingEnabled = true;
            this.cmb_CategoryHeadName.ItemHeight = 22;
            this.cmb_CategoryHeadName.Location = new System.Drawing.Point(419, 53);
            this.cmb_CategoryHeadName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmb_CategoryHeadName.Name = "cmb_CategoryHeadName";
            this.cmb_CategoryHeadName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_CategoryHeadName.Size = new System.Drawing.Size(215, 30);
            this.cmb_CategoryHeadName.TabIndex = 5;
            // 
            // btn_SaveCategory
            // 
            this.btn_SaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveCategory.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCategory.Location = new System.Drawing.Point(498, 139);
            this.btn_SaveCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_SaveCategory.Name = "btn_SaveCategory";
            this.btn_SaveCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_SaveCategory.Size = new System.Drawing.Size(136, 35);
            this.btn_SaveCategory.TabIndex = 6;
            this.btn_SaveCategory.Text = "محفوظ کریں";
            this.btn_SaveCategory.UseVisualStyleBackColor = true;
            this.btn_SaveCategory.Click += new System.EventHandler(this.btn_SaveCategory_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 601);
            this.panel1.TabIndex = 6;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "نام";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "تفصیلات";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // HeadName
            // 
            this.HeadName.HeaderText = "ہیڈ نام";
            this.HeadName.Name = "HeadName";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "ترمیم";
            this.Edit.Name = "Edit";
            this.Edit.Text = "ترمیم";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حزف کریں";
            this.Delete.Name = "Delete";
            this.Delete.Text = "حزف کریں";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmptyPanel);
            this.Controls.Add(this.TaskbarPanel);
            this.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Categories";
            this.Text = "کیٹیگری";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.TaskbarPanel.ResumeLayout(false);
            this.TaskbarPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskbarPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فائلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انتظامیامورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بیماریوںکیتفصیلاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رپورٹسToolStripMenuItem;
        private System.Windows.Forms.Panel EmptyPanel;
        private MedDbDataSet medDbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MedDbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_CategoryDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.TextBox txt_CategoryDetails;
        private System.Windows.Forms.ComboBox cmb_CategoryHeadName;
        private System.Windows.Forms.Button btn_SaveCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}