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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDbDataSet4.Disease' table. You can move, or remove it, as needed.
            this.diseaseTableAdapter.Fill(this.medDbDataSet4.Disease);
            // TODO: This line of code loads data into the 'medDbDataSet4.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.medDbDataSet4.Category);
            DiseaseDetails d = new DiseaseDetails();
            MedDbEntities db = new MedDbEntities();
            //d.ShowInGrid(dgv_Details);
            //dgv_Details.DataSource = db.Diseases.ToList();
            //int rows = dgv_Details.Rows.Count;
            //for (int i = 0; i < rows; i++)
            //{
            //    if (dgv_Details.Rows[i].Cells[6].FormattedValue.ToString() != "")
            //    {
            //        dgv_Details.Rows[i].Cells[7].Value = d.getCategoryNameFromCategoryId(Convert.ToInt32(dgv_Details.Rows[i].Cells[6].FormattedValue.ToString()));
            //    }
            //}
        }

        private void نیکیٹیگریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
        }

        private void نیبیماریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            m.Show();
        }
    }
}
