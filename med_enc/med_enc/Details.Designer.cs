namespace med_enc
{
    partial class Details
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
            this.symptomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet1 = new med_enc.MedDbDataSet1();
            this.reasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet2 = new med_enc.MedDbDataSet2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فائلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انتظامیامورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کیٹیگریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بیماریوںکیتفصیلاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رپورٹسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskbarPanel = new System.Windows.Forms.Panel();
            this.EmptyPanel = new System.Windows.Forms.Panel();
            this.reasonTableAdapter = new med_enc.MedDbDataSet2TableAdapters.ReasonTableAdapter();
            this.symptomsTableAdapter = new med_enc.MedDbDataSet1TableAdapters.SymptomsTableAdapter();
            this.medicinesTableAdapter = new med_enc.MedDbDataSet3TableAdapters.MedicinesTableAdapter();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet3 = new med_enc.MedDbDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Details = new System.Windows.Forms.DataGridView();
            this.medDbDataSet4 = new med_enc.MedDbDataSet4();
            this.medDbDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new med_enc.MedDbDataSet4TableAdapters.CategoryTableAdapter();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseTableAdapter = new med_enc.MedDbDataSet4TableAdapters.DiseaseTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urduNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نیبیماریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نیکیٹیگریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.TaskbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // symptomsBindingSource
            // 
            this.symptomsBindingSource.DataMember = "Symptoms";
            this.symptomsBindingSource.DataSource = this.medDbDataSet1;
            // 
            // medDbDataSet1
            // 
            this.medDbDataSet1.DataSetName = "MedDbDataSet1";
            this.medDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reasonBindingSource
            // 
            this.reasonBindingSource.DataMember = "Reason";
            this.reasonBindingSource.DataSource = this.medDbDataSet2;
            // 
            // medDbDataSet2
            // 
            this.medDbDataSet2.DataSetName = "MedDbDataSet2";
            this.medDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فائلToolStripMenuItem,
            this.انتظامیامورToolStripMenuItem,
            this.بیماریوںکیتفصیلاتToolStripMenuItem,
            this.رپورٹسToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(878, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuBar";
            // 
            // فائلToolStripMenuItem
            // 
            this.فائلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نیبیماریToolStripMenuItem,
            this.نیکیٹیگریToolStripMenuItem});
            this.فائلToolStripMenuItem.Name = "فائلToolStripMenuItem";
            this.فائلToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.فائلToolStripMenuItem.Text = "فائل";
            // 
            // انتظامیامورToolStripMenuItem
            // 
            this.انتظامیامورToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کیٹیگریToolStripMenuItem});
            this.انتظامیامورToolStripMenuItem.Name = "انتظامیامورToolStripMenuItem";
            this.انتظامیامورToolStripMenuItem.Size = new System.Drawing.Size(68, 31);
            this.انتظامیامورToolStripMenuItem.Text = "انتظامی امور";
            // 
            // کیٹیگریToolStripMenuItem
            // 
            this.کیٹیگریToolStripMenuItem.Name = "کیٹیگریToolStripMenuItem";
            this.کیٹیگریToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.کیٹیگریToolStripMenuItem.Text = "کیٹیگری";
            // 
            // بیماریوںکیتفصیلاتToolStripMenuItem
            // 
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Name = "بیماریوںکیتفصیلاتToolStripMenuItem";
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Size = new System.Drawing.Size(98, 31);
            this.بیماریوںکیتفصیلاتToolStripMenuItem.Text = "بیماریوں کی تفصیلات";
            // 
            // رپورٹسToolStripMenuItem
            // 
            this.رپورٹسToolStripMenuItem.Name = "رپورٹسToolStripMenuItem";
            this.رپورٹسToolStripMenuItem.Size = new System.Drawing.Size(55, 31);
            this.رپورٹسToolStripMenuItem.Text = "رپورٹس";
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.Controls.Add(this.menuStrip1);
            this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskbarPanel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(878, 35);
            this.TaskbarPanel.TabIndex = 22;
            // 
            // EmptyPanel
            // 
            this.EmptyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmptyPanel.Location = new System.Drawing.Point(789, 35);
            this.EmptyPanel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.EmptyPanel.Name = "EmptyPanel";
            this.EmptyPanel.Size = new System.Drawing.Size(89, 606);
            this.EmptyPanel.TabIndex = 23;
            // 
            // reasonTableAdapter
            // 
            this.reasonTableAdapter.ClearBeforeFill = true;
            // 
            // symptomsTableAdapter
            // 
            this.symptomsTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.medDbDataSet3;
            // 
            // medDbDataSet3
            // 
            this.medDbDataSet3.DataSetName = "MedDbDataSet3";
            this.medDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 606);
            this.panel1.TabIndex = 25;
            // 
            // dgv_Details
            // 
            this.dgv_Details.AutoGenerateColumns = false;
            this.dgv_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Details.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.englishNameDataGridViewTextBoxColumn,
            this.urduNameDataGridViewTextBoxColumn,
            this.addedOnDataGridViewTextBoxColumn,
            this.updatedOnDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.CategoryName});
            this.dgv_Details.DataSource = this.diseaseBindingSource;
            this.dgv_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Details.Location = new System.Drawing.Point(0, 0);
            this.dgv_Details.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_Details.Name = "dgv_Details";
            this.dgv_Details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Details.Size = new System.Drawing.Size(789, 606);
            this.dgv_Details.TabIndex = 0;
            // 
            // medDbDataSet4
            // 
            this.medDbDataSet4.DataSetName = "MedDbDataSet4";
            this.medDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medDbDataSet4BindingSource
            // 
            this.medDbDataSet4BindingSource.DataSource = this.medDbDataSet4;
            this.medDbDataSet4BindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.medDbDataSet4BindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataMember = "Disease";
            this.diseaseBindingSource.DataSource = this.medDbDataSet4BindingSource;
            // 
            // diseaseTableAdapter
            // 
            this.diseaseTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.medDbDataSet4BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // englishNameDataGridViewTextBoxColumn
            // 
            this.englishNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn.HeaderText = "انگریزی نام";
            this.englishNameDataGridViewTextBoxColumn.Name = "englishNameDataGridViewTextBoxColumn";
            // 
            // urduNameDataGridViewTextBoxColumn
            // 
            this.urduNameDataGridViewTextBoxColumn.DataPropertyName = "UrduName";
            this.urduNameDataGridViewTextBoxColumn.HeaderText = "اردو نام";
            this.urduNameDataGridViewTextBoxColumn.Name = "urduNameDataGridViewTextBoxColumn";
            // 
            // addedOnDataGridViewTextBoxColumn
            // 
            this.addedOnDataGridViewTextBoxColumn.DataPropertyName = "AddedOn";
            this.addedOnDataGridViewTextBoxColumn.HeaderText = "AddedOn";
            this.addedOnDataGridViewTextBoxColumn.Name = "addedOnDataGridViewTextBoxColumn";
            this.addedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedOnDataGridViewTextBoxColumn
            // 
            this.updatedOnDataGridViewTextBoxColumn.DataPropertyName = "UpdatedOn";
            this.updatedOnDataGridViewTextBoxColumn.HeaderText = "UpdatedOn";
            this.updatedOnDataGridViewTextBoxColumn.Name = "updatedOnDataGridViewTextBoxColumn";
            this.updatedOnDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "کیٹیگری کا نام";
            this.CategoryName.Name = "CategoryName";
            // 
            // نیبیماریToolStripMenuItem
            // 
            this.نیبیماریToolStripMenuItem.Name = "نیبیماریToolStripMenuItem";
            this.نیبیماریToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.نیبیماریToolStripMenuItem.Text = "نیؑ بیماری";
            this.نیبیماریToolStripMenuItem.Click += new System.EventHandler(this.نیبیماریToolStripMenuItem_Click);
            // 
            // نیکیٹیگریToolStripMenuItem
            // 
            this.نیکیٹیگریToolStripMenuItem.Name = "نیکیٹیگریToolStripMenuItem";
            this.نیکیٹیگریToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.نیکیٹیگریToolStripMenuItem.Text = "نیؑ  کیٹیگری";
            this.نیکیٹیگریToolStripMenuItem.Click += new System.EventHandler(this.نیکیٹیگریToolStripMenuItem_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmptyPanel);
            this.Controls.Add(this.TaskbarPanel);
            this.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Details";
            this.Text = "تفصیلات";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TaskbarPanel.ResumeLayout(false);
            this.TaskbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource symptomsBindingSource;
        private MedDbDataSet1 medDbDataSet1;
        private System.Windows.Forms.BindingSource reasonBindingSource;
        private MedDbDataSet2 medDbDataSet2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فائلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انتظامیامورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کیٹیگریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بیماریوںکیتفصیلاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رپورٹسToolStripMenuItem;
        private System.Windows.Forms.Panel TaskbarPanel;
        private System.Windows.Forms.Panel EmptyPanel;
        private MedDbDataSet2TableAdapters.ReasonTableAdapter reasonTableAdapter;
        private MedDbDataSet1TableAdapters.SymptomsTableAdapter symptomsTableAdapter;
        private MedDbDataSet3TableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private MedDbDataSet3 medDbDataSet3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Details;
        private System.Windows.Forms.BindingSource medDbDataSet4BindingSource;
        private MedDbDataSet4 medDbDataSet4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MedDbDataSet4TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private MedDbDataSet4TableAdapters.DiseaseTableAdapter diseaseTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urduNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.ToolStripMenuItem نیبیماریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نیکیٹیگریToolStripMenuItem;
    }
}