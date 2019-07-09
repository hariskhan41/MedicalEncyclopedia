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
    public partial class Categories : Form
    {
        public static bool editFlag = false;
        public static int categoryId = -1;

        public Categories()
        {
            InitializeComponent();
        }

        private void btn_SaveCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDbDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.medDbDataSet.Category);
            MedDbEntities db = new MedDbEntities();
            CatagoryDetails catDetails = new CatagoryDetails();
            catDetails.AddCatagoryParentNameToCombobox(cmb_CategoryHeadName);
            var p = db.Categories.ToList();
            DataTable dt = new DataTable();
            dgv_CategoryDetails.DataSource = db.Categories.ToList();
            
            int rows = dgv_CategoryDetails.Rows.Count;
            
            for (int i = 0; i < rows; i++)
            {
                string s = dgv_CategoryDetails.Rows[i].Cells[2].FormattedValue.ToString();
                if (s != "")
                {
                    dgv_CategoryDetails.Rows[i].Cells[3].Value = catDetails.getCategoryNameFromId(Convert.ToInt32(s));
                }
            }
            
        }

        private void dgv_CategoryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dgv_CategoryDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (s == "ترمیم")
            {
                txt_CategoryName.Text = dgv_CategoryDetails.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txt_CategoryDetails.Text = dgv_CategoryDetails.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmb_CategoryHeadName.Text = dgv_CategoryDetails.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                categoryId = Convert.ToInt32(dgv_CategoryDetails.Rows[e.RowIndex].Cells[6].FormattedValue);
                editFlag = true;
            }
            else if (s == "حزف کریں")
            {
                CatagoryDetails catDetails = new CatagoryDetails();
                catDetails.categoryId = Convert.ToInt32(dgv_CategoryDetails.Rows[e.RowIndex].Cells[6].FormattedValue);
                catDetails.Delete(catDetails.categoryId);
                MedDbEntities db = new MedDbEntities();
                var p = db.Categories.ToList();
                dgv_CategoryDetails.DataSource = db.Categories.ToList();
                int rows = dgv_CategoryDetails.Rows.Count;

                for (int i = 0; i < rows; i++)
                {
                    string s1 = dgv_CategoryDetails.Rows[i].Cells[2].FormattedValue.ToString();
                    if (s1 != "")
                    {
                        dgv_CategoryDetails.Rows[i].Cells[3].Value = catDetails.getCategoryNameFromId(Convert.ToInt32(s1));
                    }
                }
            }
        }

        private void btn_SaveCategory_Click_1(object sender, EventArgs e)
        {
            if (editFlag == false)
            {
                CatagoryDetails catDetails = new CatagoryDetails();
                catDetails.catagoryName = txt_CategoryName.Text;
                catDetails.catagoryDescription = txt_CategoryDetails.Text;
                catDetails.catagoryParentName = cmb_CategoryHeadName.Text;
                if (catDetails.Add() == true)
                {
                    MessageBox.Show("!کیٹیگوری محفوز ہو چکی ہے");
                    MedDbEntities db = new MedDbEntities();
                    var p = db.Categories.ToList();
                    dgv_CategoryDetails.DataSource = db.Categories.ToList();
                    int rows = dgv_CategoryDetails.Rows.Count;

                    for (int i = 0; i < rows; i++)
                    {
                        string s = dgv_CategoryDetails.Rows[i].Cells[2].FormattedValue.ToString();
                        if (s != "")
                        {
                            dgv_CategoryDetails.Rows[i].Cells[3].Value = catDetails.getCategoryNameFromId(Convert.ToInt32(s));
                        }
                    }
                    txt_CategoryName.Clear();
                    txt_CategoryDetails.Clear();

                }
                else
                {
                    MessageBox.Show("کیٹیگی پہلے سے موجود ہے");
                    //catDetails.AddCatagoryParentNameToCombobox(cmb_CategoryHeadName);
                }
            }
            else
            {
                CatagoryDetails catDetails = new CatagoryDetails();
                catDetails.catagoryName = txt_CategoryName.Text;
                catDetails.catagoryDescription = txt_CategoryDetails.Text;
                catDetails.categoryId = categoryId;
                catDetails.catagoryParentName = cmb_CategoryHeadName.Text;
                if (catDetails.Edit() == true)
                {
                    MessageBox.Show("!کیٹیگوری محفوز ہو چکی ہے");
                    MedDbEntities db = new MedDbEntities();
                    var p = db.Categories.ToList();
                    dgv_CategoryDetails.DataSource = db.Categories.ToList();
                    int rows = dgv_CategoryDetails.Rows.Count;

                    for (int i = 0; i < rows; i++)
                    {
                        string s = dgv_CategoryDetails.Rows[i].Cells[2].FormattedValue.ToString();
                        if (s != "")
                        {
                            dgv_CategoryDetails.Rows[i].Cells[3].Value = catDetails.getCategoryNameFromId(Convert.ToInt32(s));
                        }
                    }
                    txt_CategoryName.Clear();
                    txt_CategoryDetails.Clear();

                }
                else
                {
                    MessageBox.Show("کیٹیگی پہلے سے موجود ہے");
                }
            }
        }
    }
}
