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
            this.reasonTableAdapter = new med_enc.MedDbDataSet2TableAdapters.ReasonTableAdapter();
            this.symptomsTableAdapter = new med_enc.MedDbDataSet1TableAdapters.SymptomsTableAdapter();
            this.medicinesTableAdapter = new med_enc.MedDbDataSet3TableAdapters.MedicinesTableAdapter();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet3 = new med_enc.MedDbDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Details = new System.Windows.Forms.DataGridView();
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDbDataSet4 = new med_enc.MedDbDataSet4();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new med_enc.MedDbDataSet4TableAdapters.CategoryTableAdapter();
            this.diseaseTableAdapter = new med_enc.MedDbDataSet4TableAdapters.DiseaseTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urduNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 641);
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
            this.Text});
            this.dgv_Details.DataSource = this.diseaseBindingSource;
            this.dgv_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Details.Location = new System.Drawing.Point(0, 0);
            this.dgv_Details.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_Details.Name = "dgv_Details";
            this.dgv_Details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Details.Size = new System.Drawing.Size(878, 641);
            this.dgv_Details.TabIndex = 0;
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataMember = "Disease";
            this.diseaseBindingSource.DataSource = this.medDbDataSet4BindingSource;
            // 
            // medDbDataSet4BindingSource
            // 
            this.medDbDataSet4BindingSource.DataSource = this.medDbDataSet4;
            this.medDbDataSet4BindingSource.Position = 0;
            // 
            // medDbDataSet4
            // 
            this.medDbDataSet4.DataSetName = "MedDbDataSet4";
            this.medDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "کیٹیگری کا نام";
            this.Text.Name = "Text";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 641);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource symptomsBindingSource;
        private MedDbDataSet1 medDbDataSet1;
        private System.Windows.Forms.BindingSource reasonBindingSource;
        private MedDbDataSet2 medDbDataSet2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}