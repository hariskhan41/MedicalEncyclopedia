using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class DiseaseDetails
    {
        public int Id { get; set; }

        public string UrduName { get; set; }

        public string EnglishName { get; set; }

        public Nullable<int> CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string getCategoryNameFromCategoryId(Nullable<int> id)
        {
            string CategoryName = "";
            MedDbEntities db = new MedDbEntities();
            if (id != null)
            {
                foreach (Category c in db.Categories)
                {
                    if (c.Id == id)
                    {
                        CategoryName = c.Text;
                        break;
                    }
                }
            }
            return CategoryName;
        }

        public void ShowInGrid(DataGridView dgv)
        {
            List<DiseaseDetails> lst = new List<DiseaseDetails>();
            MedDbEntities db = new MedDbEntities();
            foreach (Disease d in db.Diseases)
            {
                DiseaseDetails dd = new DiseaseDetails();
                string s = getCategoryNameFromCategoryId(d.CategoryId);
                dd.Id = d.Id;
                dd.UrduName = d.UrduName;
                dd.EnglishName = d.EnglishName;
                dd.CategoryId = d.CategoryId;
                dd.CategoryName = s;
                lst.Add(dd);
            }
            dgv.DataSource = lst;
            
        }
    }
}
