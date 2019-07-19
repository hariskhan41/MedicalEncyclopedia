using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class Treatment
    {
        public int Id { get; set; }

        [Display(Name = "Treatment")]
        public string MedName { get; set; }

        public string Type { get; set; }

        public string Potency { get; set; }

        public string DoctorRecommendations { get; set; }

        public string errorMedName { get; set; }

        public string errorType { get; set; }

        public string errorPotency { get; set; }

        public static List<Treatment> lstMedicalTreatment = new List<Treatment>();


        public void AddTreatmentToCombobox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Medicine m in db.Medicines)
            {
                if (m.Type == "طبی")
                {
                    cmb.Items.Add(m.MedName);
                }
            }
            cmb.Refresh();
        }

        public void AddTreatmentToComboBoxHomoeo(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Medicine m in db.Medicines)
            {
                if (m.Type == "ہومیو")
                {
                    cmb.Items.Add(m.MedName);
                }
            }
            cmb.Refresh();
        }

        public void AddTreatmentToComboBoxAloe(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Medicine m in db.Medicines)
            {
                if (m.Type == "ایلو")
                {
                    cmb.Items.Add(m.MedName);
                }
            }
            cmb.Refresh();
        }

        //public void AddTypeToComboBox(ComboBox cmb)
        //{
        //    MedDbEntities db = new MedDbEntities();
        //    foreach (Medicine m in db.Medicines)
        //    {
        //        cmb.Items.Add(m.Type);
        //    }
        //    cmb.Refresh();
        //}

        public void AddPotencyToComboBox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            //foreach (Medicine m in db.Medicines)
            //{
            //    cmb.Items.Add(m.Potency);
            //}
            //cmb.Refresh();
            var result = db.Medicines.Where(p1 => p1.Type == "طبی").Select(p2 => p2.Potency).Distinct();
            foreach (var v in result)
            {
                cmb.Items.Add(v);
            }
            cmb.Refresh();
        }

        public void AddPotencyToComboBoxHomoeo(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            var result = db.Medicines.Where(p1 => p1.Type == "ہومیو").Select(p2 => p2.Potency).Distinct();
            foreach (var v in result)
            {
                cmb.Items.Add(v);
            }
            cmb.Refresh();
        }

        public void AddPotencyToComboBoxAloe(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            var result = db.Medicines.Where(p1 => p1.Type == "ایلو").Select(p2 => p2.Potency).Distinct();
            foreach (var v in result)
            {
                cmb.Items.Add(v);
            }
            cmb.Refresh();
        }

        public int getMedIdFromName(string name)
        {
            int id = 0;
            MedDbEntities db = new MedDbEntities();
            foreach (Medicine m in db.Medicines)
            {
                if (m.MedName == name)
                {
                    id = m.Id;
                    break;
                }
            }
            return id;
        }

        public int getIdFromNameTypePotency(string name, string type, string potency)
        {
            int id = 0;
            MedDbEntities db = new MedDbEntities();
            foreach (Medicine m in db.Medicines)
            {
                if (m.MedName == name && m.Type == type && m.Potency == potency)
                {
                    id = m.Id;
                }
            }
            return id;
        }

        public void addToList()
        {
            Treatment t = new Treatment();
            t.Id = getIdFromNameTypePotency(MedName, Type, Potency);
            t.Type = Type;
            t.Potency = Potency;
            t.DoctorRecommendations = DoctorRecommendations;
            t.MedName = MedName;
            lstMedicalTreatment.Add(t);
        }

        public void ShowInGrid(DataGridView dgv)
        {
            List<Treatment> lstTemp = new List<Treatment>();
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.Type == "طبی")
                {
                    lstTemp.Add(t);
                }
            }
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = lstMedicalTreatment;
        }

        public bool invalidMedName(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    errorMedName = "علاج کا نام درست نہیں";
                    return true;
                }
            }
            if (string.IsNullOrWhiteSpace(s))
            {
                errorMedName = "علاج کا نام درست نہیں";
                return true;
            }
            if (string.IsNullOrEmpty(s))
            {
                errorMedName = "علاج کا نام درست نہیں";
                return true;
            }
            return false;
        }

        public bool invalidType(string t)
        {
            foreach (char c in t)
            {
                if (char.IsDigit(c))
                {
                    errorType = "طرز درست نہیں";
                    return true;
                }
            }
            if (string.IsNullOrEmpty(t))
            {
                errorType = "طرز درست نہیں";
                return true;
            }
            if (string.IsNullOrWhiteSpace(t))
            {
                errorType = "طرز درست نہیں";
                return true;
            }
            return false;
        }

        public bool invalidPotency(string p)
        {
            foreach (char c in p)
            {
                if (char.IsLetter(c))
                {
                    errorPotency = "قوت درست نہیں";
                    return true;
                }
            }
            if (string.IsNullOrWhiteSpace(p))
            {
                errorPotency = "قوت درست نہیں";
                return true;
            }
            if (string.IsNullOrEmpty(p))
            {
                errorPotency = "قوت درست نہیں";
                return true;
            }
            return false;
        }

        public bool treatmentAlreadyInList(string name, string type, string potency)
        {
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.MedName == name && t.Type == type && t.Potency == potency)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddToDb()
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.Id == 0)
                {
                    Medicine mTbl = new Medicine();
                    mTbl.MedName = t.MedName;
                    mTbl.Type = t.Type;
                    mTbl.Potency = t.Potency;
                    db.Medicines.Add(mTbl);
                }
            }
            db.SaveChanges();
        }

        public void ShowInGridHomoeo(DataGridView dgv)
        {
            List<Treatment> lstTemp = new List<Treatment>();
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.Type == "ہومیو")
                {
                    lstTemp.Add(t);
                }
            }
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = lstTemp;
        }

        public void ShowInGridAloe(DataGridView dgv)
        {
            List<Treatment> lstTemp = new List<Treatment>();
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.Type == "ایلو")
                {
                    lstTemp.Add(t);
                }
            }
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = lstTemp;
        }

        public void Delete(string name)
        {
            foreach (Treatment t in lstMedicalTreatment)
            {
                if (t.MedName == name)
                {
                    lstMedicalTreatment.Remove(t);
                    break;
                }
            }
        }
    }
}
