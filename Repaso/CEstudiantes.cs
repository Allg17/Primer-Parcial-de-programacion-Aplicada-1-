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

namespace Repaso
{
    public partial class CEstudiantes : Form
    {
        List<Estudiantes> datos = new List<Estudiantes>();
        public CEstudiantes()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            String a;
            a = CriteriotextBox.Text;
            int ID;
            int.TryParse(CriteriotextBox.Text, out ID);

            if (FiltrarcomboBox.SelectedIndex == 0)
                datos = BLL.EstudiantesBLL.GetList(t => t.Nombre.Contains(a));
            else
                datos = BLL.EstudiantesBLL.GetList(t => t.EstudianteID== ID);
            PersonasdataGridView.DataSource = datos;
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            cReporte abrir = new cReporte(datos);
            abrir.Show();
        }
    }
}
