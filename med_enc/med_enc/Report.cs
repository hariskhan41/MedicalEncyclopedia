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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportData r = new ReportData();
            List<ReportData> lst = new List<ReportData>();
            //lst = r.Data();
            DetailedReport crpt = new DetailedReport();
            int i = Details.printId;
            crpt.SetParameterValue("@Id", Details.printId, "ReasonsRPT");
            crpt.SetParameterValue("@Id", Details.printId, "DiseaseNameCategory");
            crpt.SetParameterValue("@Id", Details.printId, "SymptomsRPT");
            crpt.SetParameterValue("@Id", Details.printId, "MedicinesRPT");

            //crpt.SetParameterValue("@Id", 40, "ReasonsRPT");

            //ReasonsReport reasonsCrpt = new ReasonsReport();
            //reasonsCrpt.SetParameterValue("@Id", 40);
            //crpt.SetDataSource(lst);
            crystalReportViewer1.ReportSource = crpt;
            

        }
    }
}
