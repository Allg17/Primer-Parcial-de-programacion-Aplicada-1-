using CrystalDecisions.CrystalReports.Engine;
using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso.Reporte
{
    public partial class cReporte : Form
    {
        List<Estudiantes> reporte = new List<Estudiantes>();
        public cReporte(List<Estudiantes> datatable)
        {
            reporte = datatable; 
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            ReportDocument r = new ReportDocument();
            r.Load("C:/Users/Usuario/Desktop/01 Enero 2028/Aplicada 1/Primer Parcial/Repaso/Repaso/Reporte/EjemploReporte.rpt");
            r.SetDataSource(reporte);

            crystalReportViewer.ReportSource = r;
            crystalReportViewer.Refresh();
        }
    }
}
