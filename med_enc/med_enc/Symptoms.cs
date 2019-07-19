using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class Symptoms
    {
        public int Id { get; set; }

        public string SymptomName { get; set; }

        public string errorSymptomName { get; set; }

        public static List<Symptoms> lstSymDb = new List<Symptoms>();

        public static List<Symptoms> lstSym = new List<Symptoms>();
        



        public bool InvalidName(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    errorSymptomName = "علامت کا نام درست نہیں";
                    return true;
                }
            }
            return false;
        }

        public void AddSymptomsToComboBox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Symptom s in db.Symptoms)
            {
                cmb.Items.Add(s.SymptomName);
            }
            cmb.Refresh();
        }

        public int getSymIdFromName(string name)
        {
            int id = 0;
            MedDbEntities db = new MedDbEntities();
            foreach (Symptom s in db.Symptoms)
            {
                if (s.SymptomName == name)
                {
                    id = s.Id;
                    break;
                }
            }
            return id;
        }

        public void AddToList()
        {
            Symptoms s = new Symptoms();
            s.Id = getSymIdFromName(SymptomName);
            s.SymptomName = SymptomName;
            lstSym.Add(s);
        }

        public bool SymptomAlreadyInList(string name)
        {
            foreach (Symptoms s in lstSym)
            {
                if (s.SymptomName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowInGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = lstSym;
        }

        public void DeleteFromList(string name)
        {
            foreach (Symptoms s in lstSym)
            {
                if (s.SymptomName == name)
                {
                    lstSym.Remove(s);
                    break;
                }
            }
        }

        public void AddSymptomsToDb()
        {
            MedDbEntities db = new MedDbEntities();
            
            foreach (Symptoms s in lstSym)
            {
                if (s.Id == 0)
                {
                    Symptom sTbl = new Symptom();
                    sTbl.SymptomName = s.SymptomName;
                    db.Symptoms.Add(sTbl);
                }
            }
            db.SaveChanges();
        }
        


    }
}
