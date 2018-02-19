using Repaso.Entidad;
using Repaso.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso.NotasCreditos_Form
{
    public partial class NConsulta : Form
    {
        public NConsulta()
        {
            InitializeComponent();
        }

        List<NotasCredito> datos = new List<NotasCredito>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            String a;
            a = CriteriotextBox.Text;
            int ID;
            int.TryParse(CriteriotextBox.Text, out ID);

            if (FiltrarcomboBox.SelectedIndex == 0)
                datos = BLL.NotasCreditoBLL.GetList(t => t.Observaciones.Contains(a));
            if(FiltrarcomboBox.SelectedIndex == 1)
                datos = BLL.NotasCreditoBLL.GetList(t => t.NotasID == ID);

            PersonasdataGridView.DataSource = datos;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            cReporteNotasCreditos abrir = new cReporteNotasCreditos(datos);
            abrir.Show();
        }

        private void MontoExoneradobutton_Click(object sender, EventArgs e)
        {
            cMontoExonerado abrir = new cMontoExonerado();
            abrir.Show();
        }
    }
}
