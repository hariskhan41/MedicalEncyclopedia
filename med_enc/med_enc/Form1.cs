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
            d.Add();

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
            Diseases d = new Diseases();
            d.AddCategoryToCombobox(cmb_DiseaseCategory);
        }
    }
}
