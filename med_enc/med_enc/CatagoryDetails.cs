using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med_enc
{
    class CatagoryDetails
    {
        public static string temp { get; set; }

        public int categoryId { get; set; }

        public string catagoryName { get; set; }

        public string catagoryParentName { get; set; }

        public string catagoryDescription { get; set; }

        public void AddCatagoryParentNameToCombobox(ComboBox cmb)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Category c in db.Categories)
            {
                cmb.Items.Add(c.Text);
            }
            cmb.Refresh();
        }

        public bool categoryAlreadyExistsEdit(string name)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Category c in db.Categories)
            {
                if (c.Text == name && c.Text != temp)
                {
                    return true;
                }
            }
            return false;
        }

        public bool categoryAlreadyExists(string name)
        {
            MedDbEntities db = new MedDbEntities();
            foreach (Category c in db.Categories)
            {
                if (c.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int getCatagoryIdFromCatagoryName(string name)
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

        public string getCategoryNameFromId(int id)
        {
            MedDbEntities db = new MedDbEntities();
            return db.Categories.Find(id).Text;
        }

        

        public bool Add()
        {
            MedDbEntities db = new MedDbEntities();
            Category catTbl = new Category();
            if (categoryAlreadyExists(catagoryName) == true)
            {
                return false;
            }
            else
            {
                catTbl.Text = catagoryName;
                catTbl.Description = catagoryDescription;
                int parentCatId = getCatagoryIdFromCatagoryName(catagoryParentName);
                if (parentCatId != -1)
                {
                    catTbl.ParentId = parentCatId;
                }
                db.Categories.Add(catTbl);
                db.SaveChanges();
                return true;
            }
        }

        

        public bool Edit()
        {
            MedDbEntities db = new MedDbEntities();
            Category catTbl = new Category();
            //foreach (Category c in db.Categories)
            //{
            //    if (c.Id == categoryId)
            //    {
            //        c.Text = catagoryName;
            //        c.Description = catagoryDescription;
            //        int parentCatId = getCatagoryIdFromCatagoryName(catagoryParentName);
            //        if (parentCatId != -1)
            //        {
            //            c.ParentId = parentCatId;
            //        }
            //        else
            //        {
            //            c.ParentId = null;
            //        }

            //        break;
            //    }
            //}
            //db.SaveChanges();
            //return true;
            if (categoryAlreadyExistsEdit(catagoryName))
            {
                return false;
            }
            else
            {
                foreach (Category c in db.Categories)
                {
                    if (c.Id == categoryId)
                    {
                        c.Text = catagoryName;
                        c.Description = catagoryDescription;
                        int parentCatId = getCatagoryIdFromCatagoryName(catagoryParentName);
                        if (parentCatId != -1)
                        {
                            c.ParentId = parentCatId;
                        }
                        else
                        {
                            c.ParentId = null;
                        }

                        break;
                    }
                }
                db.SaveChanges();
                return true;
            }
        }

        public void Delete(int id)
        {
            MedDbEntities db = new MedDbEntities();
            foreach(Category c in db.Categories)
            {
                if (c.Id == id)
                {
                    db.Categories.Remove(c);
                    break;
                }
            }
            db.SaveChanges();
        }
    }
}
