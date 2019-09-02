using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace med_enc
{
    class ReportData
    {
        public static int printId = -1;
        public int diseaseId { get; set; }

        public string EnglishName { get; set; }

        public string UrduName { get; set; }

        public string CategoryName { get; set; }

        public List<string> ReasonIds { get; set; }

        public List<string> ReasonNames { get; set; }

        public List<string> Symptoms { get; set; }

        public List<string> Medicines { get; set; }

        public string Type { get; set; }

        public List<ReportData> Data()
        {
            List<ReportData> rptLst = new List<ReportData>();
           
            MedDbEntities db = new MedDbEntities();
            foreach (Disease d in db.Diseases)
            {
                ReportData r = new ReportData();
                List<string> tempR = new List<string>();
                List<string> tempS = new List<string>();
                List<string> tempM = new List<string>();
                r.EnglishName = d.EnglishName;
                r.UrduName = d.UrduName;
                r.diseaseId = d.Id;
                if (d.CategoryId == null)
                {
                    r.CategoryName = "";
                }
                else
                {
                    r.CategoryName = db.Categories.Find(d.CategoryId).Text;
                }
                IEnumerable<string> tempReasonLst = db.Diseases.First(a => a.Id == d.Id).Reasons.Select(r1 => r1.ReasonName);
                foreach (string s in tempReasonLst)
                {
                    tempR.Add(s);
                }
                IEnumerable<string> tempSymptomsLst = db.Diseases.First(a => a.Id == d.Id).Symptoms.Select(s1 => s1.SymptomName);
                foreach (string s in tempSymptomsLst)
                {
                    tempS.Add(s);
                }
                var tempMedLst = db.Medicines
                    .Join(
                        db.DiseaseMedicines.Where(a => a.DiseaseId == d.Id),
                        d1 => d1.Id,
                        f => f.MedicineId,
                        (d1, f) => d1
                    ).ToList();
                foreach (var s in tempMedLst)
                {
                    tempM.Add(s.MedName);
                }
                r.ReasonNames = tempR;
                r.Medicines = tempM;
                r.Symptoms = tempS;
                rptLst.Add(r);
            }

            return rptLst;
        }
    }
}
