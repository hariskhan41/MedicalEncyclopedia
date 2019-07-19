using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class Causes
    {
        public int ReasonId { get; set; }

        public string ReasonName { get; set; }

        public string errorCauseName { get; set; }

        public static List<Causes> lstCause = new List<Causes>();


        public void AddCausesToComboBox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach(Reason r in db.Reasons)
            {
                //cmb.Items.Add(cmb);
            }
            cmb.Refresh();
        }

        public int getReasonIdFromName(string name)
        {
            int id = 0;
            MedDbEntities db = new MedDbEntities();
            foreach (Reason r in db.Reasons)
            {
                if (r.ReasonName == name)
                {
                    id = r.ReasonId;
                    break;
                }
            }
            return id;
        }

        public void addToList()
        {
            Causes c = new Causes();
            c.ReasonId = getReasonIdFromName(ReasonName);
            c.ReasonName = ReasonName;
            lstCause.Add(c);
        }

        public void ShowInGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = lstCause;
        }

        public bool CauseAlreadyInList(string name)
        {
            foreach (Causes c in lstCause)
            {
                if (c.ReasonName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteFromList(string name)
        {
            foreach(Causes c in lstCause)
            {
                if (c.ReasonName == name)
                {
                    lstCause.Remove(c);
                    break;
                }
            }
        }

        public void AddCauseToDb()
        {
            MedDbEntities db = new MedDbEntities();

            foreach (Causes c in lstCause)
            {
                if (c.ReasonId == 0)
                {
                    Reason rTbl = new Reason();
                    rTbl.ReasonName = c.ReasonName;
                    db.Reasons.Add(rTbl);
                }
            }
            db.SaveChanges();
        }

        public bool InvalidName(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    errorCauseName = "سبب کا نام درست نہیں";
                    return true;
                }
            }
            return false;
        }
    }
}
