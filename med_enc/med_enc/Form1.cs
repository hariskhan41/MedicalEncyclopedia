﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void کیٹیگریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
            this.Hide();
        }

        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MedDbEntities db = new MedDbEntities();
            Diseases d = new Diseases();
            d.englishName = txt_DiseaseEnglishName.Text;
            d.urduName = txt_DiseaseUrduName.Text;
            d.description = txt_DiseaseDetails.Text;
            d.categoryName = cmb_DiseaseCategory.Text;
            if (d.Add() == false)
            {
                cmb_DiseaseCategory.Items.Clear();
                d.AddCategoryToCombobox(cmb_DiseaseCategory);
                lbl_ErrorEnglishName.Text = d.errorEnglishName;
                lbl_ErrorEnglishName.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorUrduName.Text = d.errorUrduName;
                lbl_ErrorUrduName.ForeColor = System.Drawing.Color.Red;
                txt_DiseaseEnglishName.Clear();
                txt_DiseaseUrduName.Clear();
                return;
            }

            Symptoms s = new Symptoms();
            s.AddSymptomsToDb();

            List<string> lstSymName = new List<string>();
            foreach (Symptoms s1 in Symptoms.lstSym)
            {
                string s2 = s1.SymptomName;
                lstSymName.Add(s2);
            }

            foreach (string s3 in lstSymName)
            {
                int diseaseId = d.getDiseaseIdFromName(d.urduName);
                int symId = s.getSymIdFromName(s3);
                Disease dt = new Disease();
                dt.Id = diseaseId;
                db.Diseases.Add(dt);
                db.Diseases.Attach(dt);
                Symptom st = new Symptom();
                st.Id = symId;
                db.Symptoms.Add(st);
                db.Symptoms.Attach(st);
                dt.Symptoms.Add(st);
                db.SaveChanges();
            }
            

            

            MessageBox.Show("تفصیلات محفوظ ہو چکی ہیں");
            

            //if (d.Add() == true)
            //{
            //    MessageBox.Show("بیماری محفوظ کر دی گیؑ ہے");
            //    txt_DiseaseEnglishName.Clear();
            //    txt_DiseaseUrduName.Clear();
            //    txt_DiseaseDetails.Clear();
            //    cmb_DiseaseCategory.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("بیماری کا نام پہلے سے موجود ہے");
            //}
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDbDataSet1.Symptoms' table. You can move, or remove it, as needed.
            this.symptomsTableAdapter.Fill(this.medDbDataSet1.Symptoms);
            Diseases d = new Diseases();
            d.AddCategoryToCombobox(cmb_DiseaseCategory);

            dgv_symptoms.DataSource = null;
            dgv_symptoms.Rows.Clear();
            Symptoms s = new Symptoms();
            s.AddSymptomsToComboBox(cmb_Symptom);
        }

        private void btn_AddSymptoms_Click(object sender, EventArgs e)
        {
            
            Symptoms s = new Symptoms();
            if (s.InvalidName(cmb_Symptom.Text))
            {
                lbl_ErrorSymptom.Text = s.errorSymptomName;
                lbl_ErrorSymptom.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                s.SymptomName = cmb_Symptom.Text;
                s.AddToList();
                s.ShowInGrid(dgv_symptoms);
            }
        }

        private void dgv_symptoms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = dgv_symptoms.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (val == "حزف کریں")
            {
                Symptoms s = new Symptoms();
                int rowId = Convert.ToInt32(dgv_symptoms.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                s.DeleteFromList(rowId);
                s.ShowInGrid(dgv_symptoms);
            }
        }
    }
}
