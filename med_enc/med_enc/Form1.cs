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
            errorFlag = false;
            lbl_errorCauseName.Text = "";
            lbl_ErrorEnglishName.Text = "";
            lbl_ErrorMedicalCureName.Text = "";
            lbl_ErrorPotency.Text = "";
            lbl_ErrorSymptom.Text = "";
            //lbl_ErrorType.Text = "";
            lbl_ErrorUrduName.Text = "";
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
            if (Treatment.lstMedicalTreatment.Count == 0)
            {
                lbl_ErrorMedicalCureName.Text = "علاج کا انتخاب کریں";
                lbl_ErrorMedicalCureName.ForeColor = System.Drawing.Color.Red;
                //lbl_ErrorType.Text = "طرز کا انتخاب کریں";
                //lbl_ErrorType.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorPotency.Text = "قوت درج کریں";
                lbl_ErrorPotency.ForeColor = System.Drawing.Color.Red;

                lbl_ErrorTreatmentNameHomoeo.Text = "علاج کا انتخاب کریں";
                lbl_ErrorTreatmentNameHomoeo.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorPotencyHomoeo.Text = "قوت درج کریں";
                lbl_ErrorPotencyHomoeo.ForeColor = System.Drawing.Color.Red;

                lbl_ErrorTreatmentNameAloe.Text = "علاج کا انتخاب کریں";
                lbl_ErrorTreatmentNameAloe.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorPotencyAloe.Text = "قوت درج کریں";
                lbl_ErrorPotencyAloe.ForeColor = System.Drawing.Color.Red;

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

            Treatment t = new Treatment();
            t.AddToDb();

            foreach (Treatment t1 in Treatment.lstMedicalTreatment)
            {
                DiseaseMedicine dmTbl = new DiseaseMedicine();
                dmTbl.DiseaseId = diseaseId;
                dmTbl.MedicineId = t1.getMedIdFromName(t1.MedName);
                dmTbl.DoctorRecommendations = txt_DoctorsRecomendation.Text;
                db.DiseaseMedicines.Add(dmTbl);
                db.SaveChanges();
            }
            Treatment.lstMedicalTreatment.Clear();
            dgv_MedicalCure.DataSource = null;
            dgv_MedicalCure.Rows.Clear();


            cmb_DiseaseCategory.Items.Clear();
            d.AddCategoryToCombobox(cmb_DiseaseCategory);

            cmb_Symptom.Items.Clear();
            s.AddSymptomsToComboBox(cmb_Symptom);

            //cmb_CauseName.Items.Clear();
            //c.AddCausesToComboBox(cmb_CauseName);

            cmb_MedicalCure.Items.Clear();
            t.AddTreatmentToCombobox(cmb_MedicalCure);
            //cmb_Types.Items.Clear();
            //t.AddTypeToComboBox(cmb_Types);
            cmb_Potency.Items.Clear();
            t.AddPotencyToComboBox(cmb_Potency);

            cmb_TreatmentNameHomoeo.Items.Clear();
            t.AddTreatmentToComboBoxHomoeo(cmb_TreatmentNameHomoeo);
            cmb_PotencyHomoeo.Items.Clear();
            t.AddPotencyToComboBoxHomoeo(cmb_PotencyHomoeo);

            cmb_CauseName.Text = "";
            cmb_DiseaseCategory.Text = "";
            cmb_MedicalCure.Text = "";
            cmb_Potency.Text = "";
            cmb_Symptom.Text = "";
            //cmb_Types.Text = "";
            txt_DiseaseDetails.Text = "";
            txt_DiseaseEnglishName.Text = "";
            txt_DiseaseUrduName.Text = "";
            txt_DoctorsRecomendation.Text = "";

            cmb_TreatmentNameHomoeo.Text = "";
            cmb_PotencyHomoeo.Text = "";
            txt_DoctorsRecommendationHomoeo.Text = "";

            cmb_TreatmentNameAloe.Text = "";
            cmb_PotencyAloe.Text = "";
            txt_DoctorsRecommendationAloe.Text = "";


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
            // TODO: This line of code loads data into the 'medDbDataSet3.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.medDbDataSet3.Medicines);
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

            dgv_Causes.DataSource = null;
            dgv_Causes.Rows.Clear();
            //Causes c = new Causes();
            //c.AddCausesToComboBox(cmb_CauseName);

            dgv_MedicalCure.DataSource = null;
            dgv_MedicalCure.Rows.Clear();
            Treatment t = new Treatment();
            t.AddTreatmentToCombobox(cmb_MedicalCure);
            //t.AddTypeToComboBox(cmb_Types);
            t.AddPotencyToComboBox(cmb_Potency);

            dgv_TreatmentHomoeo.DataSource = null;
            dgv_TreatmentHomoeo.Rows.Clear();
            t.AddTreatmentToComboBoxHomoeo(cmb_TreatmentNameHomoeo);
            t.AddPotencyToComboBoxHomoeo(cmb_PotencyHomoeo);

            dgv_TreatmentAloe.DataSource = null;
            dgv_TreatmentAloe.Rows.Clear();
            t.AddTreatmentToComboBoxAloe(cmb_TreatmentNameAloe);
            t.AddPotencyToComboBoxAloe(cmb_PotencyAloe);
        }

        private void btn_AddSymptoms_Click(object sender, EventArgs e)
        {
            
            Symptoms s = new Symptoms();
            if (s.InvalidName(cmb_Symptom.Text))
            {
                lbl_ErrorSymptom.Text = s.errorSymptomName;
                lbl_ErrorSymptom.ForeColor = System.Drawing.Color.Red;
            }
            else if (s.SymptomAlreadyInList(cmb_Symptom.Text))
            {
                lbl_ErrorSymptom.Text = "علاج پہلے سے موجود ہے";
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
                string name = dgv_symptoms.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                s.DeleteFromList(name);
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
            else if (c.CauseAlreadyInList(cmb_CauseName.Text))
            {
                lbl_errorCauseName.Text = "سبب پہلے سے موجود ہے";
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
            string val = dgv_Causes.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (val == "حزف کریں")
            {
                Causes c = new Causes();
                string name = dgv_Causes.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                c.DeleteFromList(name);
                c.ShowInGrid(dgv_Causes);
            }
        }

        private void body_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_AddMedicalTreatment_Click(object sender, EventArgs e)
        {
            bool errFlag = false;
            Treatment t = new Treatment();
            if (t.invalidMedName(cmb_MedicalCure.Text))
            {
                errFlag = true;
                lbl_ErrorMedicalCureName.Text = t.errorMedName;
                lbl_ErrorMedicalCureName.ForeColor = System.Drawing.Color.Red;
            }
            
            if (t.invalidPotency(cmb_Potency.Text))
            {
                errFlag = true;
                lbl_ErrorPotency.Text = t.errorPotency;
                lbl_ErrorPotency.ForeColor = System.Drawing.Color.Red;
            }
            if (errFlag == false && t.treatmentAlreadyInList(cmb_MedicalCure.Text, "طبی", cmb_Potency.Text))
            {
                MessageBox.Show("یہ علاج پہلے سے موجود ہے");
                return;
            }
            if (errFlag == true)
            {
                return;
            }

            t.MedName = cmb_MedicalCure.Text;
            t.Potency = cmb_Potency.Text;
            t.DoctorRecommendations = txt_DoctorsRecomendation.Text;
            t.Type = "طبی";
            t.addToList();
            
            t.ShowInGrid(dgv_MedicalCure);
        }

        private void btn_AddHomoeoTreatment_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_AddTreamentHomoeo_Click(object sender, EventArgs e)
        {
            bool errFlag = false;
            Treatment t = new Treatment();
            if (t.invalidMedName(cmb_TreatmentNameHomoeo.Text))
            {
                errFlag = true;
                lbl_ErrorTreatmentNameHomoeo.Text = t.errorMedName;
                lbl_ErrorTreatmentNameHomoeo.ForeColor = System.Drawing.Color.Red;
            }

            //if (t.invalidPotency(cmb_Potency.Text))
            //{
            //    errFlag = true;
            //    lbl_ErrorPotency.Text = t.errorPotency;
            //    lbl_ErrorPotency.ForeColor = System.Drawing.Color.Red;
            //}
            if (errFlag == false && t.treatmentAlreadyInList(cmb_TreatmentNameHomoeo.Text, "ہومیو", cmb_PotencyHomoeo.Text))
            {
                MessageBox.Show("یہ علاج پہلے سے موجود ہے");
                return;
            }
            if (errFlag == true)
            {
                return;
            }

            t.MedName = cmb_TreatmentNameHomoeo.Text;
            t.Potency = cmb_PotencyHomoeo.Text;
            t.DoctorRecommendations = txt_DoctorsRecommendationHomoeo.Text;
            t.Type = "ہومیو";
            t.addToList();

            t.ShowInGridHomoeo(dgv_TreatmentHomoeo);
        }

        private void btn_AddTreatmentAloe_Click(object sender, EventArgs e)
        {
            bool errFlag = false;
            Treatment t = new Treatment();
            if (t.invalidMedName(cmb_TreatmentNameAloe.Text))
            {
                errFlag = true;
                lbl_ErrorTreatmentNameAloe.Text = t.errorMedName;
                lbl_ErrorTreatmentNameAloe.ForeColor = System.Drawing.Color.Red;
            }

            //if (t.invalidPotency(cmb_Potency.Text))
            //{
            //    errFlag = true;
            //    lbl_ErrorPotency.Text = t.errorPotency;
            //    lbl_ErrorPotency.ForeColor = System.Drawing.Color.Red;
            //}
            if (errFlag == false && t.treatmentAlreadyInList(cmb_TreatmentNameAloe.Text, "ایلو", cmb_PotencyAloe.Text))
            {
                MessageBox.Show("یہ علاج پہلے سے موجود ہے");
                return;
            }
            if (errFlag == true)
            {
                return;
            }

            t.MedName = cmb_TreatmentNameAloe.Text;
            t.Potency = cmb_PotencyAloe.Text;
            t.DoctorRecommendations = txt_DoctorsRecommendationAloe.Text;
            t.Type = "ایلو";
            t.addToList();

            t.ShowInGridAloe(dgv_TreatmentAloe);
        }

        private void dgv_MedicalCure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = dgv_MedicalCure.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (val == "حزف کریں")
            {
                Treatment t = new Treatment();
                string name = dgv_MedicalCure.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                t.Delete(name);
                t.ShowInGrid(dgv_MedicalCure);
            }
        }

        private void dgv_TreatmentHomoeo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = dgv_TreatmentHomoeo.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (val == "حزف کریں")
            {
                Treatment t = new Treatment();
                string name = dgv_TreatmentHomoeo.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                t.Delete(name);
                t.ShowInGridHomoeo(dgv_TreatmentHomoeo);
            }
        }

        private void dgv_TreatmentAloe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = dgv_TreatmentAloe.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (val == "حزف کریں")
            {
                Treatment t = new Treatment();
                string name = dgv_TreatmentAloe.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                t.Delete(name);
                t.ShowInGridAloe(dgv_TreatmentAloe);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
