using System;
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
        public bool errorFlag = false;
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
            d.Add(db);
            if (d.errorUrduName != "" || d.errorEnglishName != "")
            {
                cmb_DiseaseCategory.Items.Clear();
                d.AddCategoryToCombobox(cmb_DiseaseCategory);
                lbl_ErrorEnglishName.Text = d.errorEnglishName;
                lbl_ErrorEnglishName.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorUrduName.Text = d.errorUrduName;
                lbl_ErrorUrduName.ForeColor = System.Drawing.Color.Red;
                txt_DiseaseEnglishName.Clear();
                txt_DiseaseUrduName.Clear();
                errorFlag = true;
            }
            Symptoms s = new Symptoms();
            if (Symptoms.lstSym.Count == 0)
            {
                lbl_ErrorSymptom.Text = "علامت کا انتخاب کریں";
                lbl_ErrorSymptom.ForeColor = System.Drawing.Color.Red;
                errorFlag = true;
            }
            if (Causes.lstCause.Count == 0)
            {
                lbl_errorCauseName.Text = "سبب کا ینتخاب کریں";
                lbl_errorCauseName.ForeColor = System.Drawing.Color.Red;
                errorFlag = true;
            }
            if (errorFlag == true)
            {
                MessageBox.Show("تفصیلات درست نہیں۔ تمام ٹیب دوبارہ دیکھیں۔ غلطیاں نمایاں کر دی گیؑ ہیں");
                return;
            }



            db.SaveChanges();

            s.AddSymptomsToDb();

            List<string> lstSymName = new List<string>();
            foreach (Symptoms s1 in Symptoms.lstSym)
            {
                string s2 = s1.SymptomName;
                lstSymName.Add(s2);
            }

            int diseaseId = d.getDiseaseIdFromName(d.urduName);

            foreach (string s3 in lstSymName)
            {
                MedDbEntities db1 = new MedDbEntities();

                int symId = s.getSymIdFromName(s3);
                Disease dt = new Disease();
                dt.Id = diseaseId;
                db1.Diseases.Add(dt);
                db1.Diseases.Attach(dt);
                Symptom st = new Symptom();
                st.Id = symId;
                db1.Symptoms.Add(st);
                db1.Symptoms.Attach(st);
                dt.Symptoms.Add(st);
                db1.SaveChanges();
            }
            Symptoms.lstSym.Clear();
            dgv_symptoms.DataSource = null;
            dgv_symptoms.Rows.Clear();



            Causes c = new Causes();
            c.AddCauseToDb();

            List<string> lstCauseName = new List<string>();
            foreach (Causes c1 in Causes.lstCause)
            {
                string ctemp1 = c1.ReasonName;
                lstCauseName.Add(ctemp1);
            }

            foreach (string s4 in lstCauseName)
            {
                MedDbEntities db2 = new MedDbEntities();

                int causeId = c.getReasonIdFromName(s4);
                Disease dt = new Disease();
                dt.Id = diseaseId;
                db2.Diseases.Add(dt);
                db2.Diseases.Attach(dt);
                Reason rt = new Reason();
                rt.ReasonId = causeId;
                db2.Reasons.Add(rt);
                db2.Reasons.Attach(rt);
                dt.Reasons.Add(rt);
                db2.SaveChanges();
            }
            Causes.lstCause.Clear();
            dgv_Causes.DataSource = null;
            dgv_Causes.Rows.Clear();


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
            // TODO: This line of code loads data into the 'medDbDataSet2.Reason' table. You can move, or remove it, as needed.
            this.reasonTableAdapter.Fill(this.medDbDataSet2.Reason);
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

        private void btn_AddCause_Click(object sender, EventArgs e)
        {
            Causes c = new Causes();
            if (c.InvalidName(cmb_CauseName.Text))
            {
                lbl_errorCauseName.Text = c.errorCauseName;
                lbl_errorCauseName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                c.ReasonName = cmb_CauseName.Text;
                c.addToList();
                c.ShowInGrid(dgv_Causes);
            }
        }

        private void dgv_Causes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
