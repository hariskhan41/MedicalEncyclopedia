using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class Diseases
    {
        public string englishName { get; set; }

        public string urduName { get; set; }

        public DateTime addedOn { get; set; }

        public DateTime updatedOn { get; set; }

        public string description { get; set; }

        public string categoryName { get; set; }

        public string errorUrduName { get; set; }

        public string errorEnglishName { get; set; }

        public bool NameHasDigit(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddCategoryToCombobox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Category c in db.Categories)
            {
                cmb.Items.Add(c.Text);
            }
            cmb.Refresh();
        }

        public int GetCatIdFromCatName(string name)
        {
            int catId = -1;
            MedDbEntities db = new MedDbEntities();
            foreach (Category c in db.Categories)
            {
                if (c.Text == name)
                {
                    catId = c.Id;
                }
            }
            return catId;
        }

        public bool DiseaseAlreadyExist(string englishName, string urduName)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Disease d in db.Diseases)
            {
                if (d.EnglishName == englishName || d.UrduName == urduName)
                {
                    return true;
                }
            }
            return false;
        }

        public int getDiseaseIdFromName(string name)
        {
            int id = 0;
            MedDbEntities db = new MedDbEntities();
            foreach (Disease d in db.Diseases)
            {
                if (d.UrduName == name)
                {
                    id = d.Id;
                }
            }
            return id;
        }

        public bool Add()
        {
            MedDbEntities db = new MedDbEntities();
            Disease diseaseTbl = new Disease();
            if (DiseaseAlreadyExist(englishName, urduName) == true)
            {
                errorEnglishName = "بیماری پہلے سے موجود ہے";
                errorUrduName = "بیماری پہلے سے موجود ہے";
                return false;
            }
            else if (NameHasDigit(urduName) == true || NameHasDigit(englishName) == true)
            {
                if (NameHasDigit(urduName))
                {
                    errorUrduName = "بیماری کا نام درست نہیں";
                }
                if (NameHasDigit(englishName))
                {
                    errorEnglishName = "بیماری کا نام درست نہیں";
                }
                return false;
            }
            else
            {
                diseaseTbl.EnglishName = englishName;
                diseaseTbl.UrduName = urduName;
                diseaseTbl.AddedOn = DateTime.Now;
                diseaseTbl.UpdatedOn = DateTime.Now;
                diseaseTbl.Description = description;
                int catId = GetCatIdFromCatName(categoryName);
                if (catId != -1)
                {
                    diseaseTbl.CategoryId = catId;
                }
                else
                {
                    diseaseTbl.CategoryId = null;
                }
                db.Diseases.Add(diseaseTbl);
                db.SaveChanges();
                errorEnglishName = "";
                errorUrduName = "";
                return true;
            }
        }


    }
}
